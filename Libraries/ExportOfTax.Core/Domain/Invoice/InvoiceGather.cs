using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Core.Domain.Invoice
{
    public partial class InvoiceGather : BaseEntity
    {
        //public Guid ID { get; set; }
        public Guid DetailID { get; set; }
        public string OrderNo { get; set; }
        public string CustomNo { get; set; }
        public string GoodsCode { get; set; }
        public string GoodsName { get; set; }
        public string GoodsSpc { get; set; }
        public string Unit { get; set; }
        public string UnitName { get; set; }
        public decimal QTY { get; set; }
        public decimal Price { get; set; }
        public decimal Amt { get; set; }
        public DateTime CreateTime { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNo { get; set; }
        public int SeqNo { get; set; }
        public decimal RmbAmt { get; set; }
        public decimal RmbPrice { get; set; }
        public decimal? AmtFob { get; set; }
        public decimal? AmtInitial { get; set; }
        public string Define1 { get; set; }
        public string Define2 { get; set; }
        public string Define3 { get; set; }
        public string Define4 { get; set; }
        public string Define5 { get; set; }
        public string Define6 { get; set; }
        public string Define7 { get; set; }
        public string Define8 { get; set; }
        public string Define9 { get; set; }
        public string Define10 { get; set; }
        public decimal? TaxRate { get; set; }
        public string GoodsTaxCode { get; set; }
        public int TaxPre { get; set; }
        public string TaxPreCon { get; set; }
        public string ZeroTax { get; set; }
        public decimal TaxDeduction { get; set; }
    }
}
