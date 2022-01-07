using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.Xml.Linq;
using System.Windows.Forms;

namespace foodmanager.Model
{
    class HoaDon
    {
        FileXML Fxml = new FileXML();
        

        public void themHD(string MaNV, string NgayLap, string TongTien, string MaHang, string DonGia, string SoLuong)
        {
            XDocument xDoc = XDocument.Load("GioHang.xml");
            int i = 1;
            foreach (XElement x in xDoc.Descendants("_x0027_GioHang_x0027_"))
            {
                x.SetElementValue("Id",i++);

            }

            string noiDung = "<_x0027_GioHang_x0027_>" +
                "<Id>" + i + "</Id>" +
                "<MaHang>" + MaHang + "</MaHang>" +
                "<DonGia>" + DonGia + "</DonGia>" +
                "<SoLuong>" + SoLuong + "</SoLuong>" +
                "<MaNhanVien>" + MaNV + "</MaNhanVien>" +
                "<NgayLap>" + NgayLap + "</NgayLap>" +
                "<TongTien>" + TongTien + "</TongTien>" +
                "</_x0027_GioHang_x0027_>";
            Fxml.Them("GioHang.xml", noiDung);
        }
        
        public void xoaH(string MaHang)
        {
            Fxml.Xoa("GioHang.xml", "_x0027_GioHang_x0027_", "MaHang", MaHang);
        }

        public DataTable LoadIDHoaDon()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("GioHang.xml");
            return dt;
        }

        class Product
        {
            public string MaNV { get; set; }
            public string NgayLap { get; set; }
            public string TongTien { get; set; }
            public string MaHang { get; set; }
            public string DonGia { get; set; }
            public string SoLuong { get; set; }

        }

        public void thanhtoan()
        {
            XElement xDoc = XElement.Load("GioHang.xml");
            List<Product> products = (from q in xDoc.Elements("_x0027_GioHang_x0027_")
                                      select new Product
                                      {
                                          MaNV = q.Element("MaNhanVien").Value,
                                          NgayLap = q.Element("NgayLap").Value,
                                          TongTien = q.Element("TongTien").Value,
                                          MaHang = q.Element("MaHang").Value,
                                          DonGia = q.Element("DonGia").Value,
                                          SoLuong = q.Element("SoLuong").Value

                                      }).ToList();
            XmlDocument document = new XmlDocument();
            document.Load("HoaDon.xml");
            XmlNodeList list = document.GetElementsByTagName("SoHoaDon");
            int sohd = list.Count;
            sohd++;
            string noiDung = "<_x0027_HoaDon_x0027_>" +
                "<SoHoaDon>" + sohd + "</SoHoaDon>" +
                "<MaNhanVien>" + products[0].MaNV + "</MaNhanVien>" +
                "<NgayLap>" + products[0].NgayLap + "</NgayLap>" +
                "<TongTien>" + products[0].TongTien + "</TongTien>" +
                "</_x0027_HoaDon_x0027_>";
            Fxml.Them("HoaDon.xml", noiDung);

            XmlDocument document1 = new XmlDocument();
            document1.Load("ChiTietHoaDon.xml");
            XmlNodeList list1 = document1.GetElementsByTagName("Id");
            int idct = list1.Count;

            foreach (Product p in products)
            {

                idct++;
                string noiDung1 = "<_x0027_ChiTietHoaDon_x0027_>" +
                        "<Id>" + idct + "</Id>" +
                        "<MaHang>" + p.MaHang + "</MaHang>" +
                        "<SoHoaDon>" + sohd + "</SoHoaDon>" +
                        "<DonGia>" + p.DonGia + "</DonGia>" +
                        "<SoLuong>" + p.SoLuong + "</SoLuong>" +
                        "</_x0027_ChiTietHoaDon_x0027_>";
                Fxml.Them("ChiTietHoaDon.xml", noiDung1);
            }
            XDocument xDoc5 = XDocument.Load("GioHang.xml");
            XmlDocument document2 = new XmlDocument();
            document2.Load("GioHang.xml");
            XmlNodeList list5 = document2.GetElementsByTagName("Id");
            int idgh = list5.Count;
            for(int j=1;j<=idgh; j++)
            {
                foreach (XElement i in xDoc5.Descendants("NewDataSet"))
                {
                    i.Element("_x0027_GioHang_x0027_").Remove();
                    xDoc5.Save("GioHang.xml");
                }
            }
            
            
        }
    }
}
