function XoaThongBaoHS(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa ?");
    if (ans) {
        $.ajax({
            url: "/ThongBaoCaNhan/XoaThongBaoHS/" + ID,
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
$(document).ready(function () {
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});
