<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="model.KhachHang" %>
<%
    KhachHang kh = (KhachHang) request.getAttribute("khachhang");
%>
<html>
<head>
    <title>Sửa khách hàng</title>
</head>
<body>
<h2 style="text-align:center;">Sửa thông tin khách hàng</h2>
<form action="suaKhach" method="post" style="width:300px; margin:auto;">
    <label>Mã KH:</label><br>
    <input type="text" name="ma" value="<%= kh.getMa() %>" readonly><br><br>
    <label>Họ tên:</label><br>
    <input type="text" name="hoten" value="<%= kh.getHoten() %>" required><br><br>
    <label>Điện thoại:</label><br>
    <input type="text" name="dienthoai" value="<%= kh.getDienthoai() %>" required><br><br>
    <label>Email:</label><br>
    <input type="email" name="email" value="<%= kh.getEmail() %>" required><br><br>
    <input type="submit" value="Cập nhật">
</form>
</body>
</html>
