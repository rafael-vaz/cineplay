#pragma checksum "C:\Users\ferre\Desktop\projeto-cineplay\Views\Home\SerieMandaloriano.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096da0e38eef584419616c2154ce16af835f155e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SerieMandaloriano), @"mvc.1.0.view", @"/Views/Home/SerieMandaloriano.cshtml")]
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
#line 1 "C:\Users\ferre\Desktop\projeto-cineplay\Views\_ViewImports.cshtml"
using projeto_cineplay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ferre\Desktop\projeto-cineplay\Views\_ViewImports.cshtml"
using projeto_cineplay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096da0e38eef584419616c2154ce16af835f155e", @"/Views/Home/SerieMandaloriano.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bacb55fae843d11384db977a67ac101c5ec2c9e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SerieMandaloriano : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ferre\Desktop\projeto-cineplay\Views\Home\SerieMandaloriano.cshtml"
  
    ViewData["Title"] = "O Mandaloriano";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""banner"">
  <style>.banner{background-image: url(../banners/banner-o-mandaloriano.jpg);}</style>
  <h3>O Mandaloriano</h3>
  <p>Em O Mandaloriano, Din Djarin (Pedro Pascal) é um guerreiro solitário que trabalha como caçador de recompensa.
       Ele embarca numa jornada pelos territórios esquecidos da galáxia, logo após a queda do Império e antes da criação da temida Primeira Ordem.</p>
      
 <ul class=""series-list"">
     <li><a href=""https://drive.google.com/drive/folders/1CQ3ZwiAgY7wi_wB7toOt4-jZQ8_0HROr?usp=sharing"" target=""_blank"">1ª Temporada</a></li>
    <li> <a href=""#"" target=""_blank"">2ª Temporada</a></li>
      
 </ul>
 
 </div>

 <style>
     .series-list{
    list-style: none;
}

.series-list a{
text-decoration: none;
}

.series-list a:hover{
    color:#afafaf;
}

.series-list a{
line-height: 40px;
color: #EFEFEF;
font-family: 'Amiko', sans-serif;
font-size: 15px;
font-weight: bold;
}

.banner {
    padding-bottom: 160px;
}

 </style>");
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
