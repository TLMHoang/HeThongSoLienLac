function Delete(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa ?");
    if (ans) {
        $.ajax({
            url: "/TaiKhoanPH/XoaTKPH/" + ID,
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
            url: "/TaiKhoanPH/ResetPass/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                window.alert("Đặt Lại MK Thành Công");
                window.location.href = '/Admin/TaiKhoanPH/Index';
            },
            error: function (errormessage) {
                alert("Đặt Lại MK Thất Bại!");
                console.log(errormessage.responseText);
            }
        });
    }
}