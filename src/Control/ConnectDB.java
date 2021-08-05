/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Control;


import Model.Lop;
import Model.SinhVien;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import javax.swing.JOptionPane;
/**
 *
 * @author 2XHQ
 */
public class ConnectDB {
    Statement  stm = null;
    ResultSet rs = null;
    Connection cnn = null;
   
    private String uRl = "jdbc:derby://localhost:1527/BTL";//;create=true";
    private String userName = "administrator";
    private String pas = "123456";
    
    public void getConnect(){
        try {         
           //org.apache.derby.jdbc.ClientDriver
            Class.forName("org.apache.derby.jdbc.ClientDriver").newInstance();
            cnn = DriverManager.getConnection(uRl, userName,pas);    
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null,"Khong the ket noi voi database \n"+ex);
        }
    }
    
     public void doSQL(String sql) throws Exception  {
        try {
            stm = cnn.createStatement();
            stm.execute(sql);
        } catch (SQLException ex) {
            throw new Exception("Cau lenh Query khong duoc thuc thi" + ex);
        }
     }
          
         public ArrayList getData(String sql)  {
        ArrayList<Lop> ds = new ArrayList<Lop>();
        try {
            
                stm = cnn.createStatement();
                rs = stm.executeQuery(sql);
                while (rs.next()) {
                    Lop lop = new Lop(rs.getString(1),rs.getString(2),rs.getString(3),rs.getString(4),rs.getInt(5));
                    ds.add(lop);
                }                   
           } catch (Exception ex) {           
            JOptionPane.showMessageDialog(null,"Loi lay du lieu tu bang \n"+ex);
            return null;
        }
        return ds;
      }
        public ArrayList getDataSV(String sql)  {
        ArrayList<SinhVien> dsSV = new ArrayList<SinhVien>();
        try {
           
                stm = cnn.createStatement();
                rs = stm.executeQuery(sql);
                
                while (rs.next()) {
                    SinhVien sv = new SinhVien(rs.getString("MASV"),rs.getInt("MANHOM"),rs.getString("HOSV"),rs.getString("TENSV"),rs.getBoolean("NHOMTRUONG"));
                    dsSV.add(sv);
                }                   
                
        } catch (Exception ex) {           
            JOptionPane.showMessageDialog(null,"Loi lay du lieu tu bang \n"+ex);
            return null;
        }
        return dsSV;
      }
            
       
    public void closeConnect() throws SQLException
    {
        //dong tu nho den lon
        if(this.rs!=null&&!this.rs.isClosed())
        try{
            this.rs.close();
            this.rs=null;
        }catch(SQLException e)
        {
            JOptionPane.showMessageDialog(null, "Loi dong ket qua");
        }
        
        if(this.stm!=null&&!this.stm.isClosed())
        try{
            this.stm.close();
            this.stm=null;
        }catch(SQLException e)
        {
            JOptionPane.showMessageDialog(null, "Loi dong lenh thuc thi");
        }
        
        if(this.cnn!=null&&!this.cnn.isClosed())
        try{
            this.cnn.close();
            this.cnn=null;
        }catch(SQLException e)
        {
            JOptionPane.showMessageDialog(null, "Loi dong ket noi");
        }
        
    }
}  

    
    

