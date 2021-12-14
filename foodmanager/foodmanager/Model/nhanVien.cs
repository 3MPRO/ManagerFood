using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace foodmanager.Model
{
    class nhanVien
    {
        FileXML Fxml = new FileXML();
        public bool checkMaNV(string MaNhanVien)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/NhanVien[MaNhanVien='" + MaNhanVien + "']");
            reader.Close();

            if (node != null)
            {
                return true;
            }
            else
            {
                return false;

            }

        }

        public void addNhanVien(string MaNV, string TenNV, string DiaChi, string SDT, string Email, string NgaySinh)
        {
            string noiDung = "<NhanVien>" +
                    "<MaNhanVien>" + MaNV + "</MaNhanVien>" +
                    "<TenNhanVien>" + TenNV + "</TenNhanVien>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                    "</NhanVien>";
            Fxml.Them("NhanVien.xml", noiDung);
        }
        public void suaNhanVien(String MaNhanVien, string TenNV, string DiaChi, string SDT, string Email, string NgaySinh)
        {
            string noiDung =
                    "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>"+
                    "<TenNhanVien>" + TenNV + "</TenNhanVien>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    "<NgaySinh>" + NgaySinh + "</NgaySinh>";
            Fxml.Sua("NhaCungCap.xml", "NhanVien", "MaNhanVien", MaNhanVien, noiDung);
        }

        public void xoaNhanVien(string MaNhanVien)
        {
            Fxml.Xoa("NhanVien.xml", "NhanVien", "MaNhanVien", MaNhanVien);
        }

        public DataTable LoadNhanVien()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("NhanVien.xml");
            return dt;
        }

        public DataTable LoadTable()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("NhaCungCap.xml");
            DataTable dtNCC = new DataTable(); ;
            dtNCC = LoadNhanVien();
            int soDong = LoadNhanVien().Rows.Count;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < soDong; j++)
                {
                    if (dt.Rows[i]["MaNhanVien"].ToString().Equals(dtNCC.Rows[j]["MaNhanVien"].ToString()))
                    {
                        dt.Rows[i]["MaNhanVien"] = dtNCC.Rows[j]["TenNhanVien"];
                    }
                }
            }

            return dt;
        }
    }
}
