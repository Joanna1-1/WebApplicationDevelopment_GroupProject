#pragma checksum "C:\Users\admin\Desktop\COMP 229 SEC.001\Group Project\Final Version COMP229_G1\Project_v.2\RecipeWebApp\Views\Crud\RecipeEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14951b227f063905efdf86126f5a3b121b1c8f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Crud_RecipeEdit), @"mvc.1.0.view", @"/Views/Crud/RecipeEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Crud/RecipeEdit.cshtml", typeof(AspNetCore.Views_Crud_RecipeEdit))]
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
#line 1 "C:\Users\admin\Desktop\COMP 229 SEC.001\Group Project\Final Version COMP229_G1\Project_v.2\RecipeWebApp\Views\_ViewImports.cshtml"
using RecipeWebApp.Models;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\COMP 229 SEC.001\Group Project\Final Version COMP229_G1\Project_v.2\RecipeWebApp\Views\_ViewImports.cshtml"
using RecipeWebApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14951b227f063905efdf86126f5a3b121b1c8f7a", @"/Views/Crud/RecipeEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f210b1b5c831d2a3a7144177f8a3c776ff6fa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Crud_RecipeEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\Desktop\COMP 229 SEC.001\Group Project\Final Version COMP229_G1\Project_v.2\RecipeWebApp\Views\Crud\RecipeEdit.cshtml"
  
    ViewBag.Title = "Add New Recipe";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(88, 104, true);
            WriteLiteral("\r\n<div class=\"panel-body recDiv\">\r\n    <div class=\"hTitle\">\r\n        ADD YOUR RECIPE\r\n    </div>\r\n\r\n    ");
            EndContext();
            BeginContext(193, 45, false);
#line 13 "C:\Users\admin\Desktop\COMP 229 SEC.001\Group Project\Final Version COMP229_G1\Project_v.2\RecipeWebApp\Views\Crud\RecipeEdit.cshtml"
Write(await Html.PartialAsync("_RecipeForm", Model));

#line default
#line hidden
            EndContext();
            BeginContext(238, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591