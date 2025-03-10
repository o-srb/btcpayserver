using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BTCPayServer.Client.Models;

namespace BTCPayServer.Models.StoreViewModels
{
    public class PaymentMethodsViewModel
    {
        public string Id { get; set; }
        public List<StoreDerivationScheme> DerivationSchemes { get; set; }
        public List<StoreLightningNode> LightningNodes { get; set; }
        public bool HintWallet { get; set; }
        public bool HintLightning { get; set; }
        
        [Display(Name = "Allow anyone to create invoice")]
        public bool AnyoneCanCreateInvoice { get; set; }

        [Display(Name = "Invoice expires if the full amount has not been paid after …")]
        [Range(1, 60 * 24 * 24)]
        public int InvoiceExpiration { get; set; }

        [Display(Name = "Add additional fee (network fee) to invoice …")]
        public NetworkFeeMode NetworkFeeMode { get; set; }

        [Display(Name = "Consider the invoice paid even if the paid amount is ... % less than expected")]
        [Range(0, 100)]
        public double PaymentTolerance { get; set; }
        
        [Display(Name = "Default currency")]
        [MaxLength(10)]
        public string DefaultCurrency { get; set; }
    }
}
