﻿
namespace FuelStation.Model
{
    public class TransactionLine : BaseEntity
    {
        public Guid TransactionID { get; set; }
        //public Transaction Transaction { get; set; }
        public Guid ItemID { get; set; } 
        public Item Item { get; set; } 
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
    }
}
