package controller;

import dao.KhachHangDAO;
import model.KhachHang;

import jakarta.servlet.*;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.*;

import java.io.IOException;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

@WebServlet("/themKhach")
public class ThemKhachServlet extends HttpServlet {
    private KhachHangDAO dao;

    @Override
    public void init() throws ServletException {
        try {
            dao = new KhachHangDAO();
        } catch (Exception e) {
            throw new ServletException(e);
        }
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        request.getRequestDispatcher("themKhach.jsp").forward(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String ma = request.getParameter("ma");
        String ten = request.getParameter("hoten");
        String dt = request.getParameter("dienthoai");
        String email = request.getParameter("email");

        KhachHang kh = new KhachHang(ma, ten, dt, email);

        try {
            dao.insert(kh);
            response.sendRedirect("khachhang");
        } catch (SQLException e) {
            Logger.getLogger(ThemKhachServlet.class.getName()).log(Level.SEVERE, null, e);
            request.setAttribute("errorMessage", "Lỗi thêm khách hàng");
            request.getRequestDispatcher("themKhach.jsp").forward(request, response);
        }
    }
}
