# Quản lý Kí túc xá

## Giới thiệu
- Với số lượng sinh viên lớn, số phòng ở và số hóa đơn cần quản lý tương ứng cũng rất lớn, thực tế cho thấy việc ứng dụng công nghệ thông tin vào quản lý ký túc xá là một nhu cầu tất yếu, hiển nhiên.
- Nắm bắt được xu hướng trên, ứng dụng Quản lý kí túc xá với mục tiêu hướng đến sự đơn giản, tiện dụng, dễ cài đặt và thao tác cho người sử dụng. Đồng thời nhấn mạnh tính hiện đại, tinh tế trong việc trải nghiệm người dùng, trên hết là những tính năng cần thiết nhất của công việc quản lý.
- Đối tượng người dùng hướng đến là nhà quản lý hoặc nhân viên ký túc xá.
## Giao diện và chức năng
### Màn hình đăng nhập khi khởi động
Để đảm bảo tính bảo mật cho việc sử dụng, giúp phân cấp quyền người sử dụng, mỗi khi khởi động ứng dụng hoặc kết thúc phiên làm việc, người sử dụng được yêu cầu đăng nhập lại ứng dụng.

![Màn hình đăng nhập khi khởi động](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/login.png)
### Giao diện chính
Đây là môi trường giao diện tương tác chính với người dùng. Được phân chia thành các mục, tương ứng với từng chức năng chính của ứng dụng.
- Nhóm chức năng quản trị: Đăng xuất để kết thúc phiên làm việc, Thoát để đăng xuất và thoát khỏi phần mềm.
- Nhóm chức năng thêm mới: Đăng ký thông tin cho Sinh viên khi bắt đầu ở kí túc xá, tạo phiếu đăng ký Phòng ở cho sinh viên, thêm Hóa đơn chứa thông tin các dịch vụ sử dụng theo tháng của mỗi phòng.
- Nhóm chức năng thông tin: xem thông tin chi tiết về danh sách các Khu phòng hiện có trong kí túc xá, thông tin các Loại phòng ở, các Dịch vụ hiện có mà kí túc xá cung cấp. Chức năng Tìm kiếm thông tin, Hướng dẫn và giới thiệu về ứng dụng. Ngoài ra, đối với người quản lý, còn có thêm 2 chức năng nâng cao, đó là xem danh sách các Nhân viên do mình quản lý, chức năng Báo cáo phục vụ cho công việc báo cáo.

![Giao diện chính](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/man-hinh-chinh.png)

### Chức năng thêm mới
#### Thêm thông tin sinh viên
Được dùng khi thêm thông tin một sinh viên mới, chứa có thông tin lưu trữ trong cơ sở dữ liệu.
Mỗi sinh viên, ứng với mã số sinh viên tương ứng, sẽ có các thông tin quản lý về: *Họ tên, Ngày sinh, Giới tính, Lớp, Quê quán, CMND, Số điện thoại, Email, Bảo hiểm y tế, Diện sinh viên, Ảnh chân dung.*

![Thêm thông tin sinh viên - ảnh 1](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-them-1.png)

![Thêm thông tin sinh viên - ảnh 2](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-them-2.png)
