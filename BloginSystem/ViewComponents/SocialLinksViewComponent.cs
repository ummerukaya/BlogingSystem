using BloginSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloginSystem.ViewComponents
{
    public class SocialLinksViewComponent : ViewComponent
    {
        List<SocialIcon> socialIcons = new List<SocialIcon>();
        public SocialLinksViewComponent()
        {
            socialIcons = SocialIcon.AppSocialIcons();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = socialIcons;
            return await Task.FromResult((IViewComponentResult)View("SocialLinks", model));
        }

    }
}
