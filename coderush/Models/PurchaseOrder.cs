﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coderush.Models
{
    public class PurchaseOrder
    {
        [Display(Name = "Id")]
        public int PurchaseOrderId { get; set; }
        [Display(Name = "Numero")]
        public string PurchaseOrderName { get; set; }
        [Display(Name = "Rama")]
        public int BranchId { get; set; }
        [Display(Name = "Proveedor")]
        public int VendorId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }

        [Display(Name = "Moneda")]
        public int CurrencyId { get; set; }
        
        [Display(Name = "Tipo de Compra")]
        public int PurchaseTypeId { get; set; }
        public string Remarks { get; set; }
        public double Amount { get; set; }
        public double SubTotal { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double Freight { get; set; }
        public double Total { get; set; }
        public List<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();
        

    }
}
