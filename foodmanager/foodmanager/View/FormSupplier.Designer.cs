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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(91, 441);
            this.dgvSupplier.MultiSelect = false;
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(901, 217);
            this.dgvSupplier.TabIndex = 27;
            this.dgvSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellContentClick_1);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(831, 294);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(78, 37);
            this.btnReview.TabIndex = 26;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(673, 294);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 37);
            this.btnShow.TabIndex = 25;
            this.btnShow.Text = "Làm mới";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(515, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 37);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(357, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 37);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearchSupp
            // 
            this.txtSearchSupp.Location = new System.Drawing.Point(714, 409);
            this.txtSearchSupp.Name = "txtSearchSupp";
            this.txtSearchSupp.Size = new System.Drawing.Size(278, 26);
            this.txtSearchSupp.TabIndex = 20;
            this.txtSearchSupp.TextChanged += new System.EventHandler(this.txtSearchSupp_TextChanged_1);
            // 
            // txtDesSupp
            // 
            this.txtDesSupp.Location = new System.Drawing.Point(751, 193);
            this.txtDesSupp.Name = "txtDesSupp";
            this.txtDesSupp.Size = new System.Drawing.Size(206, 26);
            this.txtDesSupp.TabIndex = 19;
            // 
            // txtAddressSupp
            // 
            this.txtAddressSupp.Location = new System.Drawing.Point(251, 195);
            this.txtAddressSupp.Name = "txtAddressSupp";
            this.txtAddressSupp.Size = new System.Drawing.Size(225, 26);
            this.txtAddressSupp.TabIndex = 18;
            // 
            // txtEmailSupp
            // 
            this.txtEmailSupp.Location = new System.Drawing.Point(751, 138);
            this.txtEmailSupp.Name = "txtEmailSupp";
            this.txtEmailSupp.Size = new System.Drawing.Size(206, 26);
            this.txtEmailSupp.TabIndex = 21;
            // 
            // txtNameSupp
            // 
            this.txtNameSupp.Location = new System.Drawing.Point(251, 140);
            this.txtNameSupp.Name = "txtNameSupp";
            this.txtNameSupp.Size = new System.Drawing.Size(225, 26);
            this.txtNameSupp.TabIndex = 17;
            // 
            // txtNumPhoneSupp
            // 
            this.txtNumPhoneSupp.Location = new System.Drawing.Point(751, 96);
            this.txtNumPhoneSupp.Name = "txtNumPhoneSupp";
            this.txtNumPhoneSupp.Size = new System.Drawing.Size(206, 26);
            this.txtNumPhoneSupp.TabIndex = 16;
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Location = new System.Drawing.Point(251, 96);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(225, 26);
            this.txtIdSupplier.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nhập tên tìm kiếm : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(335, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(473, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "QUẢN LÝ THÔNG TIN NHÀ CUNG CẤP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên NCC:";
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 686);
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
    }
}