package controller;

import dao.KhachHangDAO;
import model.KhachHang;

import jakarta.servlet.*;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.*;
import java.io.IOException;
import java.sql.SQLException;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

@WebServlet("/danhSach")
public class KhachHangServlet extends HttpServlet {
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
        try {
            List<KhachHang> danhSach = dao.getAllKhachHang();
            request.setAttribute("dskhachhang", danhSach);
            request.getRequestDispatcher("danhSach.jsp").forward(request, response);
        } catch (SQLException e) {
            Logger.getLogger(KhachHangServlet.class.getName()).log(Level.SEVERE, null, e);
            response.sendError(500, "Lỗi khi lấy danh sách khách hàng");
        }
    }
}
