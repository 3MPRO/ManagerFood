using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;

namespace foodmanager.Model
{
    class HoaDon
    {
        FileXML Fxml = new FileXML();

        public void themHD(string MaNV, string NgayLap, string TongTien, string MaHang, string DonGia, string SoLuong)
        {
            string noiDung = "<_x0027_HoaDon_x0027_>" +
                    /*"<SoHoaDon>" + SoHD + "</SoHoaDon>" +*/
                    "<MaNhanVien>" + MaNV + "</MaNhanVien>" +
                    "<NgayLap>" + NgayLap + "</NgayLap>" +
                    "<TongTien>" + TongTien + "</TongTien>" +
                    "</_x0027_HoaDon_x0027_>";
            Fxml.Them("HoaDon.xml", noiDung);
            string noiDung1 = "<_x0027_ChiTietHoaDon_x0027_>" +
                    /*"<Id>" + Id + "</Id>" +*/
                    "<MaHang>" + MaHang + "</MaHang>" +
                    /*"<SoHoaDon>" + SoHoaDon + "</SoHoaDon>" +*/
                    "<DonGia>" + DonGia + "</DonGia>" +
                    "<SoLuong>" + SoLuong + "</SoLuong>" +
                    "</_x0027_ChiTietHoaDon_x0027_>";
            Fxml.Them("ChiTietHoaDon.xml", noiDung1);
        }
        
        public void xoaH(string SoHD)
        {
            Fxml.Xoa("HoaDon.xml", "_x0027_HoaDon_x0027_", "SoHoaDon", SoHD);
            Fxml.Xoa("HoaDon.xml", "_x0027_ChiTietHoaDon_x0027_", "SoHoaDon", SoHD);
        }

        public DataTable LoadIDHoaDon()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("HoaDon.xml");
            return dt;
        }
    }
}
