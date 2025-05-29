<%-- 
    Document   : them
    Created on : May 29, 2025, 12:50:24 PM
    Author     : dinht
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Quản lý khách hàng </title>
    </head>
    <body>
    <center>
        <h4>NHẬP THÊM THÔNG TIN KHACH HÀNG</h4>
        <h4 style="color: red">${requestScope.tb}</h4>
        <form action="them" method="get">
            <table border ="0" align="center">
                <tr align="left">
                    <td>Mã :</td>
                    <td>
                        <input type="text" name="ma" value="${ma}"
                               placeholder="nhập mã KH" required />
                    </td>
                </tr>
                <tr align="left">
                    <td>Họ tên:</td>
                    <td>
                        <input type="text" name="hoten" value="${hoten}"
                               placeholder="nhập họ tên KH" required />
                    </td>
                </tr>

                <tr align="left">
                    <td>Số dt: </td>
                    <td>
                        <input type="text" name="dienthoai" value="${dienthoai}"
                               placeholder="nhập số dt" required=""/><br>
                    </td>
                </tr>
                <tr align="left">
                    <td>Địa chỉ: </td>
                    <td>
                        <input type="text" name="diachi" value="${diachi}"
                               placeholder="Nhập địa chỉ" required /><br>
                    </td>
                </tr>
                <tr align>
                    <td>Email: </td>
                    <td>
                        <input type="text" name="email" value="${email}"
                               placeholder="nhâp email" required /><br>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type="submit" value="Save" />
                    </td>
                </tr>

            </table>
        </form>
    </center>
</body>
</html>
