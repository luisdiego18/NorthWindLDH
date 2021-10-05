using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit {get; set;}
        [Column(TypeName = "decimal(18,4)")]
        public decimal UnitPrice {get; set;}
        public int UnitsInStock {get; set;}
        public int UnitsOnOrder {get; set;}
        public int ReorderLevel {get; set;}
        public bool Discontinued {get; set;}
        public int CategoryId {get; set;}
        public Category Category {get; set;}
    }
}