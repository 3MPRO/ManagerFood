using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace foodmanager.Model
{
    internal class Import
    {
        FileXML Fxml = new FileXML();
        public bool kiemtraMaPhieu(string MaPhieu)
        {
            XmlTextReader reader = new XmlTextReader("PhieuNhap.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_PhieuNhap_x0027_[MaPhieu='" + MaPhieu + "']");
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
        public void themPN(string MaPhieu, string MaHang, string MaNhanVien, string SoLuong, string NgayLap)
        {
            string noiDung = "<_x0027_PhieuNhap_x0027_>" +
                    "<MaPhieu>" + MaPhieu + "</MaPhieu>" +
                    "<MaHang>" + MaHang + "</MaHang>" +
                    "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                    "<SoLuongNhap>" + SoLuong + "</SoLuongNhap>" +
                    "<NgayLapPhieu>" + NgayLap + "</NgayLapPhieu>" +
                    "</_x0027_PhieuNhap_x0027_>";
            Fxml.Them("PhieuNhap.xml", noiDung);
        }

    }

}
