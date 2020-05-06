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

$(document).ready(function() {
    $('#myInput').click(function() {
        $('#TimKiemModal').modal('show');
    });
});

function Loadtable() {
    var chuoiTimKiem = $("#searchInput").val();
    event.preventDefault();
    $.ajax({
        url: "/TaiKhoanPH/Search",
        data: { chuoiTimKiem: chuoiTimKiem},
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result,
                function (key, item) {
                    html += '<tr>';
                    html += '<td width=18%;><div class="row"><div class="col" style="padding:6px;"><a href="#" onclick="return Sua(' + item.ID + ');" class="btn btn-primary btn-icon-split"><span class="icon"><i class="fas fa-pen-square"></i></span><span>Sửa</span></a></div>' +
                        '<div class="col" style="padding:6px;"><div><a href="#" onclick="return Delete(' + item.ID + ');" class="btn btn-danger btn-icon-split"><span class="icon"><i class="fas fa-trash"></i></span><span>Xóa</span></a></div></td>';
                    html += '<td>' + item.ID + '</td>';
                    html += '<td>' + item.TaiKhoan + '</td>';
                    html += '<td>' + item.TenMe + '</td>';
                    html += '<td>' + item.SDTMe + '</td>';
                    html += '<td>' + item.TenBo + '</td>';
                    html += '<td>' + item.SDTBo + '</td>';
                    html += '</tr>';
                });
            $('#TimKiemTable').html(html);
            $('.ketqua').css("display","block");
        },
        error: function () {
            alert("Tìm Kiếm Thất Bại !");
        }
    });
};

function Sua(ID) {
    location.href = '/Admin/TaiKhoanPH/CapNhatTKPH/' + ID;
};