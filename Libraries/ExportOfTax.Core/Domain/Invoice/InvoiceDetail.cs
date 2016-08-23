using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JinS.ExportOfTax.Core.Domain.Invoice
{
    public partial class InvoiceDetail : BaseEntity
    {
        //public Guid ID { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomCode { get; set; }
        public string SelfCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string CustomNo { get; set; }
        public string Purchase { get; set; }
        public string PurchaseName { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string ContractNo { get; set; }
        public string LCNo { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
        public string TradeWay { get; set; }
        public string ExportReceiveWay { get; set; }
        public string TransportWay { get; set; }
        public string TransportTools { get; set; }
        public string StartPort { get; set; }
        public string TransitPort { get; set; }
        public string EndPort { get; set; }
        public string CUR { get; set; }
        public int? InvoiceType { get; set; }
        public int? IsOpen { get; set; }
        public string REM { get; set; }
        public string Clerk { get; set; }
        public int? IsPrint { get; set; }
        public int? IsVerification { get; set; }
        public DateTime CreateTime { get; set; }
        public SourceType SourceType { get; set; }
        public decimal? Amt { get; set; }
        public decimal? RmbHl { get; set; }
        public decimal? RmbAmt { get; set; }
        public decimal? Ybf { get; set; }
        public string Kpy { get; set; }
        public string Site { get; set; }
        public int? GoodsListFlag { get; set; }
        public string Skr { get; set; }
        public string Fhr { get; set; }
        public string ClientAddress { get; set; }
        public string SellerBank { get; set; }
        public string SellerAddress { get; set; }
        public string TradeMethod { get; set; }
        public string ForeignExchange { get; set; }
        public string Transportation { get; set; }
        public string PortDeparture { get; set; }
        public string PortTrans { get; set; }
        public string PortDestination { get; set; }
        public string Currency { get; set; }
        public string Define1 { get; set; }
        public string Define2 { get; set; }
        public string Define3 { get; set; }
        public string Define4 { get; set; }
        public string Define5 { get; set; }
        public string ClientBank { get; set; }
        public int? CancelInvFlag { get; set; }
        public int? CustomRemarkFlag { get; set; }
        public string REM2 { get; set; }
        public string ClientTaxID { get; set; }
        public int? WriteBackFlag { get; set; }
        public string Define6 { get; set; }
        public string Define7 { get; set; }
        public string Define8 { get; set; }
        public string Define9 { get; set; }
        public string Define10 { get; set; }
        public decimal? AmtFob { get; set; }
        public decimal? AmtInitial { get; set; }
        public string TradeTerms { get; set; }
        public decimal? TaxRate { get; set; }
    }
}
