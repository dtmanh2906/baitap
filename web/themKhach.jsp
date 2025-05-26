<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Thêm khách hàng</title>
</head>
<body>
<h2 style="text-align:center;">Thêm khách hàng mới</h2>
<form action="themKhach" method="post" style="width:300px; margin:auto;">
    <label>Mã KH:</label><br>
    <input type="text" name="ma" required><br><br>
    <label>Họ tên:</label><br>
    <input type="text" name="hoten" required><br><br>
    <label>Điện thoại:</label><br>
    <input type="text" name="dienthoai" required><br><br>
    <label>Email:</label><br>
    <input type="email" name="email" required><br><br>
    <input type="submit" value="Thêm">
</form>
</body>
</html>
