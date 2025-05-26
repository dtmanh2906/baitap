<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="java.util.*, model.KhachHang" %>
<html>
<head>
    <style>
        table {
            background-color: #fef5e7;
            border-collapse: collapse;
            width: 90%;
            margin: auto;
        }
        th, td {
            border: 1px solid #aaa;
            padding: 8px;
            text-align: center;
        }
        th {
            background-color: #f4cfa0;
        }
        h2 {
            text-align: center;
        }
        a {
            text-decoration: none;
            color: blue;
            font-weight: bold;
        }
        .add-link {
            text-align: center;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
<h2>DANH SÁCH CÁC KHÁCH HÀNG</h2>

<div class="add-link">
    <a href="themKhach">Thêm mới</a>
</div>

<table>
    <tr>
        <th>Mã khách</th>
        <th>Họ tên</th>
        <th>Điện thoại</th>
        <th>Email</th>
        <th>Thao tác</th>
    </tr>
    <%
        List<KhachHang> ds = (List<KhachHang>) request.getAttribute("dskhachhang");
        if (ds != null) {
            for (KhachHang kh : ds) {
    %>
    <tr>
        <td><%= kh.getMa() %></td>
        <td><%= kh.getHoten() %></td>
        <td><%= kh.getDienthoai() %></td>
        <td><%= kh.getEmail() %></td>
        <td>
            <a href="suaKhach?ma=<%= kh.getMa() %>">Sửa</a> &nbsp;
            <a href="xoaKhach?ma=<%= kh.getMa() %>" onclick="return confirm('Bạn chắc chắn muốn xoá?');">Xoá</a>
        </td>
    </tr>
    <%
            }
        }
    %>
</table>
</body>
</html>
