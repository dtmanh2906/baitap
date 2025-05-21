package model;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class XulyKH extends KetnoiCSDL {

    // Đọc dữ liệu từ bảng Khachhang và lưu thông tin vào danh sách
    public List<Khachhang> getAllKhachhang() {
        List<Khachhang> list = new ArrayList<>();
        String sql = "SELECT * FROM Khachhang";

        try {
            PreparedStatement st = getConnect().prepareStatement(sql);
            // PreparedStatement là interface con của Statement, dùng để thực thi câu lệnh SQL tham số hóa

            ResultSet rs = st.executeQuery(); // Thực thi câu truy vấn

            while (rs.next()) {
                Khachhang khach = new Khachhang(
                    rs.getString("ma"),
                    rs.getString("hoten"),
                    rs.getString("dienthoai"),
                    rs.getString("diachi"),
                    rs.getString("email")
                );
                list.add(khach); // Thêm khách hàng vào danh sách
            }

            rs.close();
            st.close();
        } catch (SQLException e) {
            e.printStackTrace(); // Ghi log lỗi
        }

        return list; // Trả về danh sách khách hàng
    }

}
