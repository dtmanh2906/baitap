package controller;

import dao.KhachHangDAO;
import jakarta.servlet.*;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.*;

import java.io.IOException;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

@WebServlet("/xoaKhach")
public class XoaKhachServlet extends HttpServlet {
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
        if (ma != null && !ma.isEmpty()) {
            try {
                dao.delete(ma);
            } catch (SQLException e) {
                Logger.getLogger(XoaKhachServlet.class.getName()).log(Level.SEVERE, null, e);
            }
        }
        response.sendRedirect("khachhang");
    }
}
