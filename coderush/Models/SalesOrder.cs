using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class SalesOrder
    {
        [Display(Name = "Id")]
        public int SalesOrderId { get; set; }
        [Display(Name = "Numero de Orden")]
        public string SalesOrderName { get; set; }
        [Display(Name = "Rama")]
        public int BranchId { get; set; }
        [Display(Name = "Cliente")]
        public int CustomerId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }

        [Display(Name = "Moneda")]
        public int CurrencyId { get; set; }

        [Display(Name = "Numero Referencia")]
        public string CustomerRefNumber { get; set; }
        [Display(Name = "Tipo de Venta")]
        public int SalesTypeId { get; set; }
        public string Remarks { get; set; }
        public double Amount { get; set; }
        public double SubTotal { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double Freight { get; set; }
        public double Total { get; set; }
        public List<SalesOrderLine> SalesOrderLines { get; set; } = new List<SalesOrderLine>();
    }
}
