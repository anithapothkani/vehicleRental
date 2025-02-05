namespace vehicle_rental
{
    partial class Customer
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
            txtmobile = new TextBox();
            txtaddress = new TextBox();
            txtname = new TextBox();
            txtid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmobile);
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 424);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // txtmobile
            // 
            txtmobile.Location = new Point(148, 244);
            txtmobile.Name = "txtmobile";
            txtmobile.Size = new Size(172, 29);
            txtmobile.TabIndex = 8;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(148, 181);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(172, 29);
            txtaddress.TabIndex = 7;
            // 
            // txtname
            // 
            txtname.Location = new Point(148, 117);
            txtname.Name = "txtname";
            txtname.Size = new Size(172, 29);
            txtname.TabIndex = 6;
            // 
            // txtid
            // 
            txtid.Location = new Point(148, 59);
            txtid.Name = "txtid";
            txtid.Size = new Size(172, 29);
            txtid.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 2;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 242);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 4;
            label4.Text = "Mobile";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(39, 447);
            button1.Name = "button1";
            button1.Size = new Size(118, 45);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(261, 449);
            button2.Name = "button2";
            button2.Size = new Size(118, 45);
            button2.TabIndex = 10;
            button2.Text = "Cancle";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, edit, delete });
            dataGridView1.Location = new Point(413, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 311);
            dataGridView1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(682, 449);
            button3.Name = "button3";
            button3.Size = new Size(130, 45);
            button3.TabIndex = 2;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "CustomerID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "CustomerName";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Address";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Mobile";
            Column4.Name = "Column4";
            // 
            // edit
            // 
            edit.HeaderText = "Edit";
            edit.Name = "edit";
            edit.Resizable = DataGridViewTriState.True;
            edit.SortMode = DataGridViewColumnSortMode.Automatic;
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            delete.HeaderText = "Delete";
            delete.Name = "delete";
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 725);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += Customer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtmobile;
        private TextBox txtaddress;
        private TextBox txtname;
        private TextBox txtid;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}