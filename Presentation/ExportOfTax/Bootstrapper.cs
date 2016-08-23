using JinS.ExportOfTax.Data;
using JinS.ExportOfTax.Infrastructure.Behaviors;
using Prism.Mef;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExportOfTax
{
    public class Bootstrapper : MefBootstrapper
    {
        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }


        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            // Add this assembly to export ModuleTracker
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(EfObjectContext).Assembly));
            //this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AutoPopulateExportedViewsBehavior).Assembly));

            // Module A is referenced in in the project and directly in code.
            //this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(JinS.ExportOfTax.Modules.Invoice.Module).Assembly));
            //this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleC).Assembly));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        //protected override Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        //{
        //    var factory = base.ConfigureDefaultRegionBehaviors();

        //    factory.AddIfMissing("AutoPopulateExportedViewsBehavior", typeof(AutoPopulateExportedViewsBehavior));

        //    return factory;
        //}




    }
}
