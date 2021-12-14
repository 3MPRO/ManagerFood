using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace foodmanager.Model
{
    class Hang
    {
        FileXML Fxml = new FileXML();
        public bool kiemtraMaHang(string MaHang)
        {
            XmlTextReader reader = new XmlTextReader("Hang.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/Hang[MaHang='" + MaHang + "']");
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
        public void themH(string MaHang, string TenHang, string DonViTinh, string DonGia, string SoLuong, string MaNCC)
        {
            string noiDung = "<Hang>" +
                    "<MaHang>" + MaHang + "</MaHang>" +
                    "<TenHang>" + TenHang + "</TenHang>" +
                    "<DonViTinh>" + DonViTinh + "</DonViTinh>" +
                    "<DonGia>" + DonGia + "</DonGia>" +
                    "<SoLuong>" + SoLuong + "</SoLuong>" +
                    "<MaNCC>" + MaNCC + "</MaNCC>" +
                    "</Hang>";
            Fxml.Them("Hang.xml", noiDung);
        }
        public void suaH(string MaHang, string TenHang, string DonViTinh, string DonGia, string SoLuong, string MaNCC)
        {

            string noiDung = "<MaHang>" + MaHang + "</MaHang>" +
                    "<TenHang>" + TenHang + "</TenHang>" +
                    "<DonViTinh>" + DonViTinh + "</DonViTinh>" +
                    "<DonGia>" + DonGia + "</DonGia>" +
                    "<SoLuong>" + SoLuong + "</SoLuong>" +
                    "<MaNCC>" + MaNCC + "</MaNCC>";

            Fxml.Sua("Hang.xml", "Hang", "MaHang", MaHang, noiDung);

        }
        public void xoaH(string MaHang)
        {
            Fxml.Xoa("Hang.xml", "Hang", "MaHang", MaHang);
        }

    }
}
