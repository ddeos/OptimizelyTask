using System.ComponentModel.DataAnnotations;

namespace OptimizelyTask.Models
{
    [ContentType(DisplayName = "Offer block", GUID = "56B0AA11-B0AA-40D0-AD4E-610A2DF2E7E3")]
    public class OfferBlock : BlockData
    {
        [Required]
        [CultureSpecific]
        [Display(Name = "Title", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string Title { get; set; }

        [Required]
        [Display(Name = "Price", GroupName = SystemTabNames.Content, Order = 3)]
        public virtual int Price { get; set; }

        [CultureSpecific]
        [Display(Name = "Benefits", Description = "Offer benefits", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual IList<string> Benefits { get; set; }
        
        [CultureSpecific]
        [Display(Name = "Price description", GroupName = SystemTabNames.Content, Order = 3)]
        public virtual XhtmlString PriceDescription { get; set; }

        [Display(Name = "Id", GroupName = SystemTabNames.Content, Order = 4)]
        public virtual string HtmlId {get; set;}

        public override void SetDefaultValues(ContentType contentType)
        {
                base.SetDefaultValues(contentType);
                HtmlId = $"_{Guid.NewGuid().ToString("N")}";
        }
    }
}