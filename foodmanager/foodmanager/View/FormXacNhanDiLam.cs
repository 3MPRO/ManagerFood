using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using foodmanager.Controller;
using foodmanager.Model;

namespace foodmanager.View
{
    public partial class FormXacNhanDiLam : Form
    {
        DangNhap dn = new DangNhap();
        nhanVien nv = new nhanVien();
        public FormXacNhanDiLam()
        {
            InitializeComponent();
        }

        private void FormXacNhanDiLam_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    if (dn.kiemtraTTDN("TaiKhoan.xml", txtMaNhanVien.Text, txtMatKhau.Text) == false)
                    {
                        MessageBox.Show("Thông tin của người dùng không khớp nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DateTime date = new DateTime();
                        date = DateTime.Today;

                        MessageBox.Show("Hôm nay là ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year);
                        if (nv.kiemtraNgayThang(txtMaNhanVien.Text, date.Day, date.Month, date.Year))
                        {
                            MessageBox.Show("Hôm nay bạn đã xác nhận đi làm rồi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            nv.XacNhanDiLam(txtMaNhanVien.Text, date.Day, date.Month, date.Year);
                            MessageBox.Show("Đã xác nhận nhân viên '" + txtMaNhanVien.Text + "' đi làm ngày hôm nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txtMaNhanVien.Enabled = txtMatKhau.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
