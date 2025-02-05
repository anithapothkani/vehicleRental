namespace vehicle_rental
{
    partial class rental
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
            groupBox1 = new GroupBox();
            txtduedate = new DateTimePicker();
            txtdate = new DateTimePicker();
            txtrentalfee = new TextBox();
            txtcustname = new TextBox();
            txtcustid = new TextBox();
            txtcarid = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtduedate);
            groupBox1.Controls.Add(txtdate);
            groupBox1.Controls.Add(txtrentalfee);
            groupBox1.Controls.Add(txtcustname);
            groupBox1.Controls.Add(txtcustid);
            groupBox1.Controls.Add(txtcarid);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rental";
            // 
            // txtduedate
            // 
            txtduedate.Location = new Point(165, 310);
            txtduedate.Name = "txtduedate";
            txtduedate.Size = new Size(200, 29);
            txtduedate.TabIndex = 12;
            // 
            // txtdate
            // 
            txtdate.Location = new Point(165, 252);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(200, 29);
            txtdate.TabIndex = 11;
            // 
            // txtrentalfee
            // 
            txtrentalfee.Location = new Point(165, 192);
            txtrentalfee.Name = "txtrentalfee";
            txtrentalfee.Size = new Size(200, 29);
            txtrentalfee.TabIndex = 10;
            // 
            // txtcustname
            // 
            txtcustname.Location = new Point(165, 133);
            txtcustname.Name = "txtcustname";
            txtcustname.Size = new Size(200, 29);
            txtcustname.TabIndex = 9;
            // 
            // txtcustid
            // 
            txtcustid.Location = new Point(165, 84);
            txtcustid.Name = "txtcustid";
            txtcustid.Size = new Size(191, 29);
            txtcustid.TabIndex = 8;
            txtcustid.KeyPress += txtcustid_KeyPress;
            // 
            // txtcarid
            // 
            txtcarid.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcarid.FormattingEnabled = true;
            txtcarid.Location = new Point(165, 31);
            txtcarid.Name = "txtcarid";
            txtcarid.Size = new Size(191, 29);
            txtcarid.TabIndex = 7;
            txtcarid.SelectedIndexChanged += txtcarid_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 310);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 6;
            label7.Text = "Due Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 252);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 5;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 195);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 4;
            label5.Text = "Rental Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 141);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 3;
            label4.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 92);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 2;
            label3.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 34);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Car ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 30);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "Rental";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(192, 544);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 7;
            label8.Text = "Available";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 64, 0);
            label9.Location = new Point(205, 594);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 13;
            label9.Text = "label9";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(47, 544);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column7, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(438, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(753, 261);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column7
            // 
            Column7.HeaderText = "ID";
            Column7.Name = "Column7";
            // 
            // Column1
            // 
            Column1.HeaderText = "Car ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer ID";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Customer Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Rental Fee";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Date";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Due Date";
            Column6.Name = "Column6";
            // 
            // rental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 752);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "rental";
            Text = "rental";
            Load += rental_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker txtdate;
        private TextBox txtrentalfee;
        private TextBox txtcustname;
        private TextBox txtcustid;
        private ComboBox txtcarid;
        private DateTimePicker txtduedate;
        private Label label9;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}