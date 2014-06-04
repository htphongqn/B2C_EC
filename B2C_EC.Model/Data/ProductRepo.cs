﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C_EC.Model.Data
{
    public class ProductRepo
    {
        B2C_ECEntities db = new B2C_ECEntities();
        public List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }

        public List<Product> GetListProductByService(int ServiceID)
        {
            return db.Products.Where(p => p.ProductType_ID == ServiceID).ToList();
        }
        public List<Product> GetProductBestSelling()
        {
            return new B2C_ECEntities().Products.Where(p => p.IsBestSeller == true).ToList();
        }
    }
}