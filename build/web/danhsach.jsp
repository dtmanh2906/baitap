<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="java.util.*, model.Khachhang" %>
<html>
    <head>
        <title>Danh sách khách hàng</title>
        <script type="text/javascript">
            function doDelete(ma) {
                if (confirm("bạn có chắc chắn xóa khách hàng có mã" + ma + "này chứ?"))
                {
                    window.location = "delete?ma=" + ma;
                }
            }
        </script>
        <style>

            h2 {
                text-align: center;
            }
            .center {
                text-align: center;
                margin-bottom: 15px;
            }
            a {
                text-decoration: none;
            }
            table {
                background-color: #f2d9c7;
                width: 90%;
                margin: auto;
                border-collapse: collapse;
                background-color: white;
            }
            th, td {
                border: 1px solid #999;
                padding: 8px 12px;
                text-align: left;
            }
            th {
                background-color: #f2d9c7;
            }
            td a {
                margin-right: 10px;
            }
            form {
                text-align: center;

            }
        </style>
    </head>
    <body>
        <h2>DANH SÁCH CÁC KHÁCH HÀNG</h2>
        <div class="center">
            <a href="them.jsp" style="color: purple;">Thêm mới</a>
        </div>
        <form action="search" method="get">
            Nhập thông tin cần tìm kiếm:<input type="text" name="search" placeholder="nhập địa chỉ cần tìm kiếm" />
            <button>Tìm kiếm</button><br>
        </form>

        <table>
            <tr>
                <th>Mã khách</th>
                <th>Họ tên</th>
                <th>Điện thoại</th>
                <th>Địa chỉ</th>
                <th>Email</th>
                <th>Thao tác</th>
            </tr>
            <%
                List<Khachhang> ds = (List<Khachhang>) request.getAttribute("data");
                if (ds != null) {
                    for (Khachhang kh : ds) {
            %>
            <tr>
                <td><%= kh.getMa() %></td>
                <td><%= kh.getHoten() %></td>
                <td><%= kh.getDienthoai() %></td>
                <td><%=kh.getDiachi() %></td>
                <td><%= kh.getEmail() %></td>
                <td>
                    <a href="update?ma=<%= kh.getMa() %>">Sửa</a>
                    <a href="#" onclick="doDelete('<%= kh.getMa() %>')">Xoá</a>
                </td>
            </tr>
            <%
                    }
                }
            %>
        </table>
    </body>
</html>
