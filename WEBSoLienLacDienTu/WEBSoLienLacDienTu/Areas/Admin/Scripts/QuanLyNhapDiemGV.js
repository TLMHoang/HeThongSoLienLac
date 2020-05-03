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

$('#submitButton').click(function () {
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
                    html += '<td class="MaHS"> <span>' + item.MaHS + '</span></td>';
                    html += '<td>' + item.Ten + '</td>';
                    if (item.Diem == -1) {
                        html += '<td class="Diem" width="8%" style="padding:5px;"><input type="text" onkeypress="return (event.charCode !=8 && event.charCode ==0 || ( event.charCode == 46 || (event.charCode >= 48 && event.charCode <= 57)))" maxlength="4" pattern="[0-9]" value="" style="display:none;width:100%;" /></td>';
                    } else {
                        html += '<td class="Diem" width="8%"> <span>' + item.Diem + '</span> </td>';
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
    $('#lblLan').text('Lần ' + Lan);
}
function ChuanHoa(num) {
    var z;
    if (num.charAt(1) == "." || num.charAt(0) == ".") {
        return (Math.round(num * 4) / 4).toFixed(2);
    } else if (num.length == 4) {
        z = (Math.round((num / 1000) * 4) / 4).toFixed(2);
        return z;
    } else if (num.length == 3) {
        z = (Math.round((num / 100) * 4) / 4).toFixed(2);
        return z;
    } else if (num == 10) {
        return num;
    } else if (num.length == 2) {
        z = (Math.round((num / 10) * 4) / 4).toFixed(2);
        return z;
    }
    else {
        return num;
    }
}
//Update event handler.
//$(".Update").keydown(function(e) {
//    if (e.keyCode === 13) {
//        var Diem;
//        var $row = $(this).closest("tr");
//        $("td", $row).each(function() {
//            if ($(this).find("input").length > 0) {
//                var input = $(this).find("input");
//                Diem = input.val();
//                input.hide();
//            }
//        });
//        $row.find(".Cancel").hide();
//        $(this).hide();

//        var mark = {};
//        mark.IDHocSinh = $row.find(".MaHS").find("span").html();
//        mark.IDLoaiDiem = MLD;
//        mark.Diem = ChuanHoa(Diem);
//        mark.HocKyI = HK;
//        mark.CotDiem = LanKT;

//        $.ajax({
//            type: "POST",
//            url: "/GiaoVien/QuanLyNhapDiem/ThemDiem",
//            data: '{mark:' + JSON.stringify(mark) + '}',
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function(result) {
//                Loadtable();
//            },
//            error: function() {
//                alert("Thêm Điểm Thất Bại!");
//                Loadtable();
//            }
//        });
//    }
//});
$("body").on("click", "#dataTable .Update", function () {
    var Diem;
    var $row = $(this).closest("tr");
    $("td", $row).each(function () {
        if ($(this).find("input").length > 0) {
            var input = $(this).find("input");
            Diem = input.val();
            input.hide();
        }
    });
    $row.find(".Cancel").hide();
    $(this).hide();

    var mark = {};
    mark.IDHocSinh = $row.find(".MaHS").find("span").html();
    mark.IDLoaiDiem = MLD;
    mark.Diem = ChuanHoa(Diem);
    mark.HocKyI = HK;
    mark.CotDiem = LanKT;

    $.ajax({
        type: "POST",
        url: "/GiaoVien/QuanLyNhapDiem/ThemDiem",
        data: '{mark:' + JSON.stringify(mark) + '}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (result) {
            Loadtable();
        },
        error: function () {
            alert("Thêm Điểm Thất Bại!");
            Loadtable();
        }
    });
});
