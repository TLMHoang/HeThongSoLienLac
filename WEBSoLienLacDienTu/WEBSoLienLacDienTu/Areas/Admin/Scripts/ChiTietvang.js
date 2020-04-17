function getByIdDiemDanh(ID) {
    $.ajax({
        url: "/DiemDanh/getByIdDiemDanh/" + ID,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            var jsondate = result.NgayNghi;
            var date = ConvertJsonDateString(jsondate);
            $('#IDModal').val(result.ID);
            $('#IDHocSinhModal').val(result.IDHocSinh);
            $('#NgayModal').val(date);
            $("input[name='Phep'][value='"+result.Phep+"']").prop('checked',true);
            $('#myModal').modal('show');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}
function ConvertJsonDateString(jsonDate) {
    var shortDate = null;
    if (jsonDate) {
        var regex = /-?\d+/;
        var matches = regex.exec(jsonDate);
        var dt = new Date(parseInt(matches[0]));
        var month = dt.getMonth() + 1;
        var monthString = month > 9 ? month : '0' + month;
        var day = dt.getDate();
        var dayString = day > 9 ? day : '0' + day;
        var year = dt.getFullYear();
        shortDate = dayString + '/' + monthString + '/' + year;
    }
    return shortDate;
};
function CapNhat() {
    var phep = $("input[name='Phep']:checked").val();
    var res = validate();
    if (res == false) {
        return false;
    }
    var Obj = {
        ID: $('#IDModal').val(),
        IDHocSinh: $('#IDHocSinhModal').val(),
        NgayNghi: $('#NgayModal').val(),
        Phep: phep

    };
    $.ajax({
        url: "/DiemDanh/CapNhatVang",
        data: JSON.stringify(Obj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $('#myModal').modal('toggle');
            alert("Cập Nhật Thành Công");
            location.reload();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function Xoa(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa ?");
    if (ans) {
        $.ajax({
            url: "/DiemDanh/XoaVang/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                alert("Xóa Thành Công");
                location.reload();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}
function validate() {
    var isValid = true;
    if ($('input[name="Phep"]:checked').length == 0) {
        isValid = false;
    }
    return isValid;
}

function openModal() {
    $('#myModal').modal('show');
}
