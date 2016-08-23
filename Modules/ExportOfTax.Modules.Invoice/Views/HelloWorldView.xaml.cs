using JinS.ExportOfTax.Infrastructure.Behaviors;
using System.ComponentModel.Composition;
using System.Windows.Controls;
using System;
using Prism.Regions;
using JinS.ExportOfTax.Infrastructure;

namespace JinS.ExportOfTax.Modules.Invoice.Views
{
    //[ViewExport(RegionName = RegionNames.MainContentRegion)]
    [Export]
    public partial class HelloWorldView : UserControl//, IPartImportsSatisfiedNotification
    {
        //private static Uri calendarViewUri = new Uri("HelloWorldView", UriKind.Relative);

        [Import]
        public IRegionManager regionManager;


        public HelloWorldView()
        {
            InitializeComponent();
        }

        //void IPartImportsSatisfiedNotification.OnImportsSatisfied()
        //{
        //    IRegion mainContentRegion = this.regionManager.Regions[RegionNames.MainContentRegion];
        //    if (mainContentRegion != null && mainContentRegion.NavigationService != null)
        //    {
        //        mainContentRegion.NavigationService.Navigated += this.MainContentRegion_Navigated;
        //    }
        //}

        //public void MainContentRegion_Navigated(object sender, RegionNavigationEventArgs e)
        //{
        //    this.UpdateNavigationButtonState(e.Uri);
        //}

        //private void UpdateNavigationButtonState(Uri uri)
        //{
        //    //this.NavigateToCalendarRadioButton.IsChecked = (uri == calendarViewUri);
        //}
    }
}
