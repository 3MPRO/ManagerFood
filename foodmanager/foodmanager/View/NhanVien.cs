using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using foodmanager.Model;
using System.Xml;

namespace foodmanager.View
{
    public partial class NhanVien : Form
    {
        FileXML Fxml = new FileXML();
        nhanVien nv = new nhanVien();
        string MaNhanVien, TenNhanVien, NgaySinh, DiaChi, SDT, Email;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            hienThiNhanVien();
        }

        public void hienThiNhanVien()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("NhanVien.xml");
            dgvNhanVien.DataSource = dt;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvNhanVien.CurrentRow.Index;
            //MessageBox.Show(d.ToString());
            txtMaNV.Text = dgvNhanVien.Rows[d].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[d].Cells[1].Value.ToString();
            dateNgaySinh.Text = dgvNhanVien.Rows[d].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[d].Cells[3].Value.ToString();
            txtSdt.Text = dgvNhanVien.Rows[d].Cells[4].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[d].Cells[5].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaNhanVien";
            reader.Close();
            int index = dv.Find(txtSearch.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                txtSearch.Text = "";
                txtSearch.Focus();

            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã nhân viên");
                dt.Columns.Add("Họ và tên");
                dt.Columns.Add("Ngày sinh");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Email");


                object[] list = { dv[index]["MaNhanVien"], dv[index]["TenNhanVien"], dv[index]["NgaySinh"], dv[index]["DiaChi"], dv[index]["SDT"], dv[index]["Email"] };
                dt.Rows.Add(list);
                dgvNhanVien.DataSource = dt;
                txtSearch.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nv.kiemtra(txtMaNV.Text) == true)
            {
                MessageBox.Show("Mã Nhân viên đã tồn tại");
            }
            else
            {
                DateTime dt = DateTime.Parse(dateNgaySinh.Text);
                nv.themNV(txtMaNV.Text, txtHoTen.Text, dt.ToString(), txtDiaChi.Text,
                    txtSdt.Text, txtEmail.Text);
                MessageBox.Show("Ok");
                MessageBox.Show(dateNgaySinh.Text);
                hienThiNhanVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nv.xoaNV(txtMaNV.Text);
            MessageBox.Show("Ok");
            xoaDuLieu();
            hienThiNhanVien();
        }

        public void xoaDuLieu()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
            dateNgaySinh.Text = "";
        }
        public void LoadDuLieu()
        {
            MaNhanVien = txtMaNV.Text;
            TenNhanVien = txtHoTen.Text;
            DiaChi = txtDiaChi.Text;
            SDT = txtSdt.Text;
            Email = txtEmail.Text;
            txtMaNV.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            DateTime dt = DateTime.Parse(dateNgaySinh.Text); 
            nv.suaNV(MaNhanVien, TenNhanVien, dt.ToString(), DiaChi, SDT, Email);
            MessageBox.Show("Ok");
            hienThiNhanVien();
        }
    }
}
