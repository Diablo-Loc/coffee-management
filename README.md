# coffee-management
# Language: VA
# Object-Oriented Programming Project: Coffee Shop Management System

This is a university project for the Object-Oriented Programming course, simulating a complete Coffee Shop Management (Point of Sale - POS) system.

The system is built on the .NET 8 platform using C# and Windows Forms. It strictly adheres to a **3-Layer Architecture (UI-BLL-DAL)** and deeply applies **Object-Oriented Design Principles** to solve real-world business logic.

## Tech Stack

* **Language:** C# 12
* **Platform:** .NET 8
* **UI:** Windows Forms (WinForms)
* **Database:** SQLite (using a "Code-First" approach for automatic database generation)
* **Architecture:** 3-Layer (UI - BLL - DAL)
* **Core Principles:** OOP (Inheritance, Polymorphism, Abstraction, Encapsulation), Strategy Pattern (via `IComparer`).

## Key Features (Role-Based)

The system supports three user roles with clearly defined, role-based access control:

### 1. Administrator

The Admin has the highest level of authority, focusing on system setup and maintenance:
* **Employee Account Management:** Full CRUD (Create, Read, Update, Delete) permissions for all accounts (Admin, Manager, Cashier).
* **Menu Management:** Full CRUD permissions for all products (Food, Drink, Dessert).

### 2. Manager

The Manager focuses on monitoring and optimizing daily business operations:
* **Cashier Management:** Can only view, edit, and adjust salary/work hours for `Cashier`-level employees.
* **Menu Management (Limited):** Can only edit the information (price, description) of existing products.
* **View Reports:** Access the reporting dashboard to see sales statistics and top-selling products visualized in a chart.

### 3. Cashier

The Cashier is the primary user of the POS. The interface is optimized for speed and simplicity:
* **Table Management:** View the status of all tables (Free/Occupied).
* **Order Creation & Updates:** Select a table, add items, update quantities, and remove items from an order.
* **Payment Processing:** Finalize payments, which automatically generates a `Bill` from the active `Order`.

##  Getting Started

### 1. Installation and Execution

1.  Clone this repository to your local machine.
2.  Open the `.sln` file using **Visual Studio 2022** (with the .NET 8 SDK installed).
3.  Press **F5** (or the "Start" button) to compile and run the project.
4.  **IMPORTANT (Code-First):** The system uses a "Code-First" approach. When you run the application for the first time, three SQLite database files (`employees.db`, `Order.db`, `Menu.db`) will be **automatically created** in the project's `bin/Debug` folder.

*(If you want a file db have a data, you can)
1. In project, find the folder named `Data_Test`.
2. **Copy** the 3 files inside: `employees.db`, ​​`Order.db`, ​​`Menu.db`.
3. Open your project folder, go to the path: `[Project Name]/bin/Debug/net8.0-windows`.
4. **Paste** the 3 `.db` files into this `Debug` folder.

### 2. Login Credentials

To experience the different roles, please use the following default accounts.

| Role | Username | Password |
| **Admin**   | `admin`   | `123` |
| **Manager** | `Loc`     | `222` |
| **Manager** | `Thanh`   | `111` |
| **Cashier** | `Turlte`  | `333` |
| **Cashier** | `Bee`     | `444` |
| **Cashier** | `Foh`     | `5555` |

*(Note: The database initialization only creates the tables. You will need to log in as `admin` to create the `manager` and `cashier` accounts if they do not yet exist.)*
## 👥 Authors

* **Nguyen Dak Loc** - 24110107
* **Le Tuan Thanh** - 24110128








# Language: VI
# Đồ án Lập trình Hướng đối tượng: Hệ thống Quản lý Quán Cà phê

Đây là đồ án môn học Lập trình Hướng đối tượng (OOP), mô phỏng một hệ thống Quản lý Quán Cà phê (Point of Sale - POS) hoàn chỉnh.

Hệ thống được xây dựng trên nền tảng .NET 8 (C#) và Windows Forms, tuân thủ nghiêm ngặt **Kiến trúc 3 lớp (UI-BLL-DAL)** và áp dụng sâu các nguyên lý **Thiết kế Hướng đối tượng** để giải quyết các bài toán nghiệp vụ thực tế.

## Công nghệ sử dụng

* **Ngôn ngữ:** C# 12
* **Nền tảng:** .NET 8
* **Giao diện:** Windows Forms (WinForms)
* **Cơ sở dữ liệu:** SQLite (với phương pháp "Code-First" tự động tạo CSDL)
* **Kiến trúc:** 3-Layer (UI - BLL - DAL)
* **Nguyên lý thiết kế:** OOP (Kế thừa, Đa hình, Trừu tượng, Đóng gói), Strategy Pattern (qua `IComparer`).

## Các Tính năng chính (Phân theo vai trò)

Hệ thống hỗ trợ 3 vai trò người dùng với các chức năng được phân quyền rõ rệt:

### 1. Administrator (Quản trị viên)

Quản trị viên có toàn quyền cao nhất, tập trung vào việc thiết lập và duy trì hệ thống:
* **Quản lý Tài khoản Nhân viên:** Toàn quyền Thêm, Sửa, Xóa (CRUD) tất cả các tài khoản (Admin, Manager, Cashier).
* **Quản lý Thực đơn (Menu):** Toàn quyền Thêm, Sửa, Xóa (CRUD) các sản phẩm (Đồ ăn, Thức uống, Tráng miệng).

### 2. Manager (Quản lý)

Quản lý tập trung vào việc giám sát và tối ưu hóa hoạt động kinh doanh hàng ngày:
* **Quản lý Thu ngân:** Chỉ có quyền xem, sửa thông tin và điều chỉnh lương/giờ làm cho nhân viên `Cashier`.
* **Quản lý Thực đơn (Giới hạn):** Chỉ có quyền chỉnh sửa thông tin (giá, mô tả) của các sản phẩm hiện có.
* **Xem Báo cáo:** Truy cập hệ thống báo cáo, thống kê doanh thu và xem các sản phẩm bán chạy nhất dưới dạng biểu đồ trực quan.

### 3. Cashier (Thu ngân)

Thu ngân là người dùng chính của hệ thống, giao diện được tối ưu cho nghiệp vụ bán hàng:
* **Quản lý Bàn:** Xem trạng thái các bàn (Trống/Có khách).
* **Tạo và Cập nhật Đơn hàng:** Chọn bàn, thêm món, cập nhật số lượng, xóa món.
* **Thanh toán:** Thực hiện thanh toán và tự động tạo `Bill` (Hóa đơn) từ `Order` (Đơn hàng) hiện tại.

## Hướng dẫn sử dụng

### 1. Cài đặt và Khởi chạy

1.  Clone kho lưu trữ này về máy của bạn.
2.  Mở file `.sln` bằng **Visual Studio 2022** (yêu cầu đã cài đặt .NET 8 SDK).
3.  Nhấn **F5** (hoặc nút "Start") để biên dịch và chạy dự án.
4.  **QUAN TRỌNG:** Hệ thống sử dụng phương pháp "Code-First". Khi bạn chạy ứng dụng lần đầu tiên, 3 file CSDL (`employees.db`, `Order.db`, `Menu.db`) sẽ được **tự động tạo** trong thư mục `bin/Debug` của dự án.

*(If you want a db file with a data, you can)
1.  Trong thư mục gốc của dự án, tìm thư mục có tên `Data_Test`.
2.  **Sao chép (Copy)** 3 file bên trong: `employees.db`, `Order.db`, `Menu.db`.
3.  Mở thư mục dự án của bạn, đi đến đường dẫn: `[Tên Project]/bin/Debug/net8.0-windows`.
4.  **Dán (Paste)** 3 file `.db` vào thư mục `Debug` này.

### 2. Tài khoản Đăng nhập

Để trải nghiệm các vai trò, vui lòng sử dụng các tài khoản mặc định sau:

| Vai trò | Username | Password |
| :--- | :--- | :--- |
| **Admin**   | `admin`   | `123` |
| **Manager** | `Loc`     | `222` |
| **Manager** | `Thanh`   | `111` |
| **Cashier** | `Turlte`  | `333` |
| **Cashier** | `Bee`     | `444` |
| **Cashier** | `Foh`     | `5555` |

*(Lưu ý: Quá trình khởi tạo CSDL chỉ tạo bảng. Bạn cần đăng nhập bằng tài khoản `admin` lần đầu tiên để xem xét và tạo các tài khoản `manager`, `cashier` nếu chúng chưa tồn tại.)*

## 👥 Tác giả

* **Nguyễn Đăk Lộc** - 24110107
* **Lê Tuấn Thành** - 24110128