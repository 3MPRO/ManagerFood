﻿using foodmanager.Controller;
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
        HeThong HT = new HeThong();
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
    }
}
