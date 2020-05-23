(function () {
    'use strict';
    window.addEventListener('load',
        function () {
            // Get the forms we want to add validation styles to
            var forms = document.getElementsByClassName('needs-validation');
            // Loop over them and prevent submission
            var validation = Array.prototype.filter.call(forms,
                function (form) {
                    form.addEventListener('submit',
                        function (event) {
                            if (form.checkValidity() === false) {
                                event.preventDefault();
                                event.stopPropagation();
                            }
                            form.classList.add('was-validated');
                        },
                        false);
                });
        },
        false);
})();
function Delete(ID) {
    var ans = confirm("Bạn Có Chắc Muốn Xóa ?");
    if (ans) {
        $.ajax({
            url: "/QuanLyMonHoc/Delete/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                location.reload();
            },
            error: function (errormessage) {
                alert("Xóa Thất Bại");
            }
        });
    }
}
function ThongBao() {
    alert("Xin Lỗi Môn Này Không Thể Xóa Hoặc Sửa (Môn Mặc Định) !");
}
