﻿using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus status { get; set; }
        public Seller Saller { get; set; }// uma venda pertence a um vendedor

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller saller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            this.status = status;
            Saller = saller;
        }
    }
}
