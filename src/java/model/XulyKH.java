package model;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.sql.Connection;

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

    //phương thức trả về 1 khách hàng theo mã
    public Khachhang getKhachhangByma(String ma) {
        String sql = "SELECT * FROM Khachhang WHERE ma= ?";
        Khachhang khach = null;
        try (Connection conn = getConnect(); PreparedStatement st = conn.prepareStatement(sql)) {
            st.setString(1, ma);//thiết lập giá trị cho tham số mã
            try (ResultSet rs = st.executeQuery()) {
                if (rs.next()) {
                    khach = new Khachhang(rs.getString("ma"),
                            rs.getString("hoten"),
                            rs.getString("dienthoai"),
                            rs.getString("diachi"),
                            rs.getString("email"));
                }
            }
        } catch (Exception ex) {
            ex.printStackTrace();//Ghi lại ngoại lệ
        }

        return khach;
    }
    
    //Xây dựng phương thức để thêm mới 1 khách hàng
    public void insert(Khachhang c){
        String sql ="insert into Khachhang values (?,?,?,?,?)";
        try{
            PreparedStatement st = getConnect().prepareStatement(sql);
            st.setString(1, c.getMa());
            st.setString(2, c.getHoten());
            st.setString(3, c.getDienthoai());
            st.setString(4, c.getDiachi());
            st.setString(5, c.getEmail());
            st.executeUpdate();
        }
        catch(Exception e){
            e.printStackTrace();
        }
    }
    
    //Xóa khách hàng
    public void delete (String ma){
        String sql ="delete from Khachhang where ma = ?";
        try {
            PreparedStatement st = getConnect().prepareStatement(sql);
            st.setString(1, ma);
            st.executeUpdate();
        } catch (Exception e) {
        }
    }
    
    //update theo mã truyền vào 
    public void update (Khachhang c){
        String sql ="update Khachhang set hoten=?,dienthoai=?,diachi=?,email=? where ma=?";
        try {
            PreparedStatement st =getConnect().prepareStatement(sql);
            st.setString(1, c.getHoten());
            st.setString(2, c.getDienthoai());
            st.setString(3, c.getDiachi());
            st.setString(4, c.getEmail());
            st.setString(5, c.getMa());
            st.executeUpdate();
        } catch (Exception e) {
        }
    }
    
    //tìm kiếm theo địa chỉ khách hàng
    public List<Khachhang> search (String diachi){
        String sql ="SELECT * FROM Khachhang WHERE diachi=?";
        Khachhang khach = null;
        List<Khachhang> list = new ArrayList<>();
        try {
            PreparedStatement st = getConnect().prepareStatement(sql);
            st.setString(1, diachi);//đặt địa chỉ vào câu truy vấn
            ResultSet rs =st.executeQuery();
            while (rs.next()) {                
                khach = new Khachhang(rs.getString("ma"),
                        rs.getString("hoten"),
                        rs.getString("dienthoai"),
                        rs.getString("diachi"),
                        rs.getString("email"));
                list.add(khach);
            }
        } catch (Exception e) {
        }
        return list;
    }

}
