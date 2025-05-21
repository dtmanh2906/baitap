package model;

import java.util.List;

public class test {
    public static void main(String[] args) {
        XulyKH d = new XulyKH(); // Tạo đối tượng xử lý khách hàng
        List<Khachhang> list = d.getAllKhachhang(); // Lấy danh sách khách hàng

        System.out.println("Thông tin trong bảng khách hàng gồm:");
        System.out.printf("%-10s %-20s %-15s %-30s %-30s\n", "Mã KH", "Họ tên", "SĐT", "Địa chỉ", "Email");

        for (Khachhang a : list) {
            System.out.printf("%-10s %-20s %-15s %-30s %-30s\n",
                a.getMa(),
                a.getHoten(),
                a.getDienthoai(),
                a.getDiachi(),
                a.getEmail()
            );
        }
    }
}
