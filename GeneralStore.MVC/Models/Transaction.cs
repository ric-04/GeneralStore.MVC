﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(Product))]
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalCost
        {
            get
            {
                return Product.UnitPrice * Quantity;
            }
        }
    }
}