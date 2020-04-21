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
                    html += '<td width="8%"><a href="#" onclick="PhanCong('+ item.ID + ');" class="btn btn-primary btn-icon-split" ><span class="icon"><i class="fas fa-check-circle"></i></span><span>Chọn</span></a></td>';
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
function PhanCong(ID) {
    window.location.href = "/Admin/PhanCongDay/PhanCong/" + ID;
}