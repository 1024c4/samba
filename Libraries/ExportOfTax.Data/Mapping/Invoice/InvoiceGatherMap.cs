using JinS.ExportOfTax.Core;
using JinS.ExportOfTax.Core.Domain.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Data.Mapping.Invoice
{
    public class InvoiceGatherMap : EfEntityTypeConfiguration<InvoiceGather>
    {
        public InvoiceGatherMap()
        {
            this.ToTable("Invoice_Gather");
            this.HasKey(a => a.Id);
            //this.Ignore(x => x.Id);

            this.HasRequired(bc => bc.InvoiceDetail)
                .WithMany(bp => bp.InvoiceGathers)
                .HasForeignKey(bc => bc.DetailID);
        }

    }


}

