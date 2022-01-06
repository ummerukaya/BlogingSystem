using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloginSystem.Models
{
    public class SocialIcon:BaseModel
    {
        
        public string IconName { get; set; }
        public string IconBgColor { get; set; }
        public string IconTargetUrl { get; set; }
        public string IconClass { get; set; }

        public static List<SocialIcon> AppSocialIcons()
        {
            List<SocialIcon> icons = new List<SocialIcon>();
            icons.Add(new SocialIcon { IconName = "Google", IconBgColor = "#dd4b39", IconTargetUrl = "www.google.com", IconClass = "fa fa-google" });
            icons.Add(new SocialIcon { IconName = "Facebook", IconBgColor = "#3B5998", IconTargetUrl = "www.facebook.com", IconClass = "fa fa-facebook" });
            icons.Add(new SocialIcon { IconName = "Linked In", IconBgColor = "#007bb5", IconTargetUrl = "www.linkedin.com", IconClass = "fa fa-fa-linkedin" });
            icons.Add(new SocialIcon { IconName = "Twitter", IconBgColor = "#55acee", IconTargetUrl = "www.twitter.com", IconClass = "fa fa-twitter" });

            return icons;
        }
    }
}
