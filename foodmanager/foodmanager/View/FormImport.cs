using foodmanager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodmanager.View
{
    public partial class FormImport : Form
    {
        Import pn = new Import();
        FileXML Fxml = new FileXML();
        Hang H = new Hang();
        nhanVien nv = new nhanVien();
        public FormImport()
        {
            InitializeComponent();
        }

        private void FormImport_Load(object sender, EventArgs e)
        {
            txtMaHang.DataSource = H.LoadMaHang();
            txtMaHang.DisplayMember = "MaHang"; 
            txtMaHang.ValueMember = "TenHang";
            txtMaNhanVien.DataSource = nv.LoadMaNV();
            txtMaNhanVien.DisplayMember = "MaNhanVien";
            txtMaNhanVien.ValueMember = "TenNhanVien";
            hienthiPhieuNhap();
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoLuong.Text = Fxml.LayGiaTri("Hang.xml", "MaHang", txtMaHang.Text, "SoLuong");
        }
        public void hienthiPhieuNhap()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("PhieuNhap.xml");
            dgvPhieuNhapHang.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (pn.kiemtraMaPhieu(txtMaPhieu.Text) == true)
            {
                MessageBox.Show("Mã phiếu đã tồn tại");
            }
            else
            {
                if (nv.kiemtra(txtMaNhanVien.Text.ToString().Trim()) == false)
                {
                    MessageBox.Show("Ko có mã nhân viên này, kiểm tra lại");
                }
                else
                {
                    DateTime dt = DateTime.Parse(dptNgaylapPhieu.Text);
                    pn.themPN(txtMaPhieu.Text, txtMaHang.Text, txtMaNhanVien.Text, txtSoLuong.Text, dt.ToString());
                    MessageBox.Show("Ok");
                    hienthiPhieuNhap();
                }
            }
        }

        private void dgvPhieuNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvPhieuNhapHang.CurrentRow.Index;
            txtMaPhieu.Text = dgvPhieuNhapHang.Rows[d].Cells[0].Value.ToString();
            txtMaHang.Text = dgvPhieuNhapHang.Rows[d].Cells[1].Value.ToString();
            txtMaNhanVien.Text = dgvPhieuNhapHang.Rows[d].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvPhieuNhapHang.Rows[d].Cells[3].Value.ToString();
            dptNgaylapPhieu.Text = dgvPhieuNhapHang.Rows[d].Cells[4].Value.ToString();
        }
    }
}
