using JinS.ExportOfTax.Core.Domain.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Services.Invoice
{
    public interface IInvoiceService
    {
        IList<InvoiceDetail> GetAllUnIssuesedInvoices();
        InvoiceDetail GetInvoice(Guid Id);
        IList<InvoiceGather> GetAllInvoiceGathers(Guid DetailId);
    }
}
