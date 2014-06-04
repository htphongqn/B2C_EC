﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using B2C_EC.Model;
using B2C_EC.Model.Data;
using B2C_EC.Model.Objects;

namespace B2C_EC.Website
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContact_Click(object sender, EventArgs e)
        {
            Model.Contact contact = new Model.Contact();
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text;
            contact.Email = txtEmail.Text;
            contact.Comments = txtComments.Text;
            int i = new ContactRepo().CreateContact(contact);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtComments.Text = "";
            lbMessage.Text = "Sent contact successfully!";
        }
    }
}