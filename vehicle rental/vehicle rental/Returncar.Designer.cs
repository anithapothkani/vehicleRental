namespace vehicle_rental
{
    partial class Returncar
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
            txtFine = new TextBox();
            txtdueElapsed = new TextBox();
            txtdate = new TextBox();
            txtcustid = new TextBox();
            txtcarid = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFine);
            groupBox1.Controls.Add(txtdueElapsed);
            groupBox1.Controls.Add(txtdate);
            groupBox1.Controls.Add(txtcustid);
            groupBox1.Controls.Add(txtcarid);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 331);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Return Car";
            // 
            // txtFine
            // 
            txtFine.Location = new Point(144, 258);
            txtFine.Name = "txtFine";
            txtFine.Size = new Size(169, 29);
            txtFine.TabIndex = 11;
            // 
            // txtdueElapsed
            // 
            txtdueElapsed.Location = new Point(144, 204);
            txtdueElapsed.Name = "txtdueElapsed";
            txtdueElapsed.Size = new Size(169, 29);
            txtdueElapsed.TabIndex = 10;
            // 
            // txtdate
            // 
            txtdate.Location = new Point(144, 151);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(169, 29);
            txtdate.TabIndex = 9;
            // 
            // txtcustid
            // 
            txtcustid.Location = new Point(144, 100);
            txtcustid.Name = "txtcustid";
            txtcustid.Size = new Size(169, 29);
            txtcustid.TabIndex = 8;
            // 
            // txtcarid
            // 
            txtcarid.Location = new Point(144, 45);
            txtcarid.Name = "txtcarid";
            txtcarid.Size = new Size(169, 29);
            txtcarid.TabIndex = 7;
            txtcarid.KeyPress += textBox1_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 258);
            label7.Name = "label7";
            label7.Size = new Size(41, 21);
            label7.TabIndex = 6;
            label7.Text = "Fine";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 207);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 5;
            label6.Text = "Due Elapsed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 154);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 4;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 3;
            label4.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 45);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 2;
            label3.Text = "carId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 100);
            label1.Name = "label1";
            label1.Size = new Size(14, 21);
            label1.TabIndex = 0;
            label1.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 34);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Return car";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(120, 458);
            button1.Name = "button1";
            button1.Size = new Size(90, 35);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(376, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(401, 223);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Returncar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 638);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Returncar";
            Text = "Returncar";
            Load += Returncar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private TextBox txtFine;
        private TextBox txtdueElapsed;
        private TextBox txtdate;
        private TextBox txtcustid;
        private TextBox txtcarid;
        private Button button1;
        private DataGridView dataGridView1;
    }
}