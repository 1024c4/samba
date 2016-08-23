using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Core.Domain.Invoice
{
    public partial class InvoiceGather : BaseEntity
    {
        public virtual InvoiceDetail InvoiceDetail { get; set; }
    }
}
