package model;

public class KhachHang {
    private String ma;
    private String hoten;
    private String dienthoai;
    private String email;

    public KhachHang() {
    }

    public KhachHang(String ma, String hoten, String dienthoai, String email) {
        this.ma = ma;
        this.hoten = hoten;
        this.dienthoai = dienthoai;
        this.email = email;
    }

    // getter và setter
    public String getMa() {
        return ma;
    }
    public void setMa(String ma) {
        this.ma = ma;
    }
    public String getHoten() {
        return hoten;
    }
    public void setHoten(String hoten) {
        this.hoten = hoten;
    }
    public String getDienthoai() {
        return dienthoai;
    }
    public void setDienthoai(String dienthoai) {
        this.dienthoai = dienthoai;
    }
    public String getEmail() {
        return email;
    }
    public void setEmail(String email) {
        this.email = email;
    }
}
