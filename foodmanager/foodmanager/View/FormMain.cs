using foodmanager.Controller;
using foodmanager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace foodmanager.View
{
    public partial class FormMain : Form
    {
        FileXML Fxml = new FileXML();
        Main M = new Main();
        HeThong HT = new HeThong();
        XDocument xPhieuNhap, xHang, xNhanVien;
        public FormMain()
        {
            InitializeComponent();
        }

        public static string tenDNMain = "";
        public void QuyenDangNhap(bool e)
        {
            lblHoTen.Visible = e;
            /*lblQuyen.Visible = e;
            */
            đăngNhậpToolStripMenuItem.Enabled = !e;
            if (tenDNMain.Equals("admin"))
            {
                lblHoTen.Visible = e;
                /*lblQuyen.Visible = e;
                */
                đổiMậtKhẩuToolStripMenuItem.Enabled = e;
                /*lblQuyen.Text = "Administrutor";*/
            }
            else
            {
                button3.Visible = false;
                pictureBox3.Visible = false;
                button4.Visible = false;
                pictureBox5.Visible = false;
                button5.Visible = false;
                pictureBox6.Visible = false;
                btnNhanVien.Visible = false;
                PictureBox4.Visible = false;
                button6.Visible = false;
                pictureBox7.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                chuyểnĐổiToolStripMenuItem.Visible = false;
            }
            if (e) ThongTinDangNhap();
        }

        void ThongTinDangNhap()
        {
            lblHoTen.Text = M.HoTen(tenDNMain);
        }

        private bool CheckForm(string nameForm)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == nameForm)
                {
                    check = true;
                    break;
                }
            }
            return check;

        }

        private void ActivateForm(string nameForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == nameForm)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //IsMdiContainer = true;
            if (!CheckForm("FormDangNhap"))
            {
                FormDangNhap frm = new FormDangNhap();
                //frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActivateForm("FormDangNhap");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuyenDangNhap(false);
            tenDNMain = "";
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            FormDangNhap frm = new FormDangNhap();
            this.Hide();
            lblHoTen.Text = "";
            /*
            lblQuyen.Text = "";*/
            frm.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frm = new FormDoiMatKhau();
            frm.ShowDialog();
        }

        private void menuSupplier_Click(object sender, EventArgs e)
        {
            
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }

        private void quảnLýHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHang frm = new FormHang();
            frm.ShowDialog(); 
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
           
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            FormHang frm = new FormHang();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormImport formImport = new FormImport();
            formImport.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTaiKhoanNV frm = new FormTaiKhoanNV();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormXacNhanDiLam frm = new FormXacNhanDiLam();
            frm.ShowDialog();
        }

        private void chuyểnĐổiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void từSQLXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HT.TaoXML();
                MessageBox.Show("Tạo XML thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void từXMLSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HT.CapNhapSQL();
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void đăngNhâpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBanHang_Click(object sender, EventArgs e)
        {
            FormBanHang frm = new FormBanHang();
            frm.ShowDialog();
        }

        private void thốngKêNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportNCC frm = new FormReportNCC();
            frm.ShowDialog();
        }

        private void thoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportNV frm = new FormReportNV();
            frm.ShowDialog();
        }

        private void thốngKêThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportHang frm = new FormReportHang();
            frm.ShowDialog();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportHoaDon frm = new FormReportHoaDon();
            frm.ShowDialog();
        }
        void chuyendoihang()
        {
            string pathHTML = "Hang.html";
            xNhanVien = XDocument.Load("Hang.xml");

            var xI = xNhanVien.Descendants("_x0027_Hang_x0027_");
            var html = new XElement("html",
            new XElement("head",
            new XElement("style", "h2{color: #44d13b;}", "table{border:solid 1px #44d13b;border-collapse:collapse}", "td{border:solid 1px silver; padding:10px;}", "tr:first-child{border:solid 1px silver; background-color:#44d13b;color:#fff;}"

         )
         ),
         new XElement("body",
             new XElement("h2", "Danh sách"),
             new XElement("table",
             new XElement("tr",
                 new XElement("td", "Mã hàng"),
                 new XElement("td", "Tên hàng"),
                 new XElement("td", "Đơn vị tính"),
                 new XElement("td", "Đơn giá"),
                 new XElement("td", "Số lượng"),
                 new XElement("td", "Mã NCC")
         ),
        from el in xI
        select new XElement("tr",
            new XElement("td", el.Element("MaHang").Value),
            new XElement("td", el.Element("TenHang").Value),
            new XElement("td", el.Element("DonViTinh").Value),
            new XElement("td", el.Element("DonGia").Value),
            new XElement("td", el.Element("SoLuong").Value),
            new XElement("td",
                new XElement("style", "text-align:right"),
                el.Element("MaNCC").Value)
        )
         )
         )
         );
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }
        private void danhSáchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuyendoihang();
        }

        void chuyendoincc()
        {
            string pathHTML = "NhaCungCap.html";
            xNhanVien = XDocument.Load("NhaCungCap.xml");

            var xI = xNhanVien.Descendants("_x0027_NhaCungCap_x0027_");
            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
            new XElement("style", "h2{color: #44d13b;}", "table{border:solid 1px #44d13b;border-collapse:collapse}", "td{border:solid 1px silver; padding:10px;}", "tr:first-child{border:solid 1px silver; background-color:#44d13b;color:#fff;}"
         // Hãy thêm nhiều style nữa ở đây.
         ) // End of style
         ), // End of head
         new XElement("body",
             new XElement("h2", "Danh sách"),
             new XElement("table",
             new XElement("tr",
                 new XElement("td", "Mã nhà cung cấp"),
                 new XElement("td", "Tên nhà cung cấp"),
                 new XElement("td", "Địa chỉ"),
                 new XElement("td", "SDT"),
                 new XElement("td", "Email"),
                 new XElement("td", "Mô tả")
         ), // End of tr of table header
        from el in xI
        select new XElement("tr",
            new XElement("td", el.Element("MaNCC").Value),
            new XElement("td", el.Element("TenNCC").Value),
            new XElement("td", el.Element("DiaChi").Value),
            new XElement("td", el.Element("SDT").Value),
            new XElement("td", el.Element("Email").Value),
            new XElement("td",
                new XElement("style", "text-align:right"),
                el.Element("MoTa").Value)
        ) // End of tr
         ) // End of table
         ) // End of body
         ); // End of html
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuyendoincc();
        }

        void chuyendoinv()
        {
            string pathHTML = "NhanVien.html";
            xNhanVien = XDocument.Load("NhanVien.xml");

            var xI = xNhanVien.Descendants("_x0027_NhanVien_x0027_");
            var html = new XElement("html", // Tạo cây HTML trong bộ nhớ
            new XElement("head",
            new XElement("style", "h2{color: #44d13b;}", "table{border:solid 1px #44d13b;border-collapse:collapse}", "td{border:solid 1px silver; padding:10px;}", "tr:first-child{border:solid 1px silver; background-color:#44d13b;color:#fff;}"
         // Hãy thêm nhiều style nữa ở đây.
         ) // End of style
         ), // End of head
         new XElement("body",
             new XElement("h2", "Danh sách"),
             new XElement("table",
             new XElement("tr",
                 new XElement("td", "Mã nhân viên"),
                 new XElement("td", "Tên nhân viên"),
                 new XElement("td", "Ngày sinh"),
                 new XElement("td", "Địa chỉ"),
                 new XElement("td", "SDT"),
                 new XElement("td", "Email")
         ), // End of tr of table header
        from el in xI
        select new XElement("tr",
            new XElement("td", el.Element("MaNhanVien").Value),
            new XElement("td", el.Element("TenNhanVien").Value),
            new XElement("td", el.Element("NgaySinh").Value),
            new XElement("td", el.Element("DiaChi").Value),
            new XElement("td", el.Element("SDT").Value),
            new XElement("td",
                new XElement("style", "text-align:right"),
                el.Element("Email").Value) 
        ) // End of tr
         ) // End of table
         ) // End of body
         ); // End of html
            html.Save(pathHTML);
            Process.Start(pathHTML);
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuyendoinv();
        }
    }
}
