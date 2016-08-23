using JinS.ExportOfTax.Core.Domain.Invoice;
using JinS.ExportOfTax.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JinS.ExportOfTax.Services.Invoice
{
    public class InvoiceService : IInvoiceService
    {
        private IDbContext ctx;

        public InvoiceService(IDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IList<InvoiceGather> GetAllInvoiceGathers(Guid DetailId)
        {
            var rep = new EfRepository<InvoiceGather>(this.ctx);

            var query = from t1 in rep.Table
                        where t1.DetailID == DetailId
                        orderby t1.SeqNo
                        select t1;

            var list = query.ToList();

            return list;
        }

        /// <summary>
        /// 查询所有待开发票
        /// </summary>
        /// <returns></returns>
        public IList<InvoiceDetail> GetAllUnIssuesedInvoices()
        {
            var rep = new EfRepository<InvoiceDetail>(this.ctx);

            var query = from t1 in rep.Table
                        where t1.IsOpen == 0
                        select t1;

            var list = query.ToList();

            return list;
        }

        public InvoiceDetail GetInvoice(Guid Id)
        {
            var rep = new EfRepository<InvoiceDetail>(this.ctx);

            return rep.GetById(Id);
        }
    }
}
