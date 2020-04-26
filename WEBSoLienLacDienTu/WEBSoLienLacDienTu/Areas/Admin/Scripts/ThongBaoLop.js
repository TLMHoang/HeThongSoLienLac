function XoaThongBaoLop(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa ?");
    if (ans) {
        $.ajax({
            url: "/ThongBaoCaNhan/XoaThongBaoLop/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                location.reload();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}
$(document).ready(
    $.ajax({
        url: "/GiaoVien/ThongBaoCaNhanGV/LoadTenLopByID/",
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#maLop').text("Mã Lớp : "+result.ID);
            $('#tenLop').text("Tên Lớp : "+result.TenKhoi + result.TenLop);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    })
);
function XoaThongBaoLopGV(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa ?");
    if (ans) {
        $.ajax({
            url: "/GiaoVien/ThongBaoCaNhanGV/XoaThongBaoLopGV/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                location.reload();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}