$(document).ready(function () {
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});
function Delete(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa ?");
    if (ans) {
        $.ajax({
            url: "/TaiKhoanTruong/Delete/" + ID,
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
function ResetPass() {
    var ans = confirm("Bạn Có Chắc Muốn Đặt Lại MK ?");
    var id = $('#maTK').val();
    if (ans) {
        $.ajax({
            url: "/TaiKhoanTruong/ResetPass/" +id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                window.alert("Đặt Lại MK Thành Công");
                window.location.href = '/Admin/TaiKhoanTruong/Index';
            },
            error: function (errormessage) {
                alert("Đặt Lại MK Thất Bại!");
                console.log(errormessage.responseText);
            }
        });
    }
}