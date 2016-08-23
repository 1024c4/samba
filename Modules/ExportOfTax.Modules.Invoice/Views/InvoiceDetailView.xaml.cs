using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace JinS.ExportOfTax.Modules.Invoice.Views
{
    [Export("InvoiceDetailView")]
    public partial class InvoiceDetailView : UserControl
    {
        public InvoiceDetailView()
        {
            InitializeComponent();
        }
    }
}
