using foodmanager.Controller;
using foodmanager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace foodmanager.View
{
    public partial class FormMain : Form
    {
        FileXML Fxml = new FileXML();
        Main M = new Main();
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
                /*lblQuyen.Text = "Nhân Viên";*/
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
            /*IsMdiContainer = true;
            QuyenDangNhap(false);
            if (!CheckForm("FormDangNhap"))
            {
                FormDangNhap frm = new FormDangNhap();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActivateForm("FormDangNhap");
            }*/

            /*IsMdiContainer = true;
            if (!CheckForm("FormHang"))
            {
                FormHang frm = new FormHang();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActivateForm("FormHang");
            }*/
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

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormImport formImport = new FormImport();
                formImport.ShowDialog();
        }
    }
}
