using System.ComponentModel.DataAnnotations;

namespace OptimizelyTask.Models
{
    [ContentType(DisplayName = "Start page",  GUID = "134E7266-FB8C-4DEA-B033-3B4E6AE6CBCF", Description = "The start page.")]
    [ImageUrl("~/styles/images/page_type.png")]
    public class StartPage : PageData
    {
        [CultureSpecific]
        [Display(Name = "Title", Description = "Title for the page", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string Title { get; set; }
        
        [Display(Name = "Main offer", GroupName = SystemTabNames.Content, Order = 2)]
        [AllowedTypes(typeof(OfferBlock))]
        public virtual ContentArea MainOffer { get; set; }
        
        [Display(Name = "Additional offers", GroupName = SystemTabNames.Content, Order = 3)]
        [AllowedTypes(typeof(OfferBlock))]    
        public virtual ContentArea OptionalOffers { get; set; }

        [CultureSpecific]
        [Display(Name = "Calculator header", GroupName = SystemTabNames.Content, Order = 4)]
        public virtual string CalculatorHeader { get; set; }

        [Display(Name = "Calculation limit", GroupName = SystemTabNames.Content, Order = 5)]
        public virtual string CalculationLimit { get; set; }
    }
}