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

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[d].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[d].Cells[1].Value.ToString();
            dateNgaySinh.Text = dgvNhanVien.Rows[d].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[d].Cells[3].Value.ToString();
            txtSdt.Text = dgvNhanVien.Rows[d].Cells[4].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[d].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nv.checkMaNV(txtMaNV.Text) == true)
            {
                MessageBox.Show("Mã Nhân viên đã tồn tại");
            }
            else
            {
                nv.addNhanVien(txtMaNV.Text, txtHoTen.Text, txtDiaChi.Text, 
                    txtSdt.Text, txtEmail.Text, dateNgaySinh.Text);
                MessageBox.Show("Ok");
                MessageBox.Show(dateNgaySinh.Text);
                hienThiNhanVien();
            }
        }
    }
}
