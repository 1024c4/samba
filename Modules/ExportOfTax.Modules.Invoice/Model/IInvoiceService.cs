using JinS.ExportOfTax.Core.Domain.Invoice;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Modules.Invoice.Model
{
    public interface IInvoiceService
    {
        Task<IEnumerable<InvoiceDetail>> GetInvoicesAsync();
    }
}