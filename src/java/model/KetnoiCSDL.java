package model;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.logging.Level;
import java.util.logging.Logger;

public class KetnoiCSDL {
    public Connection getConnect() { // Đổi tên từ getConection -> getConnect
        String url = "jdbc:mysql://localhost:3306/qlkh"; // Tên CSDL là "qlkh"
        String user = "root";
        String pass = "";

        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            return DriverManager.getConnection(url, user, pass);
        } catch (Exception ex) {
            Logger.getLogger(KetnoiCSDL.class.getName()).log(Level.SEVERE, null, ex);
        }

        return null;
    }
}
