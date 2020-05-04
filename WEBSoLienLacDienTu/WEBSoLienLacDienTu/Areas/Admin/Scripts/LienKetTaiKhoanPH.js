var IDHocSinh;
$(document).ready(function () {
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});
//$("#LienKetModal").on("show", function () {
//    $("body").addClass("modal-open");
//    $(".modal-open").css("overflow", "hidden");
//}).on("hidden", function () {
//    $("body").removeClass("modal-open");
//});
function ShowModalAdd(ID) {
    IDHocSinh = ID;
    $('#btnSearchAdd').css("display", "block");
    $('#btnSearchUpdate').css("display", "none");
    $('#LienKetModal').modal('show');
}
function ShowModalUpdate(ID) {
    IDHocSinh = ID;
    $('#btnSearchAdd').css("display","none");
    $('#btnSearchUpdate').css("display", "block");
    $('#LienKetModal').modal('show');
}
function Xoa(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa Liên Kết ?");
    if (ans) {
        $.ajax({
            url: "/LienKetTaiKhoanPH/Delete/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                alert("Xóa Thành Công");
                location.reload();
            },
            error: function (errormessage) {
                alert("Xóa Thất Bại !");
            }
        });
    }
}
function Loadtable() {
    var chuoiTimKiem = $("#searchInput").val();
    event.preventDefault();
    $.ajax({
        url: "/TaiKhoanPH/Search",
        data: { chuoiTimKiem: chuoiTimKiem },
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result,
                function (key, item) {
                    html += '<tr>';
                    html += '<td width=10%;><div class="row"><div class="col" style="padding:6px;"><a href="#" onclick="return Them(' + item.ID + ');" class="btn btn-primary btn-icon-split"><span class="icon"><i class="fas fa-pen-square"></i></span><span>Chọn</span></a></div></td>';
                    html += '<td>' + item.ID + '</td>';
                    html += '<td>' + item.TaiKhoan + '</td>';
                    html += '<td>' + item.TenMe + '</td>';
                    html += '<td>' + item.SDTMe + '</td>';
                    html += '<td>' + item.TenBo + '</td>';
                    html += '<td>' + item.SDTBo + '</td>';
                    html += '</tr>';
                });
            $('#TimKiemTable').html(html);
            $('.ketqua').css("display", "block");
        },
        error: function () {
            alert("Tìm Kiếm Thất Bại !");
        }
    });
};

function Loadtable1() {
    var chuoiTimKiem = $("#searchInput").val();
    event.preventDefault();
    $.ajax({
        url: "/TaiKhoanPH/Search",
        data: { chuoiTimKiem: chuoiTimKiem },
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result,
                function (key, item) {
                    html += '<tr>';
                    html += '<td width=10%;><div class="row"><div class="col" style="padding:6px;"><a href="#" onclick="return CapNhat(' + item.ID + ');" class="btn btn-primary btn-icon-split"><span class="icon"><i class="fas fa-pen-square"></i></span><span>Chọn</span></a></div></td>';
                    html += '<td>' + item.ID + '</td>';
                    html += '<td>' + item.TaiKhoan + '</td>';
                    html += '<td>' + item.TenMe + '</td>';
                    html += '<td>' + item.SDTMe + '</td>';
                    html += '<td>' + item.TenBo + '</td>';
                    html += '<td>' + item.SDTBo + '</td>';
                    html += '</tr>';
                });
            $('#TimKiemTable').html(html);
            $('.ketqua').css("display", "block");
        },
        error: function () {
            alert("Tìm Kiếm Thất Bại !");
        }
    });
};
function Them(ID) {
    $.ajax({
        url: "/LienKetTaiKhoanPH/ThemLK",
        data: JSON.stringify({ iDHS: IDHocSinh, id: ID }),
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            location.reload();
        },
        error: function (errormessage) {
            alert("Liên Kết Thất Bại !");
        }
    });
}
function CapNhat(ID) {
    $.ajax({
        url: "/LienKetTaiKhoanPH/CapNhatLK",
        data: JSON.stringify({ iDHS: IDHocSinh, id: ID }),
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            location.reload();
        },
        error: function (errormessage) {
            alert("Cập Nhật Liên Kết Thất Bại !");
        }
    });
}

function clearTXT() {
    $('#searchInput').val("");
    $(".ketqua").css("display", "none");
}