var MLD;
var HK;
var LanKT;
$(document).ready(
    function () {
        LoadDrop();
        $("[name='LstLoaiDiem']").change();
    }
    );

function LoadDrop() {
    var LstLoaiDiem = $("[name='LstLoaiDiem']");
    var LstSoLan = $("[name='LstSoLan']");
    LstLoaiDiem.change(function () {
        $.get("/QuanLyNhapDiem/LoadSoLanNhap", { LoaiDiem: LstLoaiDiem.val() }, function (data) {
            LstSoLan.empty();
            $.each(data, function (index, row) {
                LstSoLan.append("<option value='" + row.Value + "'>" + row.Text + "</option>")
            });
        });
    })
};

$('#submitButton').click(function() {
    Loadtable();
    LoadTenDanhSach();
    MLD = $("[name='LstLoaiDiem']").val();
    HK = $("[name='LstHocKy']").val();
    LanKT = $("[name='LstSoLan']").val();
});

function Loadtable() {
    var HocKy = $("[name='LstHocKy']").val();
    var LoaiDiem = $("[name='LstLoaiDiem']").val();
    var Lan = $("[name='LstSoLan']").val();
    event.preventDefault();
    $.ajax({
        url: "/QuanLyNhapDiem/LoadData",
        data: { IDLoaiDiem: LoaiDiem, Lan: Lan, HocKyI: HocKy },
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result,
                function (key, item) {
                    html += '<tr>';
                    html += '<td>' + item.MaHS + '</td>';
                    html += '<td>' + item.Ten + '</td>';
                    if (item.Diem == -1) {
                        html += '<td width="8%" style="padding:5px;"><input type="text" value="" style="display:none;width:100%;" /></td>';
                    } else {
                        html += '<td width="8%"> <span>' + item.Diem + '</span> </td>';
                    }
                    if (item.Diem == -1) {
                        html += '<td width="8% class="justify-content-center"" style="padding:0;"><a class="btn btn-warning Edit" style="width:100%;margin-top:5px;color:white;" href="javascript:;">Nhập</a>' +
                            ' <a class="Update" href="javascript:;" style="display:none;color:blue;margin-left:15%;">Lưu</a> <a class="Cancel" href="javascript:;" style="margin-left:10px;display:none;color:red;">Hủy</a>  </td>';
                    } else {
                        html += '<td width="8%"></td>';
                    }
                    html += '</tr>';
                });
            $('.tbody').html(html);
            
        },
        error: function () {
            alert("Load Thông Tin Thất Bại,Kiểm Tra Lại Thông Tin !");
        }
    });
};
$("body").on("click", "#dataTable .Edit", function () {
    var row = $(this).closest("tr");
    $("td", row).each(function () {
        if ($(this).find("input").length > 0) {
            $(this).find("input").show();
            $(this).find("span").hide();
        }
    });
    row.find(".Update").show();
    row.find(".Cancel").show();
    $(this).hide();
});

$("body").on("click", "#dataTable .Cancel", function () {
    var row = $(this).closest("tr");
    $("td", row).each(function () {
        if ($(this).find("input").length > 0) {
            var span = $(this).find("span");
            var input = $(this).find("input");
            input.val(span.html());
            span.show();
            input.hide();
        }
    });
    row.find(".Edit").show();
    row.find(".Update").hide();
    $(this).hide();
});

function LoadTenDanhSach() {
    var LoaiDiem = $('#LstLoaiDiem option:selected').text();
    var Lan = $("[name='LstSoLan']").val();
    $('#lblLoaiDiem').text(LoaiDiem);
    $('#lblLan').text('Lần '+ Lan);
}