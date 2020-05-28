$(document).ready(function () {
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});

function getById(ID) {
    $.ajax({
        url: "/DiemDanhGV/getById/" + ID,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#IDModal').val(result.ID);
            $('#TenModal').val(result.Ten);
            $('#User_Ph').val(result.User_PH);
            $('#myModal').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function Them() {
    var d = new Date();
    var phep = $("input[name='Phep']:checked").val();
    var res = validate();
    if (res == false) {
        return false;
    }
    var Obj = {
        IDHocSinh: $('#IDModal').val(),
        Name: $('#TenModal').val(),
        NgayNghi: d.toLocaleDateString(),
        Phep: phep
    };
    var User_PH = $('#User_Ph').val();
    $.ajax({
        url: "/DiemDanhGV/ThemVang",
        data: JSON.stringify({ dd: Obj, User_PH: User_PH }),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $('#myModal').modal('toggle');
            alert("Thêm Thành Công");
            location.reload();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function openModal() {
    $('#myModal').modal('show');
}
function validate() {
    var isValid = true;
    if ($('input[name="Phep"]:checked').length == 0) {
        isValid = false;
    }
    return isValid;
}