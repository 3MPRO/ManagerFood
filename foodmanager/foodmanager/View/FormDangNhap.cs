using foodmanager.Controller;
using foodmanager.Model;
using foodmanager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodmanager
{
    public partial class FormDangNhap : Form
    {
        FileXML Fxml = new FileXML();
        DangNhap dn = new DangNhap();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals("") || txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống các trường!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTaiKhoan.Focus();
            }
            else
            {

                if (dn.kiemtraTTDN("User.xml", txtTaiKhoan.Text, txtMatKhau.Text) == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    dn.layMaQuyen();
                    FormMain.tenDNMain = txtTaiKhoan.Text;
                    FormMain frm = new FormMain();
                    frm.QuyenDangNhap(true);
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
            }
        }

        public string HoTen(string MaNhanVien)
        {
            return Fxml.LayGiaTri("NhanVien.xml", "MaNhanVien", MaNhanVien, "TenNhanVien"); ;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
