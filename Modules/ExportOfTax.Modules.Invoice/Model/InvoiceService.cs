using JinS.ExportOfTax.Core.Domain.Invoice;
using JinS.ExportOfTax.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Modules.Invoice.Model
{
    [Export(typeof(IInvoiceService))]
    public class InvoiceService : IInvoiceService
    {
        private IDbContext ctx;

        
        public InvoiceService()
        {

        }

        [ImportingConstructor]
        public InvoiceService(IDbContext ctx)
        {
            this.ctx = ctx;
        }

        public Task<IEnumerable<InvoiceDetail>> GetInvoicesAsync()
        {

            var rep = new EfRepository<InvoiceDetail>(this.ctx);

            var query = from t1 in rep.Table
                        select t1;

            return Task.FromResult(new ReadOnlyCollection<InvoiceDetail>(query.ToList()) as IEnumerable<InvoiceDetail>);
        }
    }
}
