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

@WebServlet("/suaKhach")
public class SuaKhachServlet extends HttpServlet {
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
        String ma = request.getParameter("ma");
        if (ma == null || ma.isEmpty()) {
            response.sendRedirect("khachhang");
            return;
        }
        try {
            KhachHang kh = dao.getById(ma);
            if (kh == null) {
                response.sendError(HttpServletResponse.SC_NOT_FOUND, "Không tìm thấy khách hàng");
                return;
            }
            request.setAttribute("khachhang", kh);
            request.getRequestDispatcher("suaKhach.jsp").forward(request, response);
        } catch (SQLException e) {
            Logger.getLogger(SuaKhachServlet.class.getName()).log(Level.SEVERE, null, e);
            response.sendError(500, "Lỗi khi lấy thông tin khách hàng");
        }
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String ma = request.getParameter("ma");
        String ten = request.getParameter("hoten");
        String dt = request.getParameter("dienthoai");
        String email = request.getParameter("email");

        KhachHang kh = new KhachHang(ma, ten, dt, email);

        try {
            dao.update(kh);
            response.sendRedirect("khachhang");
        } catch (SQLException e) {
            Logger.getLogger(SuaKhachServlet.class.getName()).log(Level.SEVERE, null, e);
            request.setAttribute("errorMessage", "Lỗi cập nhật khách hàng");
            request.setAttribute("khachhang", kh);
            request.getRequestDispatcher("suaKhach.jsp").forward(request, response);
        }
    }
}
