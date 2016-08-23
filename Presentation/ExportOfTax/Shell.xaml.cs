using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExportOfTax
{
    [Export]
    public partial class Shell : Window, IPartImportsSatisfiedNotification
    {
        private static Uri InboxViewUri = new Uri("/InboxView", UriKind.Relative);

        public Shell()
        {
            InitializeComponent();
        }

        [Import(AllowRecomposition = false)]
        public IModuleManager ModuleManager;

        [Import(AllowRecomposition = false)]
        public IRegionManager RegionManager;

        public void OnImportsSatisfied()
        {
            this.ModuleManager.LoadModuleCompleted +=
                (s, e) =>
                {
                    // todo: 01 - Navigation on when modules are loaded.
                    // When using region navigation, be sure to use it consistently
                    // to ensure you get proper journal behavior.  If we mixed
                    // usage of adding views directly to regions, such as through
                    // RegionManager.AddToRegion, and then use RegionManager.RequestNavigate,
                    // we may not be able to navigate back correctly.
                    // 
                    // Here, we wait until the module we want to start with is
                    // loaded and then navigate to the view we want to display
                    // initially.
                    //     
                    if (e.ModuleInfo.ModuleName == "InvoiceModule")
                    {
                        this.RegionManager.RequestNavigate(
                            "MainRegion",
                            InboxViewUri);
                    }
                };
        }
    }
}
