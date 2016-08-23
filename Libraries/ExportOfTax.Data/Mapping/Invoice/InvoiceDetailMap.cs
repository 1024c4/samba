using JinS.ExportOfTax.Core;
using JinS.ExportOfTax.Core.Domain.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Data.Mapping.Invoice
{
    public class InvoiceDetailMap : EfEntityTypeConfiguration<InvoiceDetail>
    {
        public InvoiceDetailMap()
        {
            this.ToTable("Invoice_Detail");
            this.HasKey(a => a.Id);
            //this.Ignore(x => x.Id);

            //this.HasMany(x => x.InvoiceGathers)
            //    .WithRequired(x => x.InvoiceDetail)
            //    .HasForeignKey(x => x.DetailID);
        }
    }



}

