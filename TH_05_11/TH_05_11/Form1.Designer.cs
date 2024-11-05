namespace TH_05_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCustomers = new DataGridView();
            dgvServices = new DataGridView();
            lbInvoiceServices = new ListBox();
            btnThemkhachhang = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThemdichvu = new Button();
            btnLuu = new Button();
            panel1 = new Panel();
            txtId = new TextBox();
            txtDiachi = new TextBox();
            txtSdt = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtPrice = new TextBox();
            label5 = new Label();
            btnThanhtoan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(6, 26);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(553, 225);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.ImeMode = ImeMode.NoControl;
            dgvServices.Location = new Point(6, 26);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(430, 120);
            dgvServices.TabIndex = 1;
            dgvServices.CellContentClick += dgvServices_CellContentClick;
            // 
            // lbInvoiceServices
            // 
            lbInvoiceServices.FormattingEnabled = true;
            lbInvoiceServices.Location = new Point(6, 22);
            lbInvoiceServices.Name = "lbInvoiceServices";
            lbInvoiceServices.Size = new Size(391, 124);
            lbInvoiceServices.TabIndex = 2;
            lbInvoiceServices.SelectedIndexChanged += lbInvoiceServices_SelectedIndexChanged;
            // 
            // btnThemkhachhang
            // 
            btnThemkhachhang.Location = new Point(772, 216);
            btnThemkhachhang.Name = "btnThemkhachhang";
            btnThemkhachhang.Size = new Size(94, 29);
            btnThemkhachhang.TabIndex = 3;
            btnThemkhachhang.Text = "Thêm";
            btnThemkhachhang.UseVisualStyleBackColor = true;
            btnThemkhachhang.Click += btnAddCustomer_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(886, 216);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnEditCustomer_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1001, 216);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnDeleteCustomer_Click;
            // 
            // btnThemdichvu
            // 
            btnThemdichvu.Location = new Point(18, 443);
            btnThemdichvu.Name = "btnThemdichvu";
            btnThemdichvu.Size = new Size(94, 29);
            btnThemdichvu.TabIndex = 6;
            btnThemdichvu.Text = "Thêm";
            btnThemdichvu.UseVisualStyleBackColor = true;
            btnThemdichvu.Click += btnAddToInvoice_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(487, 443);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtDiachi);
            panel1.Controls.Add(txtSdt);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(729, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 169);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 15);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(106, 27);
            txtId.TabIndex = 7;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(126, 122);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(240, 27);
            txtDiachi.TabIndex = 6;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(126, 89);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(240, 27);
            txtSdt.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(126, 48);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(240, 27);
            txtTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 122);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 92);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvCustomers);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThemkhachhang);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1153, 257);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvServices);
            groupBox2.Location = new Point(12, 285);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(442, 152);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin dịch vụ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtPrice);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lbInvoiceServices);
            groupBox3.Location = new Point(481, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(597, 152);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(417, 63);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(160, 27);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 26);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 3;
            label5.Text = "Tổng tiền:";
            // 
            // btnThanhtoan
            // 
            btnThanhtoan.Location = new Point(611, 443);
            btnThanhtoan.Name = "btnThanhtoan";
            btnThanhtoan.Size = new Size(94, 29);
            btnThanhtoan.TabIndex = 13;
            btnThanhtoan.Text = "Thanh toán";
            btnThanhtoan.UseVisualStyleBackColor = true;
            btnThanhtoan.Click += btnThanhtoan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 514);
            Controls.Add(btnThanhtoan);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLuu);
            Controls.Add(btnThemdichvu);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomers;
        private DataGridView dgvServices;
        private ListBox lbInvoiceServices;
        private Button btnThemkhachhang;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThemdichvu;
        private Button btnLuu;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn txtName;
        private DataGridViewTextBoxColumn txtPhone;
        private DataGridViewTextBoxColumn txtAddress;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTen;
        private TextBox txtDiachi;
        private TextBox txtSdt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox txtPrice;
        private Button btnThanhtoan;
        private TextBox txtId;
    }
}
