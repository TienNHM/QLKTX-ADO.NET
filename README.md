# Quản lý Kí túc xá

![GitHub contributors](https://img.shields.io/github/contributors/TienNHM/QLKTX-ADO.NET) ![GitHub issues](https://img.shields.io/github/issues/TienNHM/QLKTX-ADO.NET?color=red) ![GitHub top language](https://img.shields.io/github/languages/top/TienNHM/QLKTX-ADO.NET?color=cyan) ![GitHub repo size](https://img.shields.io/github/repo-size/TienNHM/QLKTX-ADO.NET) ![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/TienNHM/QLKTX-ADO.NET) ![GitHub commit activity](https://img.shields.io/github/commit-activity/m/TienNHM/QLKTX-ADO.NET?color=g) ![GitHub last commit](https://img.shields.io/github/last-commit/TienNHM/QLKTX-ADO.NET?color=yellow) ![GitHub release (latest by date)](https://img.shields.io/github/v/release/TienNHM/QLKTX-ADO.NET)

Các thành viên:
- Nguyễn Huỳnh Minh Tiến - [@TienNHM](https://github.com/TienNHM)
- Hồ Quốc Khánh - [@khanhthusinh](https://github.com/khanhthusinh)

## Giới thiệu
- Với số lượng sinh viên lớn, số phòng ở và số hóa đơn cần quản lý tương ứng cũng rất lớn, thực tế cho thấy việc ứng dụng công nghệ thông tin vào quản lý ký túc xá là một nhu cầu tất yếu, hiển nhiên.
- Nắm bắt được xu hướng trên, ứng dụng Quản lý kí túc xá với mục tiêu hướng đến sự đơn giản, tiện dụng, dễ cài đặt và thao tác cho người sử dụng. Đồng thời nhấn mạnh tính hiện đại, tinh tế trong việc trải nghiệm người dùng, trên hết là những tính năng cần thiết nhất của công việc quản lý.
- Đối tượng người dùng hướng đến là nhà quản lý hoặc nhân viên ký túc xá.
## Giao diện và chức năng
### 1. Màn hình đăng nhập khi khởi động
Để đảm bảo tính bảo mật cho việc sử dụng, giúp phân cấp quyền người sử dụng, mỗi khi khởi động ứng dụng hoặc kết thúc phiên làm việc, người sử dụng được yêu cầu đăng nhập lại ứng dụng.

![Màn hình đăng nhập khi khởi động](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/login.png)
### 2. Giao diện chính
Đây là môi trường giao diện tương tác chính với người dùng. Được phân chia thành các mục, tương ứng với từng chức năng chính của ứng dụng.
- Nhóm chức năng quản trị: Đăng xuất để kết thúc phiên làm việc, Thoát để đăng xuất và thoát khỏi phần mềm.
- Nhóm chức năng thêm mới: Đăng ký thông tin cho Sinh viên khi bắt đầu ở kí túc xá, tạo phiếu đăng ký Phòng ở cho sinh viên, thêm Hóa đơn chứa thông tin các dịch vụ sử dụng theo tháng của mỗi phòng.
- Nhóm chức năng thông tin: xem thông tin chi tiết về danh sách các Khu phòng hiện có trong kí túc xá, thông tin các Loại phòng ở, các Dịch vụ hiện có mà kí túc xá cung cấp. Chức năng Tìm kiếm thông tin, Hướng dẫn và giới thiệu về ứng dụng. Ngoài ra, đối với người quản lý, còn có thêm 2 chức năng nâng cao, đó là xem danh sách các Nhân viên do mình quản lý, chức năng Báo cáo phục vụ cho công việc báo cáo.

![Giao diện chính](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/man-hinh-chinh.png)

### 3. Chức năng thêm mới
<details>
  <summary>Mô tả</summary>
  
#### 3.1. Thêm thông tin sinh viên
Được dùng khi thêm thông tin một sinh viên mới, chứa có thông tin lưu trữ trong cơ sở dữ liệu.
Mỗi sinh viên, ứng với mã số sinh viên tương ứng, sẽ có các thông tin quản lý về: *Họ tên, Ngày sinh, Giới tính, Lớp, Quê quán, CMND, Số điện thoại, Email, Bảo hiểm y tế, Diện sinh viên, Ảnh chân dung.*

![Thêm thông tin sinh viên - ảnh 1](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-them-1.png)

<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-them-2.png" alt="Thêm thông tin sinh viên - ảnh 2" ></p>

#### 3.2. Tạo phiếu đăng ký phòng ở
![Tạo phiếu đăng ký phòng](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-them-pdk.png)

Mỗi phiếu đăng kí phòng sẽ có một mã số xác định (tự động sinh ra khi tạo mới) để quản lý các thông tin về: *Mã nhân viên tạo phiếu đăng ký, Mã số sinh viên, Khu, Phòng, Ngày bắt đầu ở, Học kỳ, Năm học, Thời hạn ở, Ngày giờ tạo hóa đơn.*

<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-them-pdk-2.png" alt="Tạo phiếu đăng ký phòng - 2"></p>

#### 3.3. Tạo mới một hóa đơn tháng:
Mỗi tháng, sẽ xuất hóa đơn dịch vụ mà mỗi phòng sử dụng trong tháng trước đó. Các dịch vụ sử dụng: điện, nước, đổ rác, wifi,…
Mỗi hóa đơn sẽ xuất theo phòng, gồm các thông tin về:
- Nhân viên tạo hóa đơn
- Ngày lập hóa đơn
- Tháng
- Năm học
- Khu
- Phòng
- Danh sách các dịch vụ mà phòng đó sử dụng, gồm: Mã dịch vụ, Tên dịch vụ, Số lượng, Đơn vị tính.

Sau khi cung cấp đầy đủ thông tin về hóa đơn, người dùng có thể in hóa đơn và giao cho khách hàng.
![Hóa đơn - 1](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-hoa-don-1.png)

<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-hoa-don-2.png" alt="Hóa đơn - 2" ></p>

</details>

### 4. Chức năng xem và cập nhật thông tin
<details>
  <summary>Mô tả</summary>
  
#### 4.1. Xem danh sách các khu phòng
![Chức năng thông tin khu phòng](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-thong-tin-khu-phong.png)

#### 4.2. Xem danh sách và chỉnh sửa thông tin các nhân viên được quản lý
![Chức năng thông tin nhân viên](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-thong-tin-nhan-vien.png)

Khi nhấn vào từng nhân viên, sẽ hiện ra các thông tin chi tiết về nhân viên đó để có thể sửa đổi, cập nhật mới.

![Thông tin nhân viên](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/thong-tin-nhan-vien.png)

#### 4.3. Xem danh sách các loại phòng
![Chức năng thông tin loại phòng](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-thong-tin-loai-phong.png)

Khi nhấn vào từng loại phòng, sẽ hiện thông tin chi tiết về loại phòng đó.

<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-chi-tiet-loai-phong.png" alt="Chi tiết loại phòng" ></p>

#### 4.4. Xem danh sách các dịch vụ
![Chức năng thông tin dịch vụ](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-thong-tin-dich-vu.png)

Khi nhấn vào từng dịch vụ, sẽ hiện thông tin chi tiets về từng dịc vụ đó.

![Chi tiết dịch vụ](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-chi-tiet-dich-vu.png)

### 4.5. Tìm kiếm thông tin
<details>
  <summary>Mô tả</summary>
  
Cung cấp cho người dùng khả năng tìm kiếm và lọc dữ liệu một cách tiện dụng, trực quan và hiệu quả. Đồng thời nhấn mạnh sự đơn giản, dễ sử dụng.
#### 4.5.1. Giao diện chính
![Chức năng tìm kiếm](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-tim-kiem.png)

Với chức năng tìm kiếm, người dùng dễ dọn chọn đối tượng tìm kiếm, bao gồm: Sinh viên, Nhân viên, Phòng, Phiếu đăng ký phòng, Hóa đơn.

##### 4.5.2. Tìm kiếm sinh viên
Người dùng chọn tiếp nội dung cần tìm kiếm, sau đó nhập từ khóa để bấm tìm.
![Tìm kiếm sinh viên](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-tim-sinh-vien.png)

Kết quả trả về:
![Kết quả tìm sinh viên](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/kq-tim-sinh-vien.png)

Tương tự, ta có thể tìm kiếm các thông tin về nhân viên, phòng, phiếu đăng ký và hóa đơn.

#### 4.5.3. Tìm kiếm nhân viên
![Chức năng tìm nhân viên](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-tim-nhan-vien.png)

Kết quả trả về:

<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/kq-tim-nhan-vien.png" alt="Kết quả tìm nhân viên" ></p>

#### 4.5.4. Tìm kiếm phòng
![Chức năng tìm phòng](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/kq-tim-phong.png)

Kết quả trả về:
<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/kq-tim-phong.png" alt="Kết quả tìm phòng" ></p>

#### 4.5.5. Tìm kiếm phiếu đăng ký phòng
![Chức năng tìm phiếu đăng ký phòng](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-tim-pdk.png)

Kết quả trả về:
<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/kq-tim-pdk.png" alt="Kết quả tìm phiếu đăng ký phòng"></p>

#### 4.5.6. Tìm kiếm hóa đơn
![Chức năng tìm hóa đơn](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/cn-tim-hoa-don.png)

Kết quả trả về:
<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/kq-tim-hoa-don.png" alt="Kết quả tìm hóa đơn"></p>

</details>

### 4.6. Xem và cập nhật thông tin chi tiết từ các kết quả tìm kiếm
<details>
  <summary>Mô tả</summary>
  
Để xem và cập nhật thông tin từ các tìm kiếm trả về, chỉ câng nhấn vào dòng chưa thông tin tương ứng và bắt đầu sửa chữa.
#### 4.6.1. Xem và cập nhật thông tin sinh viên
<p align="center"><img src="https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/sua-sinh-vien.png" alt="Xem và cập nhật thông tin sinh viên"></p>

#### 4.6.2. Xem và cập nhật thông tin nhân viên
![Xem và cập nhật thông tin nhân viên](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/sua-nhan-vien.png)

#### 4.6.3. Xem và cập nhật thông tin phòng
![Xem và cập nhật thông tin phòng](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/sua-phong-o.png)

#### 4.6.4. Xem và in phiếu đăng ký phòng
![Xem và in phiếu đăng ký phòng](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/sua-pdk.png)

![In phiếu đăng ký](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/in-pdk.png)

#### 4.6.5. Xem và cập nhật thông tin và in hóa đơn
![Xem và cập nhật thông tin và in hóa đơn](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/sua-hoa-don.png)

![In hóa đơn](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/in-hoa-don.png)

</details>

### 4.7. Báo cáo

</details>

## 5. Diagram
<details>
  <summary>Mô tả</summary>
  
### 5.1. Database diagram
![Database diagram](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/database-diagram.png)

### 5.2. Class diagram
![Class diagram](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/class-diagram.png)

![Class diagram 2](https://github.com/TienNHM/QLKTX-ADO.NET/raw/master/QLKTX/Resources/images/class-diagram-2.png)

</details>
