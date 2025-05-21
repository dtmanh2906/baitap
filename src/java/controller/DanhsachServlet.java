package controller;

import java.io.IOException;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.util.List;
import model.Khachhang;
import model.XulyKH;

@WebServlet(name = "DanhsachServlet", urlPatterns = {"/ds"})
public class DanhsachServlet extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        XulyKH d = new XulyKH();
        List<Khachhang> ds = d.getAllKhachhang();

        // Gửi danh sách khách hàng sang file JSP
        request.setAttribute("data", ds);
        request.getRequestDispatcher("danhsach.jsp").forward(request, response);
    }
}
