using JinS.ExportOfTax.Core.Domain.Invoice;
using JinS.ExportOfTax.Infrastructure;
using JinS.ExportOfTax.Modules.Invoice.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JinS.ExportOfTax.Modules.Invoice.ViewModels
{
    [Export]
    public class InvoiceViewModel : BindableBase
    {
        private IInvoiceService invoiceService;
        private ObservableCollection<InvoiceDetail> invoices;
        private DelegateCommand<InvoiceDetail> openInvoiceCommand;
        private IRegionManager regionManager;

        private static Uri emailsViewUri = new Uri("InvoiceDetailView", UriKind.Relative);

        [ImportingConstructor]
        public InvoiceViewModel(IInvoiceService invoiceService, IRegionManager regionManager)
        {
            this.openInvoiceCommand = new DelegateCommand<InvoiceDetail>(this.OpenInvoice);

            this.invoiceService = invoiceService;
            this.regionManager = regionManager;
            var task = this.LoadInvoices();
        }

        private async Task LoadInvoices()
        {
            this.invoices = new ObservableCollection<InvoiceDetail>(await this.invoiceService.GetInvoicesAsync());
        }

        private void OpenInvoice(InvoiceDetail inv)
        {
            this.regionManager.RequestNavigate(RegionNames.MainContentRegion, emailsViewUri);

        }

        public ICommand OpenInvoiceCommand
        {
            get { return this.openInvoiceCommand; }
        }

        public ObservableCollection<InvoiceDetail> Invoices
        {
            get { return invoices; }
            set { SetProperty(ref invoices, value); }
        }
    }
}
