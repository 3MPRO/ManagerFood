namespace foodmanager.View
{
    partial class FormSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnReview = new System.Windows.Forms.Button();
            this.txtSearchSupp = new System.Windows.Forms.TextBox();
            this.txtDesSupp = new System.Windows.Forms.TextBox();
            this.txtAddressSupp = new System.Windows.Forms.TextBox();
            this.txtEmailSupp = new System.Windows.Forms.TextBox();
            this.txtNameSupp = new System.Windows.Forms.TextBox();
            this.txtNumPhoneSupp = new System.Windows.Forms.TextBox();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(81, 353);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSupplier.MultiSelect = false;
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(801, 269);
            this.dgvSupplier.TabIndex = 27;
            this.dgvSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellContentClick_1);
            // 
            // btnReview
            // 
            this.btnReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.White;
            this.btnReview.Image = ((System.Drawing.Image)(resources.GetObject("btnReview.Image")));
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.Location = new System.Drawing.Point(724, 235);
            this.btnReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(145, 54);
            this.btnReview.TabIndex = 26;
            this.btnReview.Text = "         Review";
            this.btnReview.UseVisualStyleBackColor = false;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // txtSearchSupp
            // 
            this.txtSearchSupp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupp.Location = new System.Drawing.Point(449, 311);
            this.txtSearchSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchSupp.Name = "txtSearchSupp";
            this.txtSearchSupp.Size = new System.Drawing.Size(248, 30);
            this.txtSearchSupp.TabIndex = 20;
            this.txtSearchSupp.TextChanged += new System.EventHandler(this.txtSearchSupp_TextChanged_1);
            // 
            // txtDesSupp
            // 
            this.txtDesSupp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesSupp.Location = new System.Drawing.Point(668, 154);
            this.txtDesSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesSupp.Name = "txtDesSupp";
            this.txtDesSupp.Size = new System.Drawing.Size(184, 30);
            this.txtDesSupp.TabIndex = 19;
            // 
            // txtAddressSupp
            // 
            this.txtAddressSupp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressSupp.Location = new System.Drawing.Point(223, 156);
            this.txtAddressSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressSupp.Name = "txtAddressSupp";
            this.txtAddressSupp.Size = new System.Drawing.Size(200, 30);
            this.txtAddressSupp.TabIndex = 18;
            // 
            // txtEmailSupp
            // 
            this.txtEmailSupp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSupp.Location = new System.Drawing.Point(668, 116);
            this.txtEmailSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailSupp.Name = "txtEmailSupp";
            this.txtEmailSupp.Size = new System.Drawing.Size(184, 30);
            this.txtEmailSupp.TabIndex = 21;
            // 
            // txtNameSupp
            // 
            this.txtNameSupp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSupp.Location = new System.Drawing.Point(223, 118);
            this.txtNameSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameSupp.Name = "txtNameSupp";
            this.txtNameSupp.Size = new System.Drawing.Size(200, 30);
            this.txtNameSupp.TabIndex = 17;
            // 
            // txtNumPhoneSupp
            // 
            this.txtNumPhoneSupp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPhoneSupp.Location = new System.Drawing.Point(668, 77);
            this.txtNumPhoneSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumPhoneSupp.Name = "txtNumPhoneSupp";
            this.txtNumPhoneSupp.Size = new System.Drawing.Size(184, 30);
            this.txtNumPhoneSupp.TabIndex = 16;
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSupplier.Location = new System.Drawing.Point(223, 77);
            this.txtIdSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(200, 30);
            this.txtIdSupplier.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(545, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(266, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nhập tên tìm kiếm : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(545, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(545, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(179, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(605, 46);
            this.label7.TabIndex = 9;
            this.label7.Text = "QUẢN LÝ THÔNG TIN NHÀ CUNG CẤP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(105, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(108, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(105, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên NCC:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = global::foodmanager.Properties.Resources.loading;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(549, 235);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(151, 54);
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "      Làm mới";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::foodmanager.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(398, 235);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 54);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "      Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::foodmanager.Properties.Resources.pen;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(239, 235);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 54);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "   Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::foodmanager.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(81, 235);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 54);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "       Thêm ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::foodmanager.Properties.Resources.search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(709, 304);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 41);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "   Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(962, 633);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearchSupp);
            this.Controls.Add(this.txtDesSupp);
            this.Controls.Add(this.txtAddressSupp);
            this.Controls.Add(this.txtEmailSupp);
            this.Controls.Add(this.txtNameSupp);
            this.Controls.Add(this.txtNumPhoneSupp);
            this.Controls.Add(this.txtIdSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.Load += new System.EventHandler(this.FormSupplier_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearchSupp;
        private System.Windows.Forms.TextBox txtDesSupp;
        private System.Windows.Forms.TextBox txtAddressSupp;
        private System.Windows.Forms.TextBox txtEmailSupp;
        private System.Windows.Forms.TextBox txtNameSupp;
        private System.Windows.Forms.TextBox txtNumPhoneSupp;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
    }
}