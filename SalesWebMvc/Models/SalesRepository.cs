﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRepository
    {
        public int Id { get; set; }
        public int SalesRecordId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public SalesRepository()
        {

        }
        public SalesRepository(int id, int salesRecordId, int productId, Product product)
        {
            Id = id;
            SalesRecordId = salesRecordId;
            ProductId = productId;
            Product = product;
        }
    }
}