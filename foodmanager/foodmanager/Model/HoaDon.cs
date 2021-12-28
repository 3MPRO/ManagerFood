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

        public bool kiemtraSHD(string SoHD)
        {
            XmlTextReader reader = new XmlTextReader("HoaDon.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_HoaDon_x0027_[SoHoaDon='" + SoHD + "']");
            reader.Close();
            bool kq = true;
            if (node != null)
            {
                return kq = true;
            }
            else
            {
                return kq = false;

            }

        }

        public void themHD(string MaNV, string NgayLap, string TongTien)
        {
            string noiDung = "<_x0027_HoaDon_x0027_>" +
                    /*"<SoHoaDon>" + SoHD + "</SoHoaDon>" +*/
                    "<MaNhanVien>" + MaNV + "</TenHang>" +
                    "<NgayLap>" + NgayLap + "</DonViTinh>" +
                    "<TongTien>" + TongTien + "</DonGia>" +
                    "</_x0027_HoaDon_x0027_>";
            Fxml.Them("HoaDon.xml", noiDung);
        }
        public void suaHD(string SoHD, string MaNV, string NgayLap, string TongTien)
        {

            string noiDung = "<_x0027_HoaDon_x0027_>" +
                    "<SoHoaDon>" + SoHD + "</SoHoaDon>" +
                    "<MaNhanVien>" + MaNV + "</MaNhanVien>" +
                    "<NgayLap>" + NgayLap + "</NgayLap>" +
                    "<TongTien>" + TongTien + "</TongTien>";

            Fxml.Sua("HoaDon.xml", "_x0027_HoaDon_x0027_", "SoHoaDon", SoHD, noiDung);

        }
        public void xoaH(string SoHD)
        {
            Fxml.Xoa("HoaDon.xml", "_x0027_HoaDon_x0027_", "SoHoaDon", SoHD);
        }

        public DataTable LoadIDHoaDon()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("HoaDon.xml");
            return dt;
        }
    }
}
