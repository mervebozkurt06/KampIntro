﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //urunun birim fiyati
        public int UnitsInStock { get; set; } //urunun stok adedi


    }
}
