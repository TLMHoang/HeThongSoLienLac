function Loadtable() {
    var IDKhoi = $("[name='LstKhoi']").val();
    event.preventDefault();
    $.ajax({
        url: "/QuanLyLop/LoadData",
        data: { iDKhoi: IDKhoi},
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result,
                function (key, item) {
                    html += '<tr>';
                    html += '<td><a href="#" onclick="return getbyID(' + item.ID + ');" class="btn btn-primary btn-icon-split" ><span class="icon"><i class="fas fa-pen-square"></i></span><span>Sửa</span></a></td>';
                    html += '<td><a href="#" onclick="return XoaLop(' + item.ID + ');" class="btn btn-danger btn-icon-split" ><span class="icon"><i class="fas fa-trash"></i></span><span>Xóa</span></a></td>';
                    html += '<td>' + item.ID + '</td>';
                    html += '<td>' + item.TenLop + '</td>';
                    html += '</tr>';
                });
            $('.tbody').html(html);
        },
        error: function () {
            alert("Vui Lòng Chọn Khối !");
        }
    });
};
function getbyID(ID) {
    $('#TenLopModal').css('border-color', 'lightgrey');

    $.ajax({
        url: "/QuanLyLop/getbyID/" + ID,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $("[name='LstKhoiModal']").val(result.IDKhoi);
            $('#MaLopModal').val(result.ID);
            $('#TenLopModal').val(result.TenLop);

            $('#QuanLyLopModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}
function CapNhat() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var Obj = {
        IDKhoi: $("[name='LstKhoiModal']").val(),
        TenLop: $('#TenLopModal').val(),
        ID: $('#MaLopModal').val()
    };
    $.ajax({
        url: "/QuanLyLop/CapNhatLop",
        data: JSON.stringify(Obj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            Loadtable();
            $('#QuanLyLopModal').modal('toggle');
            $('#TenLopModal').val("");
            $('#MaLopModal').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function OpenModal() {
    $('#QuanLyLopModal').modal('show');
}

function Them() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var Obj = {
        IDKhoi:$("[name='LstKhoiModal']").val(),
        TenLop: $('#TenLopModal').val()
    };
    $.ajax({
        url: "/QuanLyLop/ThemLop",
        data: JSON.stringify(Obj),
        type: "POST",
        async: true,
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            Loadtable();
            $('#QuanLyLopModal').modal('toggle');
            
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function XoaLop(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa ?");
    if (ans) {
        $.ajax({
            url: "/QuanLyLop/XoaLop/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                Loadtable();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}

function validate() {
    var isValid = true;
    if ($('#TenLopModal').val().trim() == "") {
        $('#TenLopModal').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#TenLopModal').css('border-color', 'lightgrey');
    }
    return isValid;
}
function clearTextBox() {

    $('#TenLopModal').val("");
    $('#TenLopModal').css('border-color', 'lightgrey');
    $('#btnUpdate').hide();
    $('#btnAdd').show();
}