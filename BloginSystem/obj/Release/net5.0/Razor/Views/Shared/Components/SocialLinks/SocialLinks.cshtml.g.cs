#pragma checksum "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\Shared\Components\SocialLinks\SocialLinks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "800359f216b96db503da40ced37eb52730b5b441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialLinks_SocialLinks), @"mvc.1.0.view", @"/Views/Shared/Components/SocialLinks/SocialLinks.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\_ViewImports.cshtml"
using BloginSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\_ViewImports.cshtml"
using BloginSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800359f216b96db503da40ced37eb52730b5b441", @"/Views/Shared/Components/SocialLinks/SocialLinks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1247db7dc93be36587767be3ec07f272862f24e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SocialLinks_SocialLinks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<BloginSystem.Models.SocialIcon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-12\" style=\"padding-top:50px;\">\r\n");
#nullable restore
#line 4 "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
     foreach (var icon in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("style", " style=\"", 150, "\"", 186, 2);
            WriteAttributeValue("", 158, "background:", 158, 11, true);
#nullable restore
#line 6 "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
WriteAttributeValue("", 169, icon.IconBgColor, 169, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 187, "\"", 213, 1);
#nullable restore
#line 6 "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
WriteAttributeValue("", 194, icon.IconTargetUrl, 194, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i");
            BeginWriteAttribute("class", " class=\"", 231, "\"", 254, 1);
#nullable restore
#line 7 "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
WriteAttributeValue("", 239, icon.IconClass, 239, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            ");
#nullable restore
#line 8 "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
       Write(icon.IconName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n");
#nullable restore
#line 10 "C:\Users\BS687\source\repos\BlogingSystem\BloginSystem\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<BloginSystem.Models.SocialIcon>> Html { get; private set; }
    }
}
#pragma warning restore 1591