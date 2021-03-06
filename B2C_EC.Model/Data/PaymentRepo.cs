﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2C_EC.Model.Global;

namespace B2C_EC.Model.Data
{
    public class PaymentRepo
    {
        private B2C_ECEntities db = new B2C_ECEntities();

        public Payment GetById(int Id)
        {
            return db.Payments.Find(Id);
        }
        public List<Payment> GetAllPayment()
        {
            return db.Payments.ToList();
        }
    }
}
