﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2C_EC.Model;

namespace B2C_EC.Model.Data
{
    public class ProductTypeRepo //: HelperRepo<ProductType>
    {
        public List<ProductType> GetAllProductType()
        {
            return B2C_ECEntities.GetInstance().ProductTypes.ToList();
        }
        //public List<ProductType> GetAllProductType()
        //{
        //    return GetAll();
        //}

        //public int RemoveProductTypeById(int ProductTypeId)
        //{
        //    return Remove(ProductTypeId);
        //}

        //public int UpdateProductType(ProductType P)
        //{
        //    return Update(P);
        //}

        //public int InsertProductType(ProductType P)
        //{
        //    return Create(P);
        //}

        //public int RemoveProductType(ProductType p)
        //{
            //return Remove(p);
        //}
    }
}
