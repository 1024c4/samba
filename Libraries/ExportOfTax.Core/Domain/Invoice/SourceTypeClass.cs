using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Core.Domain.Invoice
{
    public class SourceTypeClass
    {
        public static Dictionary<SourceType, String> StringDict { get; private set; }

        static SourceTypeClass()
        {
            StringDict = new Dictionary<SourceType, String>() {
               {SourceType.CustomData, "关务数据"},
               {SourceType.ChinaPortTaxRefund, "出口退税"},
               {SourceType.ChinaPortExportExchange, "出口收汇"},
               {SourceType.ChinaPortImportExchange, "进口付汇"},
               {SourceType.ChinaPortCustomsCeclaration, "报关申报"},
               {SourceType.Manual, "手工添加"},
               {SourceType.Import, "外部导入"},
               {SourceType.Ieds, "IEDS数据"},
            };
        }
    }
}
