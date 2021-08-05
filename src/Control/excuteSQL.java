/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Control;

import Model.Lop;
import Model.SinhVien;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author 2XHQ
 */
public class excuteSQL {
    private ArrayList<SinhVien> dssv;
    private ArrayList<Lop> dslop = new ArrayList<>();
    private ConnectDB db= new ConnectDB();
    private String sql;

    public excuteSQL() {
        
    }
    
    public void selectDSLop(){
        db.getConnect();
        sql = "SELECT * FROM LOPHOC";
        dslop=db.getData(sql);
        
    }
    
    public void selectSV(){
        db.getConnect();
        sql = "SELECT * FROM SINHVIEN";
        dssv = db.getDataSV(sql);
    }
    
    public ArrayList<SinhVien> getDssv() {
        return dssv;
    }

    public void setDssv(ArrayList<SinhVien> dssv) {
        this.dssv = dssv;
    }

    public ArrayList<Lop> getDslop() {
        return dslop;
    }

    public void setDslop(ArrayList<Lop> dslop) {
        this.dslop = dslop;
    }
    
    public void deleteLop(String MaLop) throws Exception{
        String sql = "Delete from Lop where MALOP = '"+MaLop +"'";
        db.getConnect();
        db.doSQL(sql);
        db.closeConnect();
    }
    
    
    
    
}
