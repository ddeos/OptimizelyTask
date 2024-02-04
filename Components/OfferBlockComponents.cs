using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptimizelyTask.Models;

namespace OptimizelyTask.Controllers
{
    [TemplateDescriptor]
    public class OfferBlockViewComponent : BlockComponent<OfferBlock>
    {
        protected override IViewComponentResult InvokeComponent(OfferBlock currentContent)
        {
            return View("/Views/Shared/Components/OfferBlock/Default.cshtml", currentContent);
        }
    } 

    [TemplateDescriptor(Tags = new string[] { "Main" })]
    public class MainOfferBlockViewComponent : BlockComponent<OfferBlock>
    {
        protected override IViewComponentResult InvokeComponent(OfferBlock currentContent)
        {
            return View("/Views/Shared/Components/OfferBlock/MainOffer.cshtml", currentContent);
        }
    } 

    [TemplateDescriptor(Tags = new string[] { "Compact" })]
    public class CompactOfferBlockViewComponent : BlockComponent<OfferBlock>
    {
        protected override IViewComponentResult InvokeComponent(OfferBlock currentContent)
        {
            return View("/Views/Shared/Components/OfferBlock/Compact.cshtml", currentContent);
        }
    } 
}
