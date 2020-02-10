Nhóm  US
Đề tài: Tìm hiểu và triển khai hệ thống Sổ liên lạc điện tử cho các trường học 



Danh sách thành viên:
1.	Trần  Lê Minh Hoàng -  1711061066 – 17DTHB2
2.	Vũ Hoàng Phong - 1711060251 - 17DTHA3
3.	Trần Xuân Trường – 1711061367 – 17DHTB2
Ngôn ngữ code: C#
Ứng dụng : Visual Studio 2019, SQL Server

 
SỔ LIÊN LẠC ĐIỆN TỬ (PHẦN WEB)
Mô Tả Chức Năng 

1.Mục đích 
•	Giúp phụ huynh và nhà trường quản lý kiểm soát học sinh dễ dàng và hiệu quả
•	Giúp phụ huynh cập nhật các tin tức mới nhất của nhà trường 
•	Phụ huynh có thể kiểm soát điểm học tập của con mình 
•	Là cầu nối giữa nhà trường và phụ huynh
2. Chức Năng
Dưới đây là các chức năng chính của web hệ thống sổ liên lạc điện tử
1. Đăng nhập
2. Đổi mật khẩu
3. Xem các thông tin học tập
4. Đăng kí nghỉ phép cho con và Quản lý thông tin nghỉ phép
5. Thiết lập các thông tin
6 . Nhận thông báo của từng học sinh 
7. Nhận thông báo của nhà trường qua dạng thông báo qua trang web 

Mô tả chức năng chi tiết :
1.	Đăng nhập
Mỗi phụ huynh học sinh sẽ được nhà trường cấp cho tài khoản để đăng nhập vào hệ thống 
2.	Đổi mật khẩu
Phụ huynh đăng nhập lần đầu sẽ sử dụng mật khẩu tài khoản của nhà trường cấp , có thể đổi mật khẩu ở phần thông tin 
3.	Xem các thông tin học tập
Trên hệ thống sổ liên lạc điện tử phụ huynh có thể xem thông tin học tập liên quan đến học sinh gồm :
•	Thời khóa biểu
Phụ huynh học sinh có thể xem thời khóa biểu của con em mình theo tuần
•	Bảng điểm
Xem điểm của học tập của con em mình , xem xếp hạng
•	Danh sách lớp 
Cho phép phụ huynh có thể xem danh sách lớp của lớp con em mình
•	Thông tin các giáo viên giảng dạy của học sinh (Giáo viên bộ môn , giáo viên chủ nhiệm )
Bao gồm các thông tin họ tên , số điện thoại liên lạc của giáo viên bộ môn và giáo viên chủ nhiệm để dùng khi phụ huynh cần liên lạc với giáo viên
•	Điểm danh 
Xem số buổi điểm danh trong tháng của học sinh 


4.	Đăng kí nghỉ phép cho con và Quản lý thông tin nghỉ phép
Cho phép phụ huynh đăng kí nghỉ phép cho học sinh ( có thể có thời hạn để nhà trường duyệt ) và cho phép xem số ngày nghỉ phép của học sinh
5.	Thiết lập các thông tin
Cho phép thiết lập mật khẩu của tài khoản
6.	Nhận thông báo của từng học sinh
Nhà Trường sẽ thông báo cho phụ huynh học sinh về điểm hạnh kiểm hay thông báo học sinh nghỉ học hoặc trốn tiết
7.	Nhận thông báo của nhà trường qua dạng thông báo qua trang web
Nhận các thông báo về việc nghỉ lễ (có thể thông báo các ngày nghỉ đột xuất do bão hoặc có dịch bệnh ) hoặc các hoạt động kỉ niệm , lễ hội do nhà trường tổ chức 


 











PHẦN MỀM QUẢN LÝ HỆ THỐNG SỔ LIÊN LẠC ĐIỆN TỬ
Mô Tả Chức Năng Phần Mềm

1.Mục đích của phần mềm
•	Giúp nhà trường quản lý điểm của học sinh 1 cách triệt để vè hiệu quả
•	Các hoạt động liên lạc giữa nhà trường và phụ huynh nhanh chóng
•	Cập nhật điểm 1 cách nhanh chóng và hiệu quả
2. Chức Năng
- phần mềm  có 2 lớp người dùng , khi mở phần mềm thì phải đăng nhập bằng tài khoản 
	Nhóm tài khoản : 
Admin : có quyền quản lý tài khoản bao gồm thêm, sửa , xóa giáo viên , thêm lớp , …
Giáo Viên : Nhập điểm cho học sinh , quản lý học sinh , gửi các thông báo 
-khi đăng nhập thành công phần mêm sẽ vào giao diện chính gồm các chức năng
Chức năng quản lý chia làm 3 nhóm :
Các chức năng quản lý học sinh  
*	Chức năng Thêm Lớp : cho phép thêm 1 lớp mới và thêm danh sách học sinh vào lớp đó . 

*	Chức năng Quản Lý Học Sinh : 

-	Nhập điểm : cho phép xem danh sach bao gồm điểm của các học sinh trong lớp đó và chỉ cho phép giáo viên bộ môn hoặc chủ nhiệm lớp mới có quyền nhập điểm cho những môn mình phụ trách
-	Quản Lý học sinh : cho phép thêm xóa sửa học sinh trong lớp của mình phụ trách

*	Chức năng gửi thông báo : cho phép giáo viên gửi thông báo về tài khoản của phụ huynh học sinh
Các chức năng quản lý tài khoản 
Quản lý tài khoản PHHS : 
*	Tên tài khoản dựa vào số điện thoại của PHHS đăng ký cho con em 
*	Cho Phép Giáo Viên hoặc Admin thêm sửa xóa tài khoản PHHS 

Các chức năng quản lý (dành cho Admin)
*	Quản lý Giáo viên :  thêm sửa xóa các Giáo viên , tìm kiếm thông tin 1 Giáo Viên , phân lớp phụ trách cho giáo viên
*	Tìm kiếm thông tin giáo viên : tìm kiếm thống tin của 1 giáo viên trong hệ thống bao gồm cả lớp phụ trách





 
CÁC GIAI ĐOẠN THỰC HIỆN
+ Giai đoạn 1: Tạo APP trên nền windows. 			 (3 – 4 tuần)
-	Tạo app nhằm cho trường quản lý học sinh sinh viên cũng như giáo viên,….
+ Giai đoạn 2: Tạo web trên các nền tảng 			 (3 – 4 tuần )
-	Đề PHHS và HS có thể xem dược thông tin quá trình học(điểm)
-	Có các thông báo chung của nhà trường
-	Nội quy của trường,…
+ Giai đoạn 3: Cải thiện Web, App  				(Thời gian còn lại)
-	Thêm chức năng thông báo lỗi của HS cho tài khoản.
-	Báo ngày vắng học.
-	Liệt kê ngày vắng.
-	Tạo kênh chat (Nêu tụi em làm kịp ).
-	Thêm chức năng nhập diểm qua web cho giáo viên (Tụi em không biết cái này có cần thiết không mong thầy cho ý kiến).
-	…….
+ Hướng phát triển:	      			(Có thể sẽ làm nếu kịp thời gian)
-	Tạo app mobile cho người dùng. (Tụi em mới tính tới android nếu có thể sẽ làm còn IOS thì không chắc lắm)

