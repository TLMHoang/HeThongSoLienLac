$(document).ready(
    Loadtable1()
);
function Loadtable1() {
    var IDMon = $("[name='LstMon']").val();

    $.ajax({
        url: "/PhanCongDay/LoadDsgv",
        data: { iDMon: IDMon },
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result,
                function (key, item) {
                    html += '<tr>';
                    html += '<td width="8%"><a href="#" onclick="ThemPhanCong(' + item.ID + ');" class="btn btn-primary btn-icon-split" ><span class="icon"><i class="fas fa-check-circle"></i></span><span>Chọn</span></a></td>';
                    html += '<td>' + item.ID + '</td>';
                    html += '<td>' + item.TenGV + '</td>';
                    html += '<td>' + item.SDT + '</td>';
                    html += '</tr>';
                });
            $('.tbody1').html(html);
        },
        error: function () {
            alert("Opps ! Lỗi Rồi @@");
        }
    });
};
$(document).ready(function () {
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});

function ThemPhanCong(ID) {
    var ans = confirm("Xác Nhận ?");
    
    if (ans) {
        $.ajax({
            url: "/PhanCongDay/ThemMoiPhanCong/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                goBack();
            },
            error: function (errormessage) {
                alert("Thêm Thất Bại");
            }
        });
    }
}

function goBack() {
    var idLop = $("#LayMaLop").val();
    window.location.href = '/Admin/PhanCongDay/PhanCong/' + idLop;
}