using foodmanager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Xml;

namespace foodmanager.View
{
    public partial class FormHang : Form
    {
        FileXML Fxml = new FileXML();
        Hang H = new Hang();
        Supplier ncc = new Supplier();
        public FormHang()
        {
            InitializeComponent();
        }
        public void hienthiHang()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("Hang.xml");
            dgvHang.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (H.kiemtraMaHang(txtMaHang.Text) == true)
            {
                MessageBox.Show("Mã hàng đã tồn tại");
            }
            else
            {
                H.themH(txtMaHang.Text, txtTenHang.Text, txtDonViTinh.Text, txtDonGia.Text, txtSoLuong.Text, cbbMaNCC.SelectedValue.ToString());
                MessageBox.Show("Ok");
                hienthiHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            H.suaH(txtMaHang.Text, txtTenHang.Text, txtDonViTinh.Text, txtDonGia.Text, txtSoLuong.Text, cbbMaNCC.SelectedValue.ToString());
            MessageBox.Show("Ok");
            hienthiHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            H.xoaH(txtMaHang.Text);
            MessageBox.Show("Ok");
            hienthiHang();
        }

        private void FormHang_Load(object sender, EventArgs e)
        {
            cbbMaNCC.DataSource = ncc.LoadIdSupplier();
            cbbMaNCC.DisplayMember = "TenNCC";
            cbbMaNCC.ValueMember = "MaNCC";
            hienthiHang();
        }

        void LoadTable()
        {
            DataTable dt = new DataTable();
            dt = ncc.LoadTable();
            dgvHang.DataSource = dt;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            hienthiHang();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("Hang.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaHang";
            reader.Close();
            int index = dv.Find(txtTimKiem.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                txtTimKiem.Text = "";
                txtTimKiem.Focus();

            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã hàng");
                dt.Columns.Add("Tên hàng");
                dt.Columns.Add("Đơn vị tính");
                dt.Columns.Add("Đơn giá");
                dt.Columns.Add("Sô lượng");
                dt.Columns.Add("Mã NCC");


                object[] list = { dv[index]["MaHang"], dv[index]["TenHang"], dv[index]["DonViTinh"], dv[index]["DonGia"], dv[index]["SoLuong"], dv[index]["MaNCC"] };
                dt.Rows.Add(list);
                dgvHang.DataSource = dt;
                txtTimKiem.Text = "";
            }
        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvHang.CurrentRow.Index;
            txtMaHang.Text = dgvHang.Rows[d].Cells[0].Value.ToString();
            txtTenHang.Text = dgvHang.Rows[d].Cells[1].Value.ToString();
            txtDonViTinh.Text = dgvHang.Rows[d].Cells[2].Value.ToString();
            txtDonGia.Text = dgvHang.Rows[d].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvHang.Rows[d].Cells[4].Value.ToString();
            cbbMaNCC.SelectedValue = dgvHang.Rows[d].Cells[5].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
