/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Model;

/**
 *
 * @author 2XHQ
 */
public class SinhVien {
    
    private int maNhom;
    private String maSV;
    private String hoSV;
    private String tenSV;
    private boolean nhomTruong;

    public SinhVien( String maSV,int maNhom, String hoSV, String tenSV, boolean nhomTruong) {
        
        this.maNhom = maNhom;
        this.maSV = maSV;
        this.hoSV = hoSV;
        this.tenSV = tenSV;
        this.nhomTruong = nhomTruong;
    }




    public SinhVien() {
        nhomTruong = false;
        maNhom = -1;
    }


    public int getMaNhom() {
        return maNhom;
    }

    public void setMaNhom(int maNhom) {
        this.maNhom = maNhom;
    }

    public String getMaSV() {
        return maSV;
    }

    public void setMaSV(String maSV) {
        this.maSV = maSV;
    }

    public String getHoSV() {
        return hoSV;
    }

    public void setHoSV(String hoSV) {
        this.hoSV = hoSV;
    }

    public String getTenSV() {
        return tenSV;
    }

    public void setTenSV(String tenSV) {
        this.tenSV = tenSV;
    }

    public boolean isNhomTruong() {
        return nhomTruong;
    }

    public void setNhomTruong(boolean nhomTruong) {
        this.nhomTruong = nhomTruong;
    }

    @Override
    public String toString() {
        return "SinhVien{" + "maNhom=" + maNhom + ", maSV=" + maSV + ", hoSV=" + hoSV + ", tenSV=" + tenSV + ", nhomTruong=" + nhomTruong + '}';
    }

    
    
    
}
