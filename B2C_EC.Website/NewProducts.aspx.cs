﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using B2C_EC.Model;
using B2C_EC.Model.Data;
using B2C_EC.Model.Global;

namespace B2C_EC.Website
{
    public partial class NewProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProductsByService();
            }
        }

        private void LoadProductsByService()
        {
            rptProducts.DataSource = (new ProductRepo()).GetProductNew();
            rptProducts.DataBind();
        }

        protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Image img = (Image)e.Item.FindControl("imgProduct");
            HiddenField hdf = (HiddenField)e.Item.FindControl("hdfProductId");
            if (img != null && hdf != null)
            {
                ProductImage imageProduct = (new ProductImageRepo()).GetImageDefaultByProductId(Int32.Parse(hdf.Value));
                if (imageProduct != null)
                {
                    img.ImageUrl = "~/Resources/ImagesProduct/" + imageProduct.Image;
                }
            }
        }
        protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {
                HiddenField hdf = (HiddenField)e.Item.FindControl("hdfProductId");
                Product product = new ProductRepo().GetById(ToSQL.SQLToInt(hdf.Value));
                if (product != null)
                {
                    List<Cart> carts = (List<Cart>)Session["Carts"];
                    Cart cart = new Cart(carts);
                    cart = cart.ConverProductToCart(product);
                    carts = cart.Add(cart);
                    Session["Carts"] = carts;
                    Response.Redirect("ViewCart.aspx");
                }
            }
            else if (e.CommandName == "AddCompare")
            {
                CompareAndWish list = (CompareAndWish)Session["Compare"];
                if (list == null)
                    list = new CompareAndWish();
                Product p = (new ProductRepo()).GetById(ToSQL.SQLToInt(e.CommandArgument));
                if (p != null)
                {
                    if (list.Add(p))
                        Response.Write("<script type='text/javascript'>alert('Added!s');</script>");
                    else
                        Response.Write("<script type='text/javascript'>alert('Product is exist in list compare');</script>");
                }
                Session["Compare"] = list;
            }
        }
    }
}