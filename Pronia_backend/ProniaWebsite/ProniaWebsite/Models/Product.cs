﻿using System;
using System.Collections.Generic;

namespace ProniaWebsite.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public string BarCode { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }


    }
}
