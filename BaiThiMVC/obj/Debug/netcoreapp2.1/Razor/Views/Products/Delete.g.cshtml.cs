#pragma checksum "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77238dc0f8e292c42ad2f4e73c89161bbbdf2870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Delete), @"mvc.1.0.view", @"/Views/Products/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Delete.cshtml", typeof(AspNetCore.Views_Products_Delete))]
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
#line 1 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\_ViewImports.cshtml"
using BaiThiMVC;

#line default
#line hidden
#line 2 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\_ViewImports.cshtml"
using BaiThiMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77238dc0f8e292c42ad2f4e73c89161bbbdf2870", @"/Views/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c376efd8c2adc6397badee29865a90a5c1578b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BaiThiMVC.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 47, false);
#line 15 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(293, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(337, 43, false);
#line 18 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(380, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(424, 46, false);
#line 21 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SupplierId));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(514, 42, false);
#line 24 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SupplierId));

#line default
#line hidden
            EndContext();
            BeginContext(556, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(600, 44, false);
#line 27 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(644, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(688, 51, false);
#line 30 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Category.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(739, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(783, 51, false);
#line 33 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(834, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(878, 47, false);
#line 36 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(925, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(969, 45, false);
#line 39 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1058, 41, false);
#line 42 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1143, 48, false);
#line 45 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitslnStock));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1235, 44, false);
#line 48 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UnitslnStock));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1323, 48, false);
#line 51 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1415, 44, false);
#line 54 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1503, 48, false);
#line 57 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1595, 44, false);
#line 60 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1683, 48, false);
#line 63 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1775, 44, false);
#line 66 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1857, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e32baf990a04775b124e2fc1c613cf6", async() => {
                BeginContext(1883, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1893, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e521e9b1d494b848ecddc1a8cc2cddb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "C:\Users\Tinh\source\repos\BaiThiMVC\BaiThiMVC\Views\Products\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1936, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2020, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b864c0dddc474eaa7176116ce3a869", async() => {
                    BeginContext(2042, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2058, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2071, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BaiThiMVC.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591