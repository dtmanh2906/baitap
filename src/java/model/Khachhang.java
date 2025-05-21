package model;
public class Khachhang {
    private String ma;
    private String hoten;
    private String dienthoai;
    private String diachi;
    private String email;

    public Khachhang() {
    }

    public Khachhang(String ma, String hoten, String dienthoai, String diachi, String email) {
        this.ma = ma;
        this.hoten = hoten;
        this.dienthoai = dienthoai;
        this.diachi = diachi;
        this.email = email;
    }

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

    public String getDiachi() {
        return diachi;
    }

    public void setDiachi(String diachi) {
        this.diachi = diachi;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
    
    
}