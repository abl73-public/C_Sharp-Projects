using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class Admin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal BaseQuote {  get; set; }
        public decimal MinusEighteen { get; set; }
        public decimal OverTwentySix { get; set; }
        public decimal BetwNineteenAndTwentySix { get; set; }
        public decimal CarYearBeforeOver { get; set; }
        public decimal CarMakePorche { get; set; }
        public decimal CarModelCarrera { get; set; }
        public decimal DUIYes { get; set; }
        public decimal SpeedingTicketsQuantity { get; set; }
        public int SpeedingTicketsQuantityYes { get; set; }
        public decimal CoverageTypeYes { get; set; }
        public decimal TotalQuote { get; set; }
    }
}