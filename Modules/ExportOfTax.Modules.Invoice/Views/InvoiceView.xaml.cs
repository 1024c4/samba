using JinS.ExportOfTax.Modules.Invoice.ViewModels;
using Prism.Regions;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace JinS.ExportOfTax.Modules.Invoice.Views
{
    [Export]
    public partial class InvoiceView : UserControl
    {
        public InvoiceView()
        {
            InitializeComponent();
        }

        [Import]
        public InvoiceViewModel ViewModel
        {
            set { this.DataContext = value; }
        }
    }
}
