namespace vehicle_rental
{
    partial class Main
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(283, 54);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(234, 59);
            button1.TabIndex = 0;
            button1.Text = "Vehicle Registration";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(283, 159);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(234, 53);
            button2.TabIndex = 1;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(283, 258);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(234, 55);
            button3.TabIndex = 2;
            button3.Text = "Rentall";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(283, 362);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(234, 53);
            button4.TabIndex = 3;
            button4.Text = "Return";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(283, 469);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(234, 56);
            button5.TabIndex = 4;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 630);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}