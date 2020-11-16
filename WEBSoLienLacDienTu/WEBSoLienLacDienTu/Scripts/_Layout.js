$(document).ready(function () {
    $("#sidebar").mCustomScrollbar({
        theme: "minimal"
    });
    $('#dismiss, .overlay').on('click', function () {
        $('#sidebar').removeClass('active');
        $('.overlay').removeClass('active');
    });
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').addClass('active');
        $('.overlay').addClass('active');
        $('.collapse.in').toggleClass('in');
        $('a[aria-expanded=true]').attr('aria-expanded', 'false');
    });
    $('#linkBHYT').click(function () {
        $('#sidebar').removeClass('active');
        $('.overlay').removeClass('active');
        LoadBhyt();
        $('#BHYTModal').modal('show');
    });
    $.ajax({
        url: "/TaiKhoanPhuHuynh/TenHS",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $("#lblTenHS").text(result);
        }
    });
    $.ajax({
        url: "/BaoHiemYTe/CheckDateBHYT",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (result === 1) {
                $("#linkBHYT").css("display", "block");
                $("#LinkIndexBHYT").css("display", "block");
            }
        }
    });



    $.ajax({
        url: "/Admin/TaiKhoanTruong/CheckStatusTaiKhoan/",
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            if (parseInt(result) == 1) {
                $('body').append('<script type="text/javascript" id="hs-script-loader" async defer src="//js.hs-scripts.com/8744210.js"></script>');
            }
        }
    });


});
$(window).on("load", function () {
    $(".loader-wrapper").fadeOut("slow");
});

function LoadBhyt() {
    $.ajax({
        url: "/BaoHiemYTe/TrangThaiBHYT",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            if (result.DangKy === 1 || result.BHQD === 1) {

                html += '<div class="row justify-content-center">';
                html += '<div>';
                html += '<label style="font-weight: bold; margin-right: 5px;">BHYT</label><label>Trạng Thái: </label>';
                if (result.DangKy == 0) {
                    html += '<label style="color: red;">Chưa Đăng Ký</label>';
                } else {
                    html += '<label style="color: greenyellow;">Đã Đăng Ký</label>';
                }
                html += '</div>';
                html += '</div>';
                html += '<div class="row justify-content-center">';
                html += '<div>';
                html += '<label style="font-weight: bold; margin-right: 5px;">BHQD</label><label>Trạng Thái: </label>';
                if (result.BHQD == 0) {
                    html += '<label style="color: red;">Chưa Đăng Ký</label>';
                } else {
                    html += '<label style="color: greenyellow;">Đã Đăng Ký</label>';
                }
                html += '<div class="row justify-content-center mx-auto"><button class="btn btn-danger" onclick="HuyDangKyBHYT();" style="color: white; font-weight: bold;">Hủy Đăng Ký</button></div>';
                html += '</div>';
                html += '</div>';
            }

            else {
                html += '<div class="row justify-content-center">';
                html += '<div>';
                html += '<label style="font-weight: bold; margin-right: 5px;">BHYT</label><label>Trạng Thái: </label>';
                if (result.DangKy == 0) {
                    html += '<label style="color: red;">Chưa Đăng Ký</label>';
                } else {
                    html += '<label style="color: greenyellow;">Đã Đăng Ký</label>';
                }
                html += '</div>';
                html += '</div>';
                html += '<div class="row justify-content-center">';
                html += '<div>';
                html += '<label style="font-weight: bold; margin-right: 5px;">BHQD</label><label>Trạng Thái: </label>';
                if (result.BHQD == 0) {
                    html += '<label style="color: red;">Chưa Đăng Ký</label>';
                } else {
                    html += '<label style="color: greenyellow;">Đã Đăng Ký</label>';
                }
                html += '</div>';
                html += '<div class="row justify-content-center mx-auto">' +
                    '<button class="btn btn-warning col" onclick="DangKyBHYT();" style="margin-right: 15px; color: white;">Đăng Ký BHYT</button>' +
                    '<button class="btn btn-warning col" onclick="DangKyBHQD();" style="color: white;">Đã Có BHQD</button></div>';
                html += '</div>';
            }
            $('#bodyModal_BHYT').html(html);
        },
        error: function () {
            alert("Lỗi !");
        }
    });
}
function DangKyBHYT() {
    var ans = confirm("Xác Nhận ?");
    if (ans) {
        $.ajax({
            url: "/BaoHiemYTe/DKBHYT/",
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                alert("Đăng Ký Thành Công !");
                LoadBhyt();
                setTimeout(function () { $('#BHYTModal').modal('hide'); }, 3000);
            },
            error: function (errormessage) {
                alert("Cập Nhật Thất Bại !");
            }
        });
    }
};
function DangKyBHQD() {
    var ans = confirm("Xác Nhận ?");
    if (ans) {
        $.ajax({
            url: "/BaoHiemYTe/DKBHQD/",
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                alert("Đăng Ký Thành Công !");
                LoadBhyt();
                setTimeout(function () { $('#BHYTModal').modal('hide'); }, 3000);
            },
            error: function (errormessage) {
                alert("Cập Nhật Thất Bại !");
            }
        });
    }
};
function HuyDangKyBHYT() {
    var ans = confirm("Bạn Có Chăc Muốn Hủy ?");
    if (ans) {
        $.ajax({
            url: "/BaoHiemYTe/HuyBHYT/",
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                alert("Thành Công !");
                LoadBhyt();
                setTimeout(function () { $('#BHYTModal').modal('hide'); }, 3000);
            },
            error: function (errormessage) {
                alert("Thất Bại !");
            }
        });
    }
};
function CheckStatus() {


    $.ajax({
        url: "Areas/Admin/TaiKhoanTruong/CheckStatusTaiKhoan/",
        type: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#CheckStatus').text(result);

        },
        error: function (errormessage) {
            alert("Thất Bại !");
        }
    });

};