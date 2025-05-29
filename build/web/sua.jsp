<%-- 
    Document   : sua
    Created on : May 29, 2025, 1:32:34 PM
    Author     : dinht
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Quản lý khách hàng</title>
    </head>
    <body>
    <center>
        <h2>SỬA THÔNG TIN KHÁCH HÀNG</h2>
        <!<!-- lấy thông tin từ servlset truyền sang jsp thông qua biến "kh" bằng câu lệnh requestScope -->
        <c:set var ="kh" value="${requestScope.data}" />
        <form action="update" method="post">
            <table border="0" align="center">
                <tr align="left">
                    <td>Mã: </td>
                    <td>
                        <input type="text" readonly name="ma" value="${kh.ma}" />
                    </td>
                </tr>
                <tr align="left">
                    <td>Họ tên: </td>
                    <td>
                        <input type="text" name="hoten" value="${kh.hoten}" />
                    </td>
                </tr>
                <tr align="left">
                    <td>Số điện thoại: </td>
                    <td>
                        <input type="text" name="dienthoai" value="${kh.dienthoai}" />
                    </td>
                </tr>
                <tr align="left">
                    <td>Địa chỉ:</td>
                    <td>
                        <input type="text" name="diachi" value="${kh.diachi}" />
                    </td>
                </tr>
                <tr align="left">
                    <td>Email : </td>
                    <td>
                        <input type="text" name="email" value="${kh.email}"
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type="submit" value="update" />
                    </td>
                </tr>
            </table>
        </form>
    </center>
    </body>
</html>
