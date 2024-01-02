﻿using System.ComponentModel.DataAnnotations;
namespace Inz_Fn.Models
{
    public class StockHistory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Stock_CIK { get; set; }
        [Required]
        public string User_Id { get; set; }
        [Required]
        public int Price_per_stock { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime SellDate { get; set; }
        [Required]
        public int Income { get; set; }
    }
}