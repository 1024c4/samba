using JinS.ExportOfTax.Infrastructure;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.ComponentModel.Composition;

namespace JinS.ExportOfTax.Modules.Invoice
{
    [ModuleExport(typeof(InvoiceModule))]
    public class InvoiceModule : IModule
    {
        [Import]
        public IRegionManager RegionManager;

        //public Module(RegionManager regionManager)
        //{
        //    _regionManager = regionManager;
        //}

        public void Initialize()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.MainContentRegion, typeof(Views.InvoiceView));
        }
    }
}