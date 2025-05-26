package dao;

import model.KhachHang;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class KhachHangDAO {
    private String jdbcURL = "jdbc:mysql://localhost:3306/qlkh?useSSL=false&serverTimezone=UTC";
    private String jdbcUsername = "root";
    private String jdbcPassword = "";

    private Connection getConnection() throws SQLException {
        try {
            Class.forName("com.mysql.cj.jdbc.Driver"); // Load driver MySQL
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
            throw new SQLException("Không tìm thấy driver MySQL.");
        }
        return DriverManager.getConnection(jdbcURL, jdbcUsername, jdbcPassword);
    }

    public List<KhachHang> getAllKhachHang() throws SQLException {
        List<KhachHang> list = new ArrayList<>();
        String sql = "SELECT * FROM KhachHang";
        try (Connection conn = getConnection();
             PreparedStatement ps = conn.prepareStatement(sql);
             ResultSet rs = ps.executeQuery()) {

            while (rs.next()) {
                KhachHang kh = new KhachHang();
                kh.setMa(rs.getString("ma"));
                kh.setHoten(rs.getString("hoten"));
                kh.setDienthoai(rs.getString("dienthoai"));
                kh.setEmail(rs.getString("email"));
                list.add(kh);
            }
        }
        return list;
    }

    public KhachHang getById(String ma) throws SQLException {
        String sql = "SELECT * FROM KhachHang WHERE ma = ?";
        try (Connection conn = getConnection();
             PreparedStatement ps = conn.prepareStatement(sql)) {
            ps.setString(1, ma);
            try (ResultSet rs = ps.executeQuery()) {
                if (rs.next()) {
                    return new KhachHang(
                            rs.getString("ma"),
                            rs.getString("hoten"),
                            rs.getString("dienthoai"),
                            rs.getString("email"));
                }
            }
        }
        return null;
    }

    public void insert(KhachHang kh) throws SQLException {
        String sql = "INSERT INTO KhachHang(ma, hoten, dienthoai, email) VALUES (?, ?, ?, ?)";
        try (Connection conn = getConnection();
             PreparedStatement ps = conn.prepareStatement(sql)) {
            ps.setString(1, kh.getMa());
            ps.setString(2, kh.getHoten());
            ps.setString(3, kh.getDienthoai());
            ps.setString(4, kh.getEmail());
            ps.executeUpdate();
        }
    }

    public void update(KhachHang kh) throws SQLException {
        String sql = "UPDATE KhachHang SET hoten = ?, dienthoai = ?, email = ? WHERE ma = ?";
        try (Connection conn = getConnection();
             PreparedStatement ps = conn.prepareStatement(sql)) {
            ps.setString(1, kh.getHoten());
            ps.setString(2, kh.getDienthoai());
            ps.setString(3, kh.getEmail());
            ps.setString(4, kh.getMa());
            ps.executeUpdate();
        }
    }

    public void delete(String ma) throws SQLException {
        String sql = "DELETE FROM KhachHang WHERE ma = ?";
        try (Connection conn = getConnection();
             PreparedStatement ps = conn.prepareStatement(sql)) {
            ps.setString(1, ma);
            ps.executeUpdate();
        }
    }
}
