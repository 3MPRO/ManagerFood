using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using foodmanager.Model;
using System.Data;
using System.Data.SqlClient;

namespace foodmanager.View
{
    public partial class FormReportNCC : Form
    {
        FileXML fl = new FileXML();
        public FormReportNCC()
        {
            InitializeComponent();
        }
        public DataTable getAlLNhaCungCap()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from NhaCungCap";
            using(SqlConnection sqlConnection = GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public static SqlConnection GetSqlConnection()
        {
            string Conn = "Data Source=DESKTOP-U09VCD7; Initial Catalog = QuanLyThucPham; Integrated Security=true";
            return new SqlConnection(Conn);
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {

                reportViewer1.LocalReport.ReportEmbeddedResource = "foodmanager.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSetNCC";
                reportDataSource.Value = getAlLNhaCungCap();

                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
