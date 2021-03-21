function Loadtable() {
    var IDKhoi = $("[name='LstKhoi']").val();
    event.preventDefault();
    $.ajax({
        url: "/QuanLyLop/LoadData",
        data: { iDKhoi: IDKhoi },
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