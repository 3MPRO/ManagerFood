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
using System.Xml;

namespace foodmanager.View
{
    public partial class FormSupplier : Form
    {
        FileXML Fxml = new FileXML();
        Supplier ncc = new Supplier();
        public FormSupplier()
        {
            InitializeComponent();
        }

    
        public void showSupplier()
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi("NhaCungCap.xml");
            dgvSupplier.DataSource = dt;
        }

 

        private void FormSupplier_Load_1(object sender, EventArgs e)
        {
            showSupplier();
        }

        private void dgvSupplier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvSupplier.CurrentRow.Index;
            txtIdSupplier.Text = dgvSupplier.Rows[d].Cells[0].Value.ToString();
            txtNameSupp.Text = dgvSupplier.Rows[d].Cells[1].Value.ToString();
            txtAddressSupp.Text = dgvSupplier.Rows[d].Cells[2].Value.ToString();
            txtNumPhoneSupp.Text = dgvSupplier.Rows[d].Cells[3].Value.ToString();
            txtEmailSupp.Text = dgvSupplier.Rows[d].Cells[4].Value.ToString();
            txtDesSupp.Text = dgvSupplier.Rows[d].Cells[5].Value.ToString();

        }

        private void txtSearchSupp_TextChanged_1(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("NhaCungCap.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "MaNCC";
            reader.Close();
            int index = dv.Find(txtSearchSupp.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                txtSearchSupp.Text = "";
                txtSearchSupp.Focus();

            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã NCC");
                dt.Columns.Add("Tên NCC");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("SDT");
                dt.Columns.Add("Email");
                dt.Columns.Add("Mô tả");


                object[] list = { dv[index]["MaNCC"], dv[index]["TenNCC"], dv[index]["DiaChi"], dv[index]["SDT"], dv[index]["Email"], dv[index]["MoTa"] };
                dt.Rows.Add(list);
                dgvSupplier.DataSource = dt;
                txtSearchSupp.Text = "";
            }
        }
        public void  refesh()
        {
            txtIdSupplier.Text = "";
            txtNameSupp.Text = "";
            txtAddressSupp.Text = "";
            txtNumPhoneSupp.Text = "";
            txtEmailSupp.Text = "";
            txtDesSupp.Text = "";
         
        }
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
            refesh();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            ncc.deleteSupplier(txtIdSupplier.Text);
            MessageBox.Show("Ok");
            showSupplier();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ncc.updateSuplier(txtIdSupplier.Text, txtNameSupp.Text, txtAddressSupp.Text, txtNumPhoneSupp.Text, txtEmailSupp.Text, txtDesSupp.Text);
            MessageBox.Show("Ok");
            showSupplier();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ncc.checkIdSupplier(txtIdSupplier.Text) == true)
            {
                MessageBox.Show("Nhà cung cấp này đã tồn tại");
            }
            else
            {
                ncc.addSupplier(txtIdSupplier.Text, txtNameSupp.Text, txtAddressSupp.Text, txtNumPhoneSupp.Text, txtEmailSupp.Text, txtDesSupp.Text);
                MessageBox.Show("Ok");
                showSupplier();
            }
        }
    }

}
