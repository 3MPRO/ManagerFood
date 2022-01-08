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
    public partial class FormTaiKhoanNV : Form
    {
        FileXML Fxml = new FileXML();
        nhanVien nv = new nhanVien();
        DangNhap dn = new DangNhap();
        public FormTaiKhoanNV()
        {
            InitializeComponent();
        }

        public void hienthiTTTK()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("TaiKhoan.xml");
            dgvTaiKhoanNhanVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Equals("") || txtMatKhau.Text.Equals("") || txtQuyen.Text.Equals("") || txtTenNhanVien.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                if (nv.kiemtra(txtMaNhanVien.Text) == false)
            {
                MessageBox.Show("Không có nhân viên này");
            }

            else
            {
                if (dn.kiemtraTTTK(txtMaNhanVien.Text) == true)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    txtMaNhanVien.Text = "";
                    txtMatKhau.Text = "";
                    txtQuyen.Text = "";
                    txtTenNhanVien.Text = "";
                    txtMaNhanVien.Focus();

                }
                else
                {
                    dn.dangkiTaiKhoan(txtMaNhanVien.Text, txtMatKhau.Text, int.Parse(txtQuyen.Text));
                    MessageBox.Show("Thêm thành công");
                    hienthiTTTK();
                }

            }
            }
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dn.xoaTK(txtMaNhanVien.Text);
            MessageBox.Show("Xóa thành công");
            hienthiTTTK();
        }

        private void tbnTen_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = Fxml.LayGiaTri("NhanVien.xml", "MaNhanVien", txtMaNhanVien.Text, "TenNhanVien");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTaiKhoanNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvTaiKhoanNhanVien.CurrentRow.Index;
            txtMaNhanVien.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[0].Value.ToString().Trim();
            txtMatKhau.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[1].Value.ToString().Trim();
            //txtTenNhanVien.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[2].Value.ToString();
            txtQuyen.Text = dgvTaiKhoanNhanVien.Rows[d].Cells[2].Value.ToString().Trim();
        }

        private void FormTaiKhoanNV_Load(object sender, EventArgs e)
        {
            hienthiTTTK();
        }
    }
}
