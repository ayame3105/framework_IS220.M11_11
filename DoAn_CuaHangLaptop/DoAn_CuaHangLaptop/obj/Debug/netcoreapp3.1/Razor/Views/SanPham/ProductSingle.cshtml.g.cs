#pragma checksum "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ca724029505e4aec48735d829f491ef7ceec44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_ProductSingle), @"mvc.1.0.view", @"/Views/SanPham/ProductSingle.cshtml")]
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
#line 1 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\_ViewImports.cshtml"
using DoAn_CuaHangLaptop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\_ViewImports.cshtml"
using DoAn_CuaHangLaptop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ca724029505e4aec48735d829f491ef7ceec44", @"/Views/SanPham/ProductSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b8ba9fc583e43ab0ed1cccc6fe68ac4fc52165", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_ProductSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAn_CuaHangLaptop.Models.SanPham>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
  
    ViewData["Title"] = "ProductSingle";
    var sanpham = ViewData["SanPham"] as SanPham;
    var bxl = ViewData["BXL"] as BoXuLy;
    var ram = ViewData["RAM"] as BoNhoRAM;
    var mh = ViewData["MH"] as ManHinh;
    var ckn = ViewData["CKN"] as CongKetNoi;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""hero-wrap hero-bread"" style=""background-image: url(images/bg_6.jpg); "">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Shop</span></p>
                <h1 class=""mb-0 bread"">Shop</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 mb-5 ftco-animate"">
                <img");
            BeginWriteAttribute("src", " src=\"", 972, "\"", 994, 1);
#nullable restore
#line 26 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
WriteAttributeValue("", 978, sanpham.HinhAnh, 978, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Colorlib Template\">\r\n            </div>\r\n            <div class=\"col-lg-6 product-details pl-md-5 ftco-animate\">\r\n                <h3>");
#nullable restore
#line 29 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
               Write(sanpham.TenSP);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <div class=""rating d-flex"">
                    <p class=""text-left mr-4"">
                        <a href=""#"" class=""mr-2"">5.0</a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                    </p>
                    <p class=""text-left mr-4"">
                        <a href=""#"" class=""mr-2"" style=""color: #000;"">100 <span style=""color: #bbb;"">Rating</span></a>
                    </p>
                </div>
                <p class=""price""><span>");
#nullable restore
#line 43 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                  Write(sanpham.DonGia.ToString("#,##0 VNĐ"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>


                <div class=""w-100""></div>
                <div class=""input-group col-md-6 d-flex mb-3"">
                    <span class=""input-group-btn mr-2"">
                        <button type=""button"" class=""quantity-left-minus btn"" data-type=""minus"" data-field="""">
                            <i class=""ion-ios-remove""></i>
                        </button>
                    </span>
                    <input type=""text"" id=""quantity"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                    <span class=""input-group-btn ml-2"">
                        <button type=""button"" class=""quantity-right-plus btn"" data-type=""plus"" data-field="""">
                            <i class=""ion-ios-add""></i>
                        </button>
                    </span>
                </div>
                <div class=""w-100""></div>

                <p>
                    <a href=""cart.html"" class=""btn btn-black py-3 px-5 mr-2"">Add to Ca");
            WriteLiteral(@"rt</a>
                    <a href=""cart.html"" class=""btn btn-primary py-3 px-5"">Buy now</a>
                </p>
            </div>

        </div>

        <div class=""row mt-5"">
            <div class=""col-md-12 nav-link-wrap"">
                <div class=""nav nav-pills d-flex text-center"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
                    <a class=""nav-link ftco-animate active mr-lg-1"" id=""v-pills-1-tab"" data-toggle=""pill"" href=""#v-pills-1"" role=""tab"" aria-controls=""v-pills-1"" aria-selected=""true"">Mô tả</a>

                    <a class=""nav-link ftco-animate mr-lg-1"" id=""v-pills-2-tab"" data-toggle=""pill"" href=""#v-pills-2"" role=""tab"" aria-controls=""v-pills-2"" aria-selected=""false"">Chi Tiết</a>

                    <a class=""nav-link ftco-animate"" id=""v-pills-3-tab"" data-toggle=""pill"" href=""#v-pills-3"" role=""tab"" aria-controls=""v-pills-3"" aria-selected=""false"">Nhận xét của người dùng</a>

                </div>
            </div>
            <div class=""col-md");
            WriteLiteral(@"-12 tab-wrap"">

                <div class=""tab-content bg-light"" id=""v-pills-tabContent"">

                    <div class=""tab-pane fade show active"" id=""v-pills-1"" role=""tabpanel"" aria-labelledby=""day-1-tab"">
                        <div class=""p-4"">
                            <p>Chiếc laptop này mang đến cảm giác cực hầm hố thể hiện sự mạnh mẽ trên từng đường nét với gam màu đen tuyền, các góc cạnh cứng cáp. Vỏ máy được làm từ nhựa cao cấp đem đến khả năng chịu lực tốt, không quá nặng khi cho vào balo để di chuyển đối với một chiếc máy tính gaming. Mặt lưng của phiên bản mới này được tô điểm thêm bằng những đường cắt góc cạnh tựa như những tia sét trên nền đen nhám, tạo cảm giác khí thể mỗi khi mở nắp máy.</p>
                        </div>
                    </div>

                    <div class=""tab-pane fade"" id=""v-pills-2"" role=""tabpanel"" aria-labelledby=""v-pills-day-2-tab"">
                        <div class=""p-4"">
                            <div class=""container"">
                   ");
            WriteLiteral(@"             <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th colspan=""2"">Bộ xử lý</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <th scope=""row"">Công nghệ CPU</th>
                                            <td>");
#nullable restore
#line 104 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(bxl.CongNgheCPU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Số nhân</th>\r\n                                            <td>");
#nullable restore
#line 108 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(bxl.SoNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Số luồng</th>\r\n                                            <td>");
#nullable restore
#line 112 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(bxl.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Tốc độ CPU</th>\r\n                                            <td>");
#nullable restore
#line 116 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(bxl.TocDoCPU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Tốc độ tối đa</th>\r\n                                            <td>");
#nullable restore
#line 120 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(bxl.TocDoToiDa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Bộ nhớ đệm</th>\r\n                                            <td>");
#nullable restore
#line 124 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(bxl.BoNhoDem);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th colspan=""2"">Bộ nhớ RAM, Ổ cứng</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <th scope=""row"">RAM</th>
                                            <td>");
#nullable restore
#line 138 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(ram.DungLuongRAM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Loại RAM</th>\r\n                                            <td>");
#nullable restore
#line 142 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(ram.LoaiRAM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Tốc độ Bus RAM</th>\r\n                                            <td>");
#nullable restore
#line 146 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(ram.BusRAM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Hỗ trợ RAM tối đa</th>\r\n                                            <td>");
#nullable restore
#line 150 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(ram.HoTroToiDa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Ổ cứng</th>\r\n                                            <td>");
#nullable restore
#line 154 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(sanpham.OCung);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th colspan=""2"">Màn hình</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <th scope=""row"">Màn hình</th>
                                            <td>");
#nullable restore
#line 168 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(mh.KichThuoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Độ phân giải</th>\r\n                                            <td>");
#nullable restore
#line 172 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(mh.DoPhanGiai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Tần số quét</th>\r\n                                            <td>");
#nullable restore
#line 176 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(mh.TanSoQuet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Cộng nghệ màn hình</th>\r\n                                            <td>");
#nullable restore
#line 180 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(mh.CongNgheMH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Cảm ứng</th>\r\n                                            <td>");
#nullable restore
#line 184 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(mh.CamUng);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th colspan=""2"">Đồ họa và Âm thanh</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <th scope=""row"">Card màn hình</th>
                                            <td>");
#nullable restore
#line 197 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(sanpham.CardMH);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th colspan=""2"">Cổng kết nối & tính năng mở rộng</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <th scope=""row"">Cổng giao tiếp</th>
                                            <td>");
#nullable restore
#line 211 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(ckn.CongGiaoTiep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Kết nối không dây</th>\r\n                                            <td>");
#nullable restore
#line 215 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(ckn.KetNoiKhongDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Webcam</th>\r\n                                            <td>");
#nullable restore
#line 219 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(ckn.WebCam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 221 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                         if (ckn.TinhNangKhac != "")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <th scope=\"row\">Tính năng khác</th>\r\n                                                <td>");
#nullable restore
#line 225 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                               Write(ckn.TinhNangKhac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 227 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 228 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                         if (ckn.KheDocTheNho != "")
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <th scope=\"row\">Khe đọc thẻ nhớ</th>\r\n                                                <td>");
#nullable restore
#line 233 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                               Write(ckn.KheDocTheNho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 235 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">Đèn bàn phím</th>\r\n                                            <td>");
#nullable restore
#line 238 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(ckn.DenBanPhim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th colspan=""2"">Kích thước & trọng lượng</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <th scope=""row"">Kích thước,trọng lượng</th>
                                            <td>");
#nullable restore
#line 252 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(sanpham.KichThuoc_TrongLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Chất liệu</th>\r\n                                            <td>");
#nullable restore
#line 256 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(sanpham.ThietKe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th colspan=""2"">Thông tin khác</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <th scope=""row"">Thông tin Pin</th>
                                            <td>");
#nullable restore
#line 270 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(sanpham.Pin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Hệ điều hành</th>\r\n                                            <td>");
#nullable restore
#line 274 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(sanpham.HDH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th scope=\"row\">Thời điểm ra mắt</th>\r\n                                            <td>");
#nullable restore
#line 278 "E:\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\SanPham\ProductSingle.cshtml"
                                           Write(sanpham.RaMat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""v-pills-3"" role=""tabpanel"" aria-labelledby=""v-pills-day-3-tab"">
                        <div class=""row p-4"">
                            <div class=""col-md-7"">
                                <h3 class=""mb-4"">23 Reviews</h3>
                                <div class=""review"">
                                    <div class=""user-img"" style=""background-image: url(images/person_1.jpg)""></div>
                                    <div class=""desc"">
                                        <h4>
                                            <span class=""text-left"">Jacob Webb</span>
                                            <span class=""text-right"">14 March 2018</span>
                                        </h4>
       ");
            WriteLiteral(@"                                 <p class=""star"">
                                            <span>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                            </span>
                                            <span class=""text-right""><a href=""#"" class=""reply""><i class=""icon-reply""></i></a></span>
                                        </p>
                                        <p>When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrov</p>
                                    </div>
                                </div>");
            WriteLiteral(@"
                                <div class=""review"">
                                    <div class=""user-img"" style=""background-image: url(images/person_2.jpg)""></div>
                                    <div class=""desc"">
                                        <h4>
                                            <span class=""text-left"">Jacob Webb</span>
                                            <span class=""text-right"">14 March 2018</span>
                                        </h4>
                                        <p class=""star"">
                                            <span>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star");
            WriteLiteral(@"-outline""></i>
                                            </span>
                                            <span class=""text-right""><a href=""#"" class=""reply""><i class=""icon-reply""></i></a></span>
                                        </p>
                                        <p>When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrov</p>
                                    </div>
                                </div>
                                <div class=""review"">
                                    <div class=""user-img"" style=""background-image: url(images/person_3.jpg)""></div>
                                    <div class=""desc"">
                                        <h4>
                                            <span class=""text-left"">Jacob Webb</span>
                                            <span class=""text-right"">14 March 2018</span>
                                        </h4>
                 ");
            WriteLiteral(@"                       <p class=""star"">
                                            <span>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                                <i class=""ion-ios-star-outline""></i>
                                            </span>
                                            <span class=""text-right""><a href=""#"" class=""reply""><i class=""icon-reply""></i></a></span>
                                        </p>
                                        <p>When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrov</p>
                                    </div>
                                </div>
        ");
            WriteLiteral(@"                    </div>
                            <div class=""col-md-4"">
                                <div class=""rating-wrap"">
                                    <h3 class=""mb-4"">Give a Review</h3>
                                    <p class=""star"">
                                        <span>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            (98%)
                                        </span>
                                        <span>20 Reviews</span>
                                    </p>
                                    <p class=""star"">
                                       ");
            WriteLiteral(@" <span>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            (85%)
                                        </span>
                                        <span>10 Reviews</span>
                                    </p>
                                    <p class=""star"">
                                        <span>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i cla");
            WriteLiteral(@"ss=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            (98%)
                                        </span>
                                        <span>5 Reviews</span>
                                    </p>
                                    <p class=""star"">
                                        <span>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            (98%)
                                        </span>
                                        <span>0 Reviews</span>
                            ");
            WriteLiteral(@"        </p>
                                    <p class=""star"">
                                        <span>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            <i class=""ion-ios-star-outline""></i>
                                            (98%)
                                        </span>
                                        <span>0 Reviews</span>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<style>
    .table .thead-light th {
        font-weight: bold;
    }");
            WriteLiteral("\r\n    .table th {\r\n        font-weight: bold;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn_CuaHangLaptop.Models.SanPham> Html { get; private set; }
    }
}
#pragma warning restore 1591
