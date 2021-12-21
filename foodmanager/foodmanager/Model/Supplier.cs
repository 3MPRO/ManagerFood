using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace foodmanager.Model
{
    class Supplier
    {
        FileXML Fxml = new FileXML();
        public bool checkIdSupplier(string MaNCC)
        {
            XmlTextReader reader = new XmlTextReader("NhaCungCap.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_NhaCungCap_x0027_[MaNCC='" + MaNCC + "']");
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
        public void addSupplier(string MaNCC, string TenNCC, string DiaChi, string SDT, string Email, string MoTa)
        {
            string noiDung = "<_x0027_NhaCungCap_x0027_>" +
                    "<MaNCC>" + MaNCC + "</MaNCC>" +
                    "<TenNCC>" + TenNCC + "</TenNCC>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    "<MoTa>" + MoTa + "</MoTa>" +
                    "</_x0027_NhaCungCap_x0027_>";
            Fxml.Them("NhaCungCap.xml", noiDung);
        }
        public void updateSuplier(string MaNCC, string TenNCC, string DiaChi, string SDT, string Email, string MoTa)
        {

            string noiDung = "<MaNCC>" + MaNCC + "</MaNCC>" +
                    "<TenNCC>" + TenNCC + "</TenNCC>" +
                    "<DiaChi>" + DiaChi + "</DiaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<Email>" + Email + "</Email>" +
                    "<MoTa>" + MoTa + "</MoTa>";

            Fxml.Sua("NhaCungCap.xml", "_x0027_NhaCungCap_x0027_", "MaNCC", MaNCC, noiDung);

        }
        public void deleteSupplier(string MaNCC)
        {
            Fxml.Xoa("NhaCungCap.xml", "_x0027_NhaCungCap_x0027_", "MaNCC", MaNCC);
        }
        public DataTable LoadIdSupplier()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("NhaCungCap.xml");
            return dt;
        }
        public DataTable LoadTable()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("NhaCungCap.xml");
            DataTable dtNCC = new DataTable(); ;
            dtNCC = LoadIdSupplier();
            int soDong = LoadIdSupplier().Rows.Count;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < soDong; j++)
                {
                    if (dt.Rows[i]["MaNCC"].ToString().Equals(dtNCC.Rows[j]["MaNCC"].ToString()))
                    {
                        dt.Rows[i]["MaNCC"] = dtNCC.Rows[j]["TenNCC"];
                    }
                }
            }

            return dt;
        }
    }
}
