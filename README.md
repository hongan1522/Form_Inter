# Form_NV

Đây là báo cáo thực tập tại Gonsa. Đây là kết quả sau khoảng thời gian làm việc của tôi khi được giao task.

## **Form1**

Page Quản lý nhân viên

![image](https://github.com/hongan1522/Form_NV/assets/95673805/afcc859d-cace-492d-939b-ac5f46e67cd9)

Page Quản lý nhân viên khi xóa

![image](https://github.com/hongan1522/Form_NV/assets/95673805/b73c6fd6-1f25-4506-93cd-2c0a1d98e190)

                                      
Page Quản lý đơn hàng

![image](https://github.com/hongan1522/Form_NV/assets/95673805/a4c63451-23f3-42b4-83ac-c93771479b90)

Page Quản lý đơn hàng khi xóa

![image](https://github.com/hongan1522/Form_NV/assets/95673805/d30366da-11db-4449-a629-095886bb21cf)


Page Quản lý đơn hàng khi mã hóa

![image](https://github.com/hongan1522/Form_NV/assets/95673805/5af05a17-eae8-44f1-aad7-ea02f4d593fb)


Page Quản lý đơn hàng khi giải mã 

![image](https://github.com/hongan1522/Form_NV/assets/95673805/19f223f0-2be1-441e-b9ce-14e3b799663b)


![Ảnh chụp màn hình 2023-10-18 105724](https://github.com/hongan1522/Form_NV/assets/95673805/a2fa3145-f9aa-415f-a317-cac07a8414ec)

  Chức năng chính Page Quản lý nhân viên. Khi cập nhật thêm, sửa, xóa sẽ lưu dữ liệu vào file json và cập nhật lại mã cho đúng.
- Nhập nhân viên
- Xóa nhân viên
- Sửa nhân viên
- Export dữ liệu nhân viên ra file Excel
- Import dữ liệu nhân viên từ file Excel
- Refesh lại các text box

Chức năng chính Page Quản lý đơn hàng:
- Nhập đơn hàng
- Xóa đơn hàng
- Sửa đơn hàng
- Export dữ liệu đơn hàng ra file Excel
- Import dữ liệu đơn hàngn từ file Excel
- Refesh lại các text box
- Mã hóa (AES)  dữ liệu đơn hàng ra file config với key là Mã, value là Tên
- Giải mã dữ liệu đơn hàng từ file config và save dữ liệu đã giải mã ra file text

## **CodeForm**

Đây là FormCode code design thủ công các thành phần. 

![image](https://github.com/hongan1522/Form_NV/assets/95673805/e4466bdf-312f-47ab-8b2c-8d0e4920676e)


Các chức năng gồm như Page Quản lý nhân viên:
- Nhập nhân viên
- Xóa nhân viên
- Sửa nhân viên
- Export dữ liệu nhân viên ra file Excel
- Import dữ liệu nhân viên từ file Excel
- Refesh lại các text box

## **Cách cài đặt**
- Copy link HTTPS trong phần Code trên Github
- Mở git bash gõ lệnh "git clone https://github.com/hongan1522/Form_NV.git"
- Trong project Form_NV có 2 form, muốn chạy Form1 hay CodeForm thì vào Program.cs để gõ lệnh:
  + Chạy Form1 thì gõ "*Application.Run(new Form1());*"
  + Chạy CodeForm1 thì gõ "*Application.Run(new CodeForm());*"   
- Sau đó bấm chạy Form để thực hiện các phương thức
