#pragma checksum "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d5dea5b46da1ef8ebcd9ab506fb6e026b2bf56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MagazineAppCore.Pages.Pages_Clients), @"mvc.1.0.razor-page", @"/Pages/Clients.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Clients.cshtml", typeof(MagazineAppCore.Pages.Pages_Clients), null)]
namespace MagazineAppCore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\_ViewImports.cshtml"
using MagazineAppCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d5dea5b46da1ef8ebcd9ab506fb6e026b2bf56", @"/Pages/Clients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94e7e2ceab971225bf172ceecd721e92a19dbd3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Clients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
  
    ViewData["Title"] = "Clients";

#line default
#line hidden
            BeginContext(93, 39, true);
            WriteLiteral("\r\n<h1>Clients</h1>\r\n<P>Showing Results ");
            EndContext();
            BeginContext(134, 21, false);
#line 8 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
               Write(Model.PageIndex*50-49);

#line default
#line hidden
            EndContext();
            BeginContext(156, 4, true);
            WriteLiteral(" to ");
            EndContext();
            BeginContext(162, 43, false);
#line 8 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
                                           Write(Model.PageIndex*50-49+Model.PageResultCount);

#line default
#line hidden
            EndContext();
            BeginContext(206, 7, true);
            WriteLiteral(" from  ");
            EndContext();
            BeginContext(214, 11, false);
#line 8 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
                                                                                               Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(225, 354, true);
            WriteLiteral(@" Results</P>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ID
            </th>
            <th>
                Name
            </th>
            <th>
                Status
            </th>
            <th>
                Last Edited Date
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
         foreach (var item in Model.Clients)
        {

#line default
#line hidden
            BeginContext(636, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(697, 41, false);
#line 31 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
               Write(Html.DisplayFor(modelItem => item.id_cln));

#line default
#line hidden
            EndContext();
            BeginContext(738, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(806, 43, false);
#line 34 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
               Write(Html.DisplayFor(modelItem => item.name_cln));

#line default
#line hidden
            EndContext();
            BeginContext(849, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(917, 45, false);
#line 37 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
               Write(Html.DisplayFor(modelItem => item.StatusName));

#line default
#line hidden
            EndContext();
            BeginContext(962, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1030, 47, false);
#line 40 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
               Write(Html.DisplayFor(modelItem => item.lastedit_cln));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 43 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
        }

#line default
#line hidden
            BeginContext(1132, 26, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
            EndContext();
#line 47 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
  
    var prevDisabled = !Model.PreviousPage ? "disabled" : "";
    var nextDisabled = !Model.NextPage ? "disabled" : "";

#line default
#line hidden
            BeginContext(1287, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1291, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d5dea5b46da1ef8ebcd9ab506fb6e026b2bf567608", async() => {
                BeginContext(1404, 8, true);
                WriteLiteral("Previous");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
             WriteLiteral(Model.PageIndex-1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1373, "btn", 1373, 3, true);
            AddHtmlAttributeValue(" ", 1376, "btn-default", 1377, 12, true);
#line 55 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
AddHtmlAttributeValue(" ", 1388, prevDisabled, 1389, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1416, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1420, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d5dea5b46da1ef8ebcd9ab506fb6e026b2bf5610502", async() => {
                BeginContext(1523, 4, true);
                WriteLiteral("Next");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
             WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1504, "btn", 1504, 3, true);
#line 59 "E:\VisualStudio\MagazineAppCore\MagazineAppCore\Pages\Clients.cshtml"
AddHtmlAttributeValue(" ", 1507, nextDisabled, 1508, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MagazineAppCore.Pages.ClientsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MagazineAppCore.Pages.ClientsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MagazineAppCore.Pages.ClientsModel>)PageContext?.ViewData;
        public MagazineAppCore.Pages.ClientsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591