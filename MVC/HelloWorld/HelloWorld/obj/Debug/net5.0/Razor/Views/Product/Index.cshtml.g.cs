#pragma checksum "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "176291d1badb8454d3a89387b702b26554f2df9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"176291d1badb8454d3a89387b702b26554f2df9a", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 4 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Şimdiki zaman paylaşıldı.</span>\r\n</p>\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
  
    string name = "metehan";
    string surname = "kurnaz";
    int age = 28;

    string fullName = $"{name} - {surname}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    fullname: ");
#nullable restore
#line 17 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
         Write(fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n\r\n<p>\r\n");
#nullable restore
#line 22 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
      
        if (name == "metehan")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul>\r\n                <li>");
#nullable restore
#line 26 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
               Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 27 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
               Write(surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 28 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
               Write(age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n");
#nullable restore
#line 30 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Eşleşme sağlanamadı.</span>\r\n");
#nullable restore
#line 34 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
        }


    

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
#nullable restore
#line 41 "C:\Users\Metehan\Desktop\MVC\HelloWorld\HelloWorld\Views\Product\Index.cshtml"
Write(name + "" + surname);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
