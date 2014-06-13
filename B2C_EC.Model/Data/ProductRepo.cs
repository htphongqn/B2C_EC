﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_EC.Model.Data
{
    public class ProductRepo
    {
        private B2C_ECEntities db = new B2C_ECEntities();

        public List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }
        public Product GetById(int id)
        {
            return db.Products.Find(id);
        }
        public List<Product> GetListProductByService(int ServiceID)
        {
            return db.Products.Where(p => p.ProductType_ID == ServiceID).ToList();
        }
        public List<Product> GetProductBestSelling()
        {
            return new B2C_ECEntities().Products.Where(p => p.IsBestSelling == true).ToList();
        }

        public List<Product> GetListProductByProductTypeID(int ProductTypeId)
        {
            return db.Products.Where(p => p.ProductType_ID == ProductTypeId).ToList();
        }

        public List<Product> GetProductNew()
        {
            return db.Products.Where(p => p.IsNew == true).ToList();
        }

        public List<Product> GetProductSpecial()
        {
            return db.Products.Where(p => p.IsSpecial == true).ToList();
        }

        public List<Product> GetListProductPageIndex()
        {
            return db.Products.OrderBy(p => p.DateCreated).ToList();
        }

        public Product GetByProductID(int ProductId)
        {
            return db.Products.Where(p => p.ID == ProductId).FirstOrDefault();
        }

        public int CreateProduct(Product p) //Chi.Bui
        {
            try
            {
                db.Products.Add(p);
                return db.SaveChanges();
            }
            catch (Exception e)
            {                
                throw new Exception(e.Message);
            }
        }
    }
}
