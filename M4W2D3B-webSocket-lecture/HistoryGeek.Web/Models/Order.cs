using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required]
        public string NameOnCard { get; set; }

        [Required]
        [DataType(DataType.CreditCard)]
        public string CreditCardNumber { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public string BillingAddress1 { get; set; }

        public string BillingAddress2 { get; set; }

        [Required]
        public string BillingCity { get; set; }

        [Required]
        public string BillingState { get; set; }

        [Required]
        public string BillingPostalCode { get; set; }

        [Required]
        public string ShippingAddress1 { get; set; }
        
        public string ShippingAddress2 { get; set; }

        [Required]
        public string ShippingCity { get; set; }

        [Required]
        public string ShippingState { get; set; }

        [Required]
        public string ShippingPostalCode { get; set; }

        [Required]
        public string ShippingType { get; set; }

        public double SubTotal { get; set; }
        public double Weight { get; set; }
        public double? Shipping { get; set; }
        public double? Tax { get; set; }

        public Dictionary<string, double> ShippingRates { get; set; }
        
    }
}