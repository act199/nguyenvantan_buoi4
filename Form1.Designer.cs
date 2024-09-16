namespace nguyenvantan_buoi4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_mssv = new TextBox();
            txt_hoten = new TextBox();
            txt_gioitinh = new TextBox();
            txt_diachi = new TextBox();
            button1 = new Button();
            dtp_ngaysinh = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 82);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 119);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 156);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Giới tính :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 87);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 119);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ :";
            // 
            // txt_mssv
            // 
            txt_mssv.Location = new Point(190, 84);
            txt_mssv.Name = "txt_mssv";
            txt_mssv.Size = new Size(100, 23);
            txt_mssv.TabIndex = 5;
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(190, 119);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(100, 23);
            txt_hoten.TabIndex = 6;
            // 
            // txt_gioitinh
            // 
            txt_gioitinh.Location = new Point(193, 154);
            txt_gioitinh.Name = "txt_gioitinh";
            txt_gioitinh.Size = new Size(100, 23);
            txt_gioitinh.TabIndex = 7;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(454, 116);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(100, 23);
            txt_diachi.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(454, 156);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtp_ngaysinh
            // 
            dtp_ngaysinh.Location = new Point(454, 82);
            dtp_ngaysinh.Name = "dtp_ngaysinh";
            dtp_ngaysinh.Size = new Size(200, 23);
            dtp_ngaysinh.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(695, 189);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(579, 156);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(dtp_ngaysinh);
            Controls.Add(button1);
            Controls.Add(txt_diachi);
            Controls.Add(txt_gioitinh);
            Controls.Add(txt_hoten);
            Controls.Add(txt_mssv);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_mssv;
        private TextBox txt_hoten;
        private TextBox txt_gioitinh;
        private TextBox txt_diachi;
        private Button button1;
        private DateTimePicker dtp_ngaysinh;
        private DataGridView dataGridView1;
        private Button button2;
    }
}
