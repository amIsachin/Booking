#pragma checksum "E:\Sachin\Application\Booking\Booking.Web\Views\Booking\BookingCityTaxi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721b51b97c99d1b3643722cd432bd4444184a411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_BookingCityTaxi), @"mvc.1.0.view", @"/Views/Booking/BookingCityTaxi.cshtml")]
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
#line 1 "E:\Sachin\Application\Booking\Booking.Web\Views\_ViewImports.cshtml"
using Booking.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Sachin\Application\Booking\Booking.Web\Views\_ViewImports.cshtml"
using Booking.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721b51b97c99d1b3643722cd432bd4444184a411", @"/Views/Booking/BookingCityTaxi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01cb18bee719743b7f86a7968dac3db85682c658", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Booking_BookingCityTaxi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Sachin\Application\Booking\Booking.Web\Views\Booking\BookingCityTaxi.cshtml"
  
    ViewData["Title"] = "BookingCityTaxi";
    Layout = "~/Views/Shared/_Booking.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--  ----------------------- carousel -------------------------/
----  ------------------------------------------------------------------------------>
<div class=""container mb-5"">
    <div id=""carouselExampleIndicators"" class=""carousel slide carousel-fade"" data-bs-ride=""true"">
        <div class=""carousel-indicators"">
            <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
            <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
            <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
        </div>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img src=""https://www.cityam.com/wp-content/uploads/2019/10/London-Skyline-1-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1058, "\"", 1064, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"d-blick w-100\" style=\"width: 100%; height: 90vh;\">\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img src=\"https://m.atcdn.co.uk/ect/media/e05caa49b4784a9bb576aaf8ed893149.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1281, "\"", 1287, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"d-blick w-100\" style=\"width: 100%; height: 90vh;\">\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img src=\"https://www.rmagroup.net/wp-content/uploads/2018/04/New-Driver-02-1030x688.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1514, "\"", 1520, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""d-blick w-100"" style=""width: 100%; height: 90vh;"">
            </div>
        </div>
        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
        </button>
        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </button>
    </div>
</div>

<!--  ----------------------- booking form section -------------------------/
----  ------------------------------------------------------------------------------>
<div class=""container"">
    <figure class=""text-center"">
        <blockquote class=""blockquote"">
            <p> <b> Request a ride now. </b></p>
        </blockquote>");
            WriteLiteral("\n        <figcaption class=\"blockquote-footer\">\r\n            with  <cite title=\"Source Title\">Mr. Rider</cite>\r\n        </figcaption>\r\n    </figure>\r\n</div>\r\n\r\n<div class=\"container mb-3\">\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "721b51b97c99d1b3643722cd432bd4444184a4117141", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 2844, "\"", 2850, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-label\">Enter pickup location</label>\r\n                <input type=\"text\" class=\"form-control form-control-sm\">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 3056, "\"", 3062, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-label\">Enter destination</label>\r\n                <input type=\"text\" class=\"form-control form-control-sm\">\r\n            </div>\r\n\r\n            <button class=\"btn btn-sm btn-primary mt-3\">Request now</button>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
