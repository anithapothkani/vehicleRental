namespace vehicle_rental
{
    partial class Vehiclereg
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
            txtavl = new ComboBox();
            txtmodel = new TextBox();
            txtmake = new TextBox();
            txtregno = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            regno = new DataGridViewTextBoxColumn();
            make = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            available = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtavl);
            groupBox1.Controls.Add(txtmodel);
            groupBox1.Controls.Add(txtmake);
            groupBox1.Controls.Add(txtregno);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 18);
            groupBox1.Margin = new Padding(6, 5, 6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 5, 6, 5);
            groupBox1.Size = new Size(532, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vehicle Registration";
            // 
            // txtavl
            // 
            txtavl.FormattingEnabled = true;
            txtavl.Items.AddRange(new object[] { "Yes", "No" });
            txtavl.Location = new Point(238, 351);
            txtavl.Margin = new Padding(6, 5, 6, 5);
            txtavl.Name = "txtavl";
            txtavl.Size = new Size(276, 31);
            txtavl.TabIndex = 7;
            // 
            // txtmodel
            // 
            txtmodel.Location = new Point(238, 246);
            txtmodel.Margin = new Padding(6, 5, 6, 5);
            txtmodel.Name = "txtmodel";
            txtmodel.Size = new Size(276, 32);
            txtmodel.TabIndex = 6;
            // 
            // txtmake
            // 
            txtmake.Location = new Point(238, 145);
            txtmake.Margin = new Padding(6, 5, 6, 5);
            txtmake.Name = "txtmake";
            txtmake.Size = new Size(276, 32);
            txtmake.TabIndex = 5;
            // 
            // txtregno
            // 
            txtregno.Location = new Point(238, 58);
            txtregno.Margin = new Padding(6, 5, 6, 5);
            txtregno.Name = "txtregno";
            txtregno.Size = new Size(276, 32);
            txtregno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 356);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 3;
            label4.Text = "Available";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 246);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 2;
            label3.Text = "model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 145);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 1;
            label2.Text = "Make";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 58);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Reg No";
            // 
            // button1
            // 
            button1.Location = new Point(54, 510);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(284, 510);
            button5.Margin = new Padding(6, 5, 6, 5);
            button5.Name = "button5";
            button5.Size = new Size(128, 35);
            button5.TabIndex = 5;
            button5.Text = "Cancle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { regno, make, model, available, edit, delete });
            dataGridView1.Location = new Point(542, 96);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(826, 304);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // regno
            // 
            regno.Frozen = true;
            regno.HeaderText = "Regno";
            regno.Name = "regno";
            // 
            // make
            // 
            make.Frozen = true;
            make.HeaderText = "Make";
            make.Name = "make";
            // 
            // model
            // 
            model.Frozen = true;
            model.HeaderText = "Model";
            model.Name = "model";
            // 
            // available
            // 
            available.Frozen = true;
            available.HeaderText = "available";
            available.Name = "available";
            // 
            // edit
            // 
            edit.Frozen = true;
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
            // button6
            // 
            button6.Location = new Point(784, 489);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(174, 56);
            button6.TabIndex = 7;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Vehiclereg
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 787);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Vehiclereg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehiclereg";
            Load += Vehiclereg_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox txtavl;
        private TextBox txtmodel;
        private TextBox txtmake;
        private TextBox txtregno;
        private Button button1;
        private Button button5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn regno;
        private DataGridViewTextBoxColumn make;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn available;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
        private Button button6;
    }
}