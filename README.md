# Thi-Trac-Nghiem
CHƯƠNG TRÌNH THI TRẮC NGHIỆM CÁC MÔN HỌC THEO CÁC TRÌNH ĐỘ KHÁC NHAU
A. Yêu cầu về CSDL:
Giả sử  trường có 2 cơ sở chính : cơ sở 1  (CS1), cơ sở 2  (CS2) .
-	Mỗi cơ sở có nhiều Khoa, mỗi Khoa chỉ thuộc 1 cơ sở. Khoa có nhiều lớp, mỗi lớp chỉ thuộc 1 khoa. Khoa có nhiều giảng viên, mỗi giảng viên chỉ thuộc 1 khoa.
-	Mỗi lớp có nhiều sinh viên, mỗi sinh viên chỉ thuộc 1 lớp.
-	Mỗi môn học chỉ thuộc 1 khoa phụ trách, 1 Khoa có thể phụ trách nhiều môn.
-	Bộ đề thi trắc nghiệm chứa các câu hỏi để sinh viên thi. Mỗi câu hỏi thi thuộc 1 trong 3 trình độ sau : ĐHCQ, CĐCQ, VB2. Một môn học có thể có nhiều giảng viên ra đề , 1 giảng viên có thể ra nhiều câu hỏi thuộc các môn khác nhau.  Giảng viên là người chịu trách nhiệm soạn thảo câu hỏi để đưa vào bộ đề.  
-	Khi giảng viên đăng nhập, chương trình sẽ lọc ra các câu hỏi của giảng viên đó đã soạn. Giảng viên chỉ có khả năng chỉnh sửa cũng như xóa câu hỏi của mình soạn mà thôi. Tuy nhiên, nếu người đăng nhập thuộc nhóm KHOA thì có thể xem được tất cả các câu hỏi của các môn thuộc KHOA mình phụ trách. Giảng viên chỉ được soạn đề, thi thử.
-	Mỗi câu hỏi thi trắc nghiệm có thể có nhiều chọn lựa, nhưng chỉ có 1 chọn lựa là đúng.
-	Phòng giáo vụ đăng ký thông tin thi trắc nghiệm cho 1 lớp: môn học, ngày thi , Tiết bắt đầu thi, số câu thi , trình độ, thời gian  .
-	Chức năng quản lý khoa, lớp, giảng viên, sinh viên, môn học do phòng giáo vụ đảm nhận. 
-	Sinh viên dùng mã sinh viên để đăng nhập vào hệ thống. Nếu đăng nhập thành công, sinh viên chọn môn đã được đăng ký nhưng chưa thi, lúc này chương trình sẽ tự động lọc ra đề thi dựa vào thông tin mà giảng viên đã đăng ký cho lớp của sinh viên.
-	Trong đề thi, các câu hỏi được lựa chọn một cách ngẫu nhiên, không trùng nhau. Sau khi hết giờ làm bài (hoặc chọn kết thúc thi) thì chương trình sẽ thông báo kết quả thi cho sinh viên ngay. Bao gồm các thông tin quan trọng như mã sinh viên, họ tên sinh viên, lớp, môn thi,  ngày thi, điểm số. Sinh viên cũng có thể xem lại chi tiết bài mình vừa thi. 
Ngoài ra sinh viên cũng xem được kết quả thi của những môn khác bằng cách chọn xem điểm và cung cấp tên môn học để xem kết quả.
-	1 giảng viên có thể giảng cho nhiều môn cho nhiều lớp. Khi sinh viên lấy đề thi thì ta ưu tiên lấy các câu hỏi đúng trình độ thuộc cơ sở mà lớp đó thuộc về; chỉ khi nào cơ sở đó không đủ câu hỏi thi thì ta mới lấy thêm câu hỏi thi thuộc cơ sở còn lại. 
B. Yêu cầu về chương trình
Phân tán cơ sở dữ liệu THITN ra làm 2 mảnh với điều kiện sau: 
-	THITN được đặt trên server1: chứa thông tin của các khoa thuộc cơ sở 1.
-	THITN được đặt trên server2: chứa thông tin của các khoa thuộc cơ sở 2.
Yêu cầu phân tán sao cho khi sinh viên lấy đề thi trắc nghiệm là nhanh nhất.

Viết chương trình thực hiện các công việc sau trên từng cơ sở:
1.	Đăng nhập:
 Cơ sở		:
Login     	:
Password	:
Trước khi sinh viên/ giáo viên sử dụng chương trình thì phải đăng ký trước.  Đối với sinh viên thì masv xem như là login name (không cần password). Sau khi đăng nhập, chương trình sẽ thông báo họ tên user đăng nhập, nhóm quyền của user , bật/tắt các chức năng trên menu chính dựa theo nhóm quyền.
2. Nhập môn học: tạo form cho phép user nhập vào các môn học sẽ thi trắc nghiệm. Form có các chức năng sau: Thêm, Xóa, Hiệu chỉnh,  Ghi, Phục hồi.
3. Nhập Khoa, lớp
4. Nhập sinh viên : tạo form cho phép user nhập vào các lớp và sinh viên của lớp (trình bày dưới dạng subform) . Form có các chức năng sau: Thêm, Xóa, Hiệu chỉnh,  Ghi, Phục hồi.
5. Nhập giảng viên : tạo form cho phép user nhập vào thông tin của giảng viên. Form có các chức năng sau: Thêm, Xóa, Hiệu chỉnh,  Ghi, Phục hồi.
6. Nhập đề: Form này cho phép user là giảng viên nhập vào bộ đề thi trắc nghiệm.  
7. Chuẩn bị thi: User thuộc nhóm phòng giáo vụ nhập vào tên lớp, chọn môn học sẽ thi, chọn trình độ, số câu thi, ngày thi, thời gian thi. Khi đăng ký thi cho 1 lớp thì chương trình  phải kiểm tra các ràng buộc xem có đủ số câu thi trong bộ đề nguồn chưa, nếu không đủ thì phải báo về số lượng câu còn thiếu. Nếu đăng ký thành công, thì phải ghi nhận sẽ lấy số lượng câu hỏi cụ thể thuộc cơ sở nào.
8. Thi : Chương trình tự động in ra mã lớp và tên lớp của sinh viên dựa vào loginname (mã sinh viên) của sinh viên khi đăng nhập.  Sau khi click nút Bắt đầu thi thì chương trình sẽ lọc ra số câu thi ngẫu nhiên dựa vào các thông số mà giảng viên đã đăng ký, và sau đó tiến hành cho sinh viên thi
Lưu ý:	
- Điểm lớn nhất là 10
- Số điểm các câu là như nhau
- Khi hết thời gian qui định thì chương trình tự động kết thúc việc thi
-	Thông báo điểm ngay cho sinh viên thi.
9. Xem kết quả:  Mục này cho phép user in ra lại các câu đã thi dựa vào các thông tin : tên lớp, môn học, trình độ , (login của user đã nhập).
Màn hình kết xuất có dạng:
Lớp	: xxxxxxxxxxxxxxxxxxxxxxx
Họ tên	: xxxxxxxxxxxxxxxxxxxxxx
Môn thi	: xxxxxxxxxxxxxx
Ngày thi 	: 	dd/mm/yyyy			 

STT	Câu số
	Nội dung câu hỏi	Đáp án	Sinh viên chọn
				
				
10. Bảng điểm môn học: Giáo viên chọn tên lớp, tên môn học ; chương trình sẽ in ra bảng điểm thi hết môn của lớp đã chọn .  Mẫu in : thực hiện giống như của trường.
     11. Phân quyền : Chương trình có 4 nhóm : PGV , KHOA, Giangvien, Sinhvien
-  Nếu login thuộc nhóm PGV thì login đó có thể đăng nhập vào bất kỳ cơ sở nào để cập nhật bằng cách chọn tên cơ sở, và chỉ có các chức năng sau:
 + Chỉ có thể xem dữ liệu của phân mảnh tương ứng.
 	 + Xem được các báo cáo.
	 + Tạo login thuộc nhóm PGV
 + Đăng ký thi trắc nghiệm
-  Nếu login thuộc nhóm KHOA thì ta chỉ cho phép toàn quyền làm việc trên KHOA  đó , không được thấy dữ liệu của khoa khác (lớp, sinh viên, điểm), nhưng vẫn xem, hiệu chỉnh được các câu hỏi thuộc môn mà khoa mình phụ trách . Nhóm KHOA chỉ được tạo tài khoản cho nhóm KHOA, Giangvien

Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn gì. Căn cứ vào quyền này khi user login vào hệ thống, ta sẽ biết người đó được quyền làm việc với mảnh phân tán nào hay trên tất cả các phân mảnh.
- Nếu login thuộc nhóm Giangvien thì chỉ được quyền cập nhật đề thi, và chỉ được quyền hiệu chỉnh câu hỏi thi do mình soạn , được thi thử nhưng không ghi điểm
- Nhóm Sinhvien chỉ được thi .  


