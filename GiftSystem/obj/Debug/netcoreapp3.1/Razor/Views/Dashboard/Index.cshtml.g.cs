#pragma checksum "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4492497bb6719d4ae83b1605ebf3ed17d099c13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "D:\git\GiftSystem\GiftSystem\Views\_ViewImports.cshtml"
using GiftSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\git\GiftSystem\GiftSystem\Views\_ViewImports.cshtml"
using GiftSystem.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4492497bb6719d4ae83b1605ebf3ed17d099c13", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"235f1ba293ddf9ec8550fba3d691a9bca3b54287", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GiftSystem.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
  
    this.ViewData["Title"] = "UserDashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h4 style=""margin: 1%; text-align: center;"">Sent credits</h4>
    <div style=""padding: 5%;"">
        <table class=""table"">
            <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Credits</th>
                <th scope=""col"">Receiver</th>
                <th>Message</th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
             foreach (var sent in Model.Sent)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 21 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
                               Write(sent.Credits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 22 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
                   Write(sent.Receiver.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
                   Write(sent.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<hr/>
<div class=""container"">
    <h4 style=""margin: 1%; text-align: center;"">Received credits</h4>
    <div style=""padding: 5%;"">
        <table class=""table"">
            <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Credits</th>
                <th scope=""col"">Sender</th>
                <th>Message</th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 43 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
                 foreach (var received in Model.Received)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 46 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
                                   Write(received.Credits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 47 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
                       Write(received.Sender.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
                       Write(received.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 50 "D:\git\GiftSystem\GiftSystem\Views\Dashboard\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GiftSystem.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
