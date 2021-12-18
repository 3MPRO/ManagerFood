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
        nhanVien nv = new nhanVien();
        public FormImport()
        {
            InitializeComponent();
        }

        private void FormImport_Load(object sender, EventArgs e)
        {
            hienthiPhieuNhap();
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
    }
}
