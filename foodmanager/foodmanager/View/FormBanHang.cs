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
    public partial class FormBanHang : Form
    {
        Import pn = new Import();
        FileXML Fxml = new FileXML();
        Hang H = new Hang();
        HoaDon HD = new HoaDon();
        nhanVien nv = new nhanVien();
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDonGia.Text = Fxml.LayGiaTri("Hang.xml", "MaHang", txtMaHang.Text, "DonGia");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSoLuong.Text == " ")
            {
                txtSoLuong.Text = "";
            }
            else
            {
                try
                {
                    int a = int.Parse(txtSoLuong.Text);
                    long t = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
                    txtTongTien.Text = t.ToString();
                }
                catch
                {
                    txtSoLuong.Text = "";
                }
            }
        }
        public void hienthiHoaDon()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("HoaDon.xml");
            dtgHoaDon.DataSource = dt;
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            txtMaHang.DataSource = H.LoadMaHang();
            txtMaHang.DisplayMember = "MaHang";
            txtMaHang.ValueMember = "TenHang";
            txtMaNhanVien.DataSource = nv.LoadMaNV();
            txtMaNhanVien.DisplayMember = "MaNhanVien";
            txtMaNhanVien.ValueMember = "TenNhanVien";
            hienthiHoaDon();
        }

        private void txtMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dtgHoaDon.CurrentRow.Index;
            txtMaHang.SelectedValue = dtgHoaDon.Rows[d].Cells[0].Value.ToString();
            txtDonGia.Text = dtgHoaDon.Rows[d].Cells[1].Value.ToString();
            txtSoLuong.Text = dtgHoaDon.Rows[d].Cells[2].Value.ToString();
            txtMaNhanVien.SelectedValue = dtgHoaDon.Rows[d].Cells[3].Value.ToString();
            dateTimePicker1.Text = dtgHoaDon.Rows[d].Cells[4].Value.ToString();
            txtMaNhanVien.SelectedValue = dtgHoaDon.Rows[d].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*if (HD.kiemtraSHD(txt.Text) == true)
            {
                MessageBox.Show("Mã hàng đã tồn tại");
            }
            else
            {*/
                HD.themHD(txtMaHang.Text, dateTimePicker1.Text, txtTongTien.Text);
                MessageBox.Show("Ok");
                hienthiHoaDon();
            //}
        }
    }
}
