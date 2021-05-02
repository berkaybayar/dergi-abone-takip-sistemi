#pragma checksum "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Shared\_DergiChartPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e10b54898e996982db32db47eaa26b43df879d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DergiChartPartial), @"mvc.1.0.view", @"/Views/Shared/_DergiChartPartial.cshtml")]
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
#line 1 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\_ViewImports.cshtml"
using DAboneTakip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\_ViewImports.cshtml"
using DAboneTakip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e10b54898e996982db32db47eaa26b43df879d", @"/Views/Shared/_DergiChartPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da3daaf701e9a129f2e18589ab3a9a401fbd2ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DergiChartPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n            $.ajax({\r\n                type: \"GET\",\r\n                dataType: \"json\",\r\n                contentType: \"application/json\",\r\n                url: \'");
#nullable restore
#line 9 "C:\Users\berka\source\repos\dergi-abone-takip-sistemi\Views\Shared\_DergiChartPartial.cshtml"
                 Write(Url.Action("VDergiChart", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                success: function (result2) {
                    google.charts.load('current', {
                        'packages': ['corechart']
                    });
                    google.charts.setOnLoadCallback(function () {
                        drawChart2(result2);
                    });
                }
            });
    });

    function drawChart2(result2) {
        var data2 = new google.visualization.DataTable();
        data2.addColumn('string', 'Dergi');
        data2.addColumn('number', 'Abone Sayısı');
        var dataArray2 = [];

        $.each(result2, function (i, obj2) {
            dataArray2.push([obj2.dergi, obj2.abonesayi]);
        });
        data2.addRows(dataArray2);

        var columnChartOptions2 = {
            title: ""Dergi - Abone Sayısı Grafiği"",
            width: 1000,
            height: 400,
            bar: { groupWidth: ""20%"" },
        };

        var columnChart2 = new google.visualization.PieChart(document.getElementBy");
            WriteLiteral("Id(\'Piechart_div2\'));\r\n\r\n        columnChart2.draw(data2, columnChartOptions2);\r\n    }\r\n\r\n\r\n</script>\r\n\r\n\r\n<div id=\"Piechart_div2\"></div>\r\n");
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
