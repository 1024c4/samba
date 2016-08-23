using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinS.ExportOfTax.Core.Domain.Invoice
{
    public enum SourceType
    {
        /// <summary>
        /// 关务数据
        /// </summary>
        CustomData = 1,
        /// <summary>
        /// 出口退税
        /// </summary>
        ChinaPortTaxRefund = 2,
        /// <summary>
        /// 出口收汇
        /// </summary>
        ChinaPortExportExchange = 3,
        /// <summary>
        /// 进口付汇
        /// </summary>
        ChinaPortImportExchange = 4,
        /// <summary>
        /// 报关申报
        /// </summary>
        ChinaPortCustomsCeclaration = 5,
        /// <summary>
        /// 手工添加
        /// </summary>
        Manual = 6,
        /// <summary>
        /// 外部导入
        /// </summary>
        Import = 7,
        /// <summary>
        /// IEDS数据
        /// </summary>
        Ieds = 8,
        /// <summary>
        /// U8数据
        /// </summary>
        U8 = 9,
        /// <summary>
        /// 出口退税（多张报关单合并开票）
        /// </summary>
        ChinaPortTaxRefundWithMerge = 10,
        /// <summary>
        /// 艾默生导入
        /// </summary>
        ImportEmerson = 11,
        /// <summary>
        /// 中间表
        /// </summary>
        DataMiddle = 12,
        /// <summary>
        /// 中间表拆分
        /// </summary>
        DataMiddleSplit = 1312,
        /// <summary>
        /// 拆分
        /// </summary>
        Split = 13,
        /// <summary>
        /// 重开
        /// </summary>
        Duplicate = 14,
        /// <summary>
        /// CDMS数据
        /// </summary>
        Cdms = 15,
        /// <summary>
        /// 乐健数据
        /// </summary>
        Rayben = 10001,


    }
}
