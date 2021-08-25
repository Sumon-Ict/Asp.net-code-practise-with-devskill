#pragma checksum "H:\Asp.net code\Asp.net-code-practise-with-devskill\StudentSystem\StudentSystem\Areas\Admin\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8ea8fc0efda5eee1cf517a799efd2830883805"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Student_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Student/Index.cshtml")]
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
#line 1 "H:\Asp.net code\Asp.net-code-practise-with-devskill\StudentSystem\StudentSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Asp.net code\Asp.net-code-practise-with-devskill\StudentSystem\StudentSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8ea8fc0efda5eee1cf517a799efd2830883805", @"/Areas/Admin/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31f856083ec6f2bb147cdac5c5163d9590d9793b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentSystem.Areas.Admin.Models.StudentListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeletePopupPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\Asp.net code\Asp.net-code-practise-with-devskill\StudentSystem\StudentSystem\Areas\Admin\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/admin/plugins/datatables-bs4/css/dataTables.bootstrap4.css\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/admin/plugins/datatables/jquery.dataTables.js""></script>
    <script src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.js""></script>
    <script>
        $(function () {
            $(""#students"").DataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""ajax"": ""/Admin/Student/GetJsonResult"",
                ""columnDefs"": [
                    {
                        ""orderable"": false,
                        ""targets"": 6,
                        ""render"": function (data, type, row) {
                            return `<button type=""submit"" class=""btn btn-info btn-sm"" onclick=""window.location.href='/admin/student/edit/${data}'"" value='${data}'>
                                        <i class=""fas fa-pencil-alt"">
                                        </i>
                                        Edit
                                    </button>
                                    <button type=""submit"" class=""btn b");
                WriteLiteral(@"tn-danger btn-sm show-bs-modal"" href=""#"" data-id='${data}' value='${data}'>
                                        <i class=""fas fa-trash"">
                                        </i>
                                        Delete
                                    </button>`;
                        }
                    }
                ]
            });
            $('#students').on('click', '.show-bs-modal', function (event) {
                var id = $(this).data(""id"");
                var modal = $(""#modal-default"");
                modal.find('.modal-body p').text('Are you sure you want to delete this record?')
                $(""#deleteId"").val(id);
                $(""#deleteForm"").attr(""action"", ""/admin/student/delete"")
                modal.modal('show');
            });
            $(""#deleteButton"").click(function () {
                $(""#deleteForm"").submit();
            });
        });
    </script>
");
            }
            );
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>Available Students</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"">Student</li>
                </ol>
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <h3 class=""card-title"">All Available Students</h3>
                </div>
                <!-- /.card-header -->
                <div class=""card-body"">
                    <table id=""students"" class=""table table-bordered table-hove");
            WriteLiteral(@"r"">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Address</th>
                                <th>DateOfBirth</th>
                                <th>Roll</th>
                                <th>Phone</th>
                                <th>CGPA</th>
                                <th style=""width:160px"">Action</th>
                            </tr>
                        </thead>

                        <tfoot>
                            <tr>
                                <th>Name</th>
                                <th>Address</th>
                                <th>DateOfBirth</th>
                                <th>Roll</th>
                                <th>Phone</th>
                                <th>CGPA</th>
                                <th>Action</th>
                            </tr>
                        </tfoot>
                    </table>
           ");
            WriteLiteral("         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a8ea8fc0efda5eee1cf517a799efd28308838058482", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <!-- /.card-body -->\r\n            </div>\r\n            <!-- /.card -->\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentSystem.Areas.Admin.Models.StudentListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591