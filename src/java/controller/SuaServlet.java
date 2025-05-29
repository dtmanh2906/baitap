/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package controller;

import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import model.Khachhang;
import model.XulyKH;

/**
 *
 * @author dinht
 */
@WebServlet(name = "SuaServlet", urlPatterns = {"/update"})
public class SuaServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet SuaServlet</title>");            
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet SuaServlet at " + request.getContextPath() + "</h1>");
            out.println("</body>");
            out.println("</html>");
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        //lấy dữ liệu từ form 
        String m=request.getParameter("ma");
        XulyKH d=new XulyKH();
        Khachhang c = d.getKhachhangByma(m);
        //truyền dữ liệu trong c cho bên nhận là file .jsp thông qua biến data
        request.setAttribute("data", c);
        request.getRequestDispatcher("sua.jsp").forward(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        //lấy dữ liệu từ form
        String m=request.getParameter("ma");
        String ht=request.getParameter("hoten");
        String dt=request.getParameter("dienthoai");
        String dc=request.getParameter("diachi");
        String em=request.getParameter("email");
        XulyKH d= new XulyKH();
        //lưu thong tin sửa chữa vào 1 khách hàng mới 
        Khachhang kh=new Khachhang(m, ht, dt, dc, em);
        d.update(kh);//gọi phương thức update trong xulykh
        response.sendRedirect("ds");
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
