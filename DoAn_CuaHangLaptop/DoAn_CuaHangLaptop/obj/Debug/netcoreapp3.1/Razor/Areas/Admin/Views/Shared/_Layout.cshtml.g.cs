#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9da162eb709496e43e816f902259c43a72ca3c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da162eb709496e43e816f902259c43a72ca3c9d", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9da162eb709496e43e816f902259c43a72ca3c9d3156", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 264, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 291, "\"", 301, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>SB Admin 2 - Tables</title>

    <!-- Custom fonts for this template -->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i""
          rel=""stylesheet"">

    <!-- Custom styles for this template -->
    <link href=""css/sb-admin-2.css"" rel=""stylesheet"">

    <!-- Custom styles for this page -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link href=""vendor/datatables/dataTables.bootstrap4.min.css"" rel=""stylesheet"">
    <link href=""./css/sub-style.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""build/css/bootstrap-datetimepicker.min.css"">


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9da162eb709496e43e816f902259c43a72ca3c9d5551", async() => {
                WriteLiteral(@"

    <!-- Page Wrapper -->
    <div id=""wrapper"">

        <!-- Sidebar -->
        <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

            <!-- Sidebar - Brand -->
            <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
                <div class=""sidebar-brand-icon rotate-n-15"">
                    <i class=""fas fa-laugh-wink""></i>
                </div>
                <div class=""sidebar-brand-text mx-3"">SB Admin <sup>2</sup></div>
            </a>

            <!-- Divider -->
            <hr class=""sidebar-divider my-0"">

            <!-- Nav Item - Dashboard -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""index.html"">
                    <i class=""fas fa-fw fa-tachometer-alt""></i>
                    <span>Dashboard</span>
                </a>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

       ");
                WriteLiteral(@"     <!-- Heading -->
            <div class=""sidebar-heading"">
                Interface
            </div>

            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo""
                   aria-expanded=""true"" aria-controls=""collapseTwo"">
                    <i class=""fas fa-fw fa-cog""></i>
                    <span>Components</span>
                </a>
                <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Components:</h6>
                        <a class=""collapse-item"" href=""buttons.html"">Buttons</a>
                        <a class=""collapse-item"" href=""cards.html"">Cards</a>
                    </div>
                </div>
            </li>

            <!-- Nav Ite");
                WriteLiteral(@"m - Utilities Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities""
                   aria-expanded=""true"" aria-controls=""collapseUtilities"">
                    <i class=""fas fa-fw fa-wrench""></i>
                    <span>Utilities</span>
                </a>
                <div id=""collapseUtilities"" class=""collapse"" aria-labelledby=""headingUtilities""
                     data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Utilities:</h6>
                        <a class=""collapse-item"" href=""utilities-color.html"">Colors</a>
                        <a class=""collapse-item"" href=""utilities-border.html"">Borders</a>
                        <a class=""collapse-item"" href=""utilities-animation.html"">Animations</a>
                        <a class=""collapse-item"" href=""utilities-oth");
                WriteLiteral(@"er.html"">Other</a>
                    </div>
                </div>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-- Heading -->
            <div class=""sidebar-heading"">
                Sản phẩm
            </div>



            <!-- Nav Item - Tables -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""Danhmuc.html"">
                    <i class=""fas fa-fw fa-table""></i>
                    <span>Danh mục</span>
                </a>
            </li>

            <!-- Nav Item - Tables -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""CPU.html"">
                    <i class=""fas fa-fw fa-table""></i>
                    <span>CPU</span>
                </a>
            </li>

            <!-- Nav Item - Tables -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""RAM.html"">
                    <i class=""fas fa-fw fa-table""></i>
      ");
                WriteLiteral(@"              <span>RAM</span>
                </a>
            </li>

            <!-- Nav Item - Tables -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""ManHinh.html"">
                    <i class=""fas fa-fw fa-table""></i>
                    <span>Màn hình</span>
                </a>
            </li>

            <!-- Nav Item - Tables -->
            <li class=""nav-item"">
                <a class=""nav-link"" href=""CongKetNoi.html"">
                    <i class=""fas fa-fw fa-table""></i>
                    <span>Cổng kết nối</span>
                </a>
            </li>

            <!-- Nav Item - Tables -->
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""ChiTietSanPham.html"">
                    <i class=""fas fa-fw fa-table""></i>
                    <span>Chi tiết sản phẩm</span>
                </a>
            </li>



            <!-- Divider -->
            <hr class=""sidebar-divider d-none d-md-block"">
");
                WriteLiteral(@"
            <!-- Sidebar Toggler (Sidebar) -->
            <div class=""text-center d-none d-md-inline"">
                <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
            </div>

        </ul>
        <!-- End of Sidebar -->
        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">

            <!-- Main Content -->
            <div id=""content"">

                <!-- Topbar -->
                <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

                    <!-- Sidebar Toggle (Topbar) -->
                    <form class=""form-inline"">
                        <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                            <i class=""fa fa-bars""></i>
                        </button>
                    </form>



                    <!-- Topbar Navbar -->
                    <ul class=""navbar-nav ml-auto"">

                   ");
                WriteLiteral(@"     <!-- Nav Item - Search Dropdown (Visible Only XS) -->
                        <li class=""nav-item dropdown no-arrow d-sm-none"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-search fa-fw""></i>
                            </a>
                            <!-- Dropdown - Messages -->
                            <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                                 aria-labelledby=""searchDropdown"">
                                <form class=""form-inline mr-auto w-100 navbar-search"">
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control bg-light border-0 small""
                                               placeholder=""Search for..."" aria-label=""Searc");
                WriteLiteral(@"h""
                                               aria-describedby=""basic-addon2"">
                                        <div class=""input-group-append"">
                                            <button class=""btn btn-primary"" type=""button"">
                                                <i class=""fas fa-search fa-sm""></i>
                                            </button>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </li>



                        <div class=""topbar-divider d-none d-sm-block""></div>

                        <!-- Nav Item - User Information -->
                        <li class=""nav-item dropdown no-arrow"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
               ");
                WriteLiteral(@"                 <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Douglas McGee</span>
                                <img class=""img-profile rounded-circle""
                                     src=""img/undraw_profile.svg"">
                            </a>
                            <!-- Dropdown - User Information -->
                            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""userDropdown"">
                                <a class=""dropdown-item"" href=""#"">
                                    <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Profile
                                </a>
                                <a class=""dropdown-item"" href=""#"">
                                    <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Settings
                                </a>
                        ");
                WriteLiteral(@"        <a class=""dropdown-item"" href=""#"">
                                    <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Activity Log
                                </a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Logout
                                </a>
                            </div>
                        </li>

                    </ul>

                </nav>
                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                ");
#nullable restore
#line 256 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <!-- /.container-fluid -->

            </div>
            <!-- End of Main Content -->
            <!-- Footer -->
            <footer class=""sticky-footer bg-white"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright &copy; Your Website 2020</span>
                    </div>
                </div>
            </footer>
            <!-- End of Footer -->

        </div>
        <!-- End of Content Wrapper -->

    </div>
    <!-- End of Page Wrapper -->
    <!-- Scroll to Top Button-->
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>

    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div clas");
                WriteLiteral(@"s=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Bootstrap core JavaScript-->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

    <!--");
                WriteLiteral(@" Custom scripts for all pages-->
    <script src=""js/sb-admin-2.min.js""></script>

    <!-- Page level plugins -->
    <script src=""vendor/datatables/jquery.dataTables.min.js""></script>
    <script src=""vendor/datatables/dataTables.bootstrap4.min.js""></script>

    <!-- Page level custom scripts -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.21.0/moment.min.js"" type=""text/javascript""></script>
    <script src=""build/js/bootstrap-datetimepicker.min.js""></script>
    <script type=""text/javascript"">
            $(function () {
                $('#datetimepicker1').dat");
                WriteLiteral("etimepicker();\r\n            });\r\n    </script>\r\n    <script src=\"js/demo/datatables-demo.js\"></script>\r\n    <script src=\"./js/sub-main.js\"></script>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
