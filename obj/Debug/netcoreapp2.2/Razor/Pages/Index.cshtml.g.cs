#pragma checksum "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "792a52b55b3ab098fa9004f091080e72860b1cd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SessionSample.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SessionSample.Pages.Pages_Index), null)]
namespace SessionSample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Works_Blazor_Razor\SessionSample\Pages\_ViewImports.cshtml"
using SessionSample;

#line default
#line hidden
#line 2 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792a52b55b3ab098fa9004f091080e72860b1cd0", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"556089aa70f387fe9a40f5e01a8be9f1cad1948f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "ChangeAge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-right btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "UpdateSessionDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
  
    ViewData["Title"] = "Session Sample";

#line default
#line hidden
            BeginContext(104, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(110, 17, false);
#line 8 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 87, true);
            WriteLiteral("</h1>\n\n<h2>State management</h2>\n\n<div class=\"row\">\n    <div class=\"col-md-8\">\n        ");
            EndContext();
            BeginContext(214, 1489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "792a52b55b3ab098fa9004f091080e72860b1cd05657", async() => {
                BeginContext(234, 111, true);
                WriteLiteral("\n            <div class=\"panel panel-default\">\n                <div class=\"panel-heading\">\n                    ");
                EndContext();
                BeginContext(345, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "792a52b55b3ab098fa9004f091080e72860b1cd06155", async() => {
                    BeginContext(430, 10, true);
                    WriteLiteral("Change Age");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(449, 430, true);
                WriteLiteral(@"
                    <h3 class=""panel-title"" style=""line-height:2.1"">Name and Age</h3>
                </div>
                <div class=""panel-body"">
                    <p>The name and age are stored in session. Select the <span style=""font-weight:bold"">Change Age</span> button to update the session to a new random age value.</p>
                    <p>Session values can be passed to the view or page by the model with <code>");
                EndContext();
                BeginContext(880, 76, true);
                WriteLiteral("@Model.&lt;PropertyName&gt;</code>:</p>\n                    <p><b>Name:</b> ");
                EndContext();
                BeginContext(957, 22, false);
#line 23 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
                               Write(Model.SessionInfo_Name);

#line default
#line hidden
                EndContext();
                BeginContext(979, 13, true);
                WriteLiteral(" <b>Age:</b> ");
                EndContext();
                BeginContext(993, 21, false);
#line 23 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
                                                                   Write(Model.SessionInfo_Age);

#line default
#line hidden
                EndContext();
                BeginContext(1014, 97, true);
                WriteLiteral("</p>\n                    <hr>\n                    <p>Session can be accessed directly with <code>");
                EndContext();
                BeginContext(1112, 80, true);
                WriteLiteral("@HttpContext.Session.GetString(&lt;key&gt;)</code>. The view or page sets <code>");
                EndContext();
                BeginContext(1193, 312, true);
                WriteLiteral(@"@using Microsoft.AspNetCore.Http</code> to gain access to the <code>GetString</code> and <code>GetInt32</code> extension methods, which are provided by the <code>Microsoft.AspNetCore.Http.Extensions</code> package. The following values are rendered directly from session:</p>
                    <p><b>Name:</b> ");
                EndContext();
                BeginContext(1506, 56, false);
#line 26 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
                               Write(HttpContext.Session.GetString(IndexModel.SessionKeyName));

#line default
#line hidden
                EndContext();
                BeginContext(1562, 13, true);
                WriteLiteral(" <b>Age:</b> ");
                EndContext();
                BeginContext(1576, 65, false);
#line 26 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
                                                                                                     Write(HttpContext.Session.GetInt32(IndexModel.SessionKeyAge).ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1641, 55, true);
                WriteLiteral("</p>\n                </div>\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1703, 550, true);
            WriteLiteral(@"
    </div>
</div>

<div class=""row"">
    <div class=""col-md-8"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">HttpContext.Items Middleware Value</h3>
            </div>
            <div class=""panel-body"">
                <p>The middleware value is set into the <code>HttpContext.Items</code> collection by the <code>HttpContextItemsMiddleware</code> before Razor Pages processes the request. The value is retreived by the page and displayed.</p>
                <p>Value: ");
            EndContext();
            BeginContext(2254, 33, false);
#line 41 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
                     Write(Model.SessionInfo_MiddlewareValue);

#line default
#line hidden
            EndContext();
            BeginContext(2287, 111, true);
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-8\">\n        ");
            EndContext();
            BeginContext(2398, 1052, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "792a52b55b3ab098fa9004f091080e72860b1cd013124", async() => {
                BeginContext(2418, 120, true);
                WriteLiteral("\n            <div class=\"panel panel-default\">\n                <div class=\"panel-heading clearfix\">\n                    ");
                EndContext();
                BeginContext(2538, 121, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "792a52b55b3ab098fa9004f091080e72860b1cd013634", async() => {
                    BeginContext(2631, 19, true);
                    WriteLiteral("Update Session Time");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2659, 627, true);
                WriteLiteral(@"
                    <a href=""/"" class=""pull-right btn btn-danger"" style=""margin-right:5px"">Reload Page (No Update)</a>
                    <h3 class=""panel-title"" style=""line-height:2.1"">Session Time</h3>
                </div>
                <div class=""panel-body"">
                    <p>The session time is stored in session. Select the <span style=""font-weight:bold"">Reload Page (No Update)</span> button to display the current time and the time stored in session. Select the <span style=""font-weight:bold"">Update Session Time</span> button to store the current time in session.</p>
                    <p>Current Time: ");
                EndContext();
                BeginContext(3287, 29, false);
#line 58 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
                                Write(Model.SessionInfo_CurrentTime);

#line default
#line hidden
                EndContext();
                BeginContext(3316, 42, true);
                WriteLiteral("</p>\n                    <p>Session Time: ");
                EndContext();
                BeginContext(3359, 29, false);
#line 59 "C:\Works_Blazor_Razor\SessionSample\Pages\Index.cshtml"
                                Write(Model.SessionInfo_SessionTime);

#line default
#line hidden
                EndContext();
                BeginContext(3388, 55, true);
                WriteLiteral("</p>\n                </div>\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3450, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
