$(document).ready(function () {
    LoadDrop();
});

function Loadtable() {
    var Lop = $("[name='LstLop']").val();
    var Thu = $("[name='LstThu']").val();
    event.preventDefault();
    $.ajax({
        url: "/ThoiKhoaBieu/LoadData",
        data: { IDLop: Lop, IDThu: Thu },
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result,
                function (key, item) {
                    html += '<tr>';
                    html += '<td><a href="#" onclick="return getbyID('+ item.Tiet +');" class="btn btn-primary btn-icon-split" data-toggle="modal" data-target="#myModal"><span class="icon"><i class="fas fa-pen-square"></i></span><span>Sửa</span></a></td>';
                    html += '<td>' + item.Thu + '</td>';
                    html += '<td>' + item.Tiet + '</td>';
                    html += '<td>' + item.IDMonHoc + '</td>';
                    html += '<td>' + item.TenMon + '</td>';
                    html += '</tr>';
                });
            $('.tbody').html(html);
        },
        error: function () {
            alert("Vui Lòng Chọn Đầy Đủ Thông Tin !");
        }
    });
};

function getbyID(tiet) {
    var idlop = $("[name='LstLop']").val();
    var thu = $("[name='LstThu']").val();
    $.ajax({
        url: "/ThoiKhoaBieu/GetById/",
        data: { IDLop: idlop, Thu: thu,Tiet:tiet },
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#TietModal').val(result.Tiet);
            $("[name='LstMon']").val(result.IDMonHoc);

            $('#MonHocModal').modal('show');
            
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function LoadDrop() {
    var lstkhoi = $("[name='LstKhoi']");
    var lstlop = $("[name='LstLop']");
    lstkhoi.change(function () {
        $.get("/ThoiKhoaBieu/LoadListLop", { IDKhoi: lstkhoi.val() }, function (data) {
            lstlop.empty();
            $.each(data, function (index, row) {
                lstlop.append("<option value='" + row.Value + "'>" + row.Text + "</option>")
            });
        });
    })
};

function CapNhat() {
    
    var Obj = {
        IDLop: $("[name='LstLop']").val(),
        Thu: $("[name='LstThu']").val(),
        Tiet: $('#TietModal').val(),
        IDMonHoc: $("[name='LstMon']").val()

    };
    $.ajax({
        url: "/ThoiKhoaBieu/UpdateTKB",
        data: JSON.stringify(Obj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: true,
        success: function (result) {
            Loadtable();
            alert("Cập Nhật Thành Công !");
            
            $('#MonHocModal').modal('toggle'); //or  $('#IDModal').modal('hide');
            
            
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

