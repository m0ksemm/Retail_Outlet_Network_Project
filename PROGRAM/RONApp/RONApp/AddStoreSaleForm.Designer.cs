namespace RONApp
{
    partial class AddStoreSaleForm
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
            StoreName = new Label();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // StoreName
            // 
            StoreName.AutoSize = true;
            StoreName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            StoreName.ForeColor = SystemColors.Highlight;
            StoreName.Location = new Point(12, 9);
            StoreName.Name = "StoreName";
            StoreName.Size = new Size(92, 37);
            StoreName.TabIndex = 11;
            StoreName.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(16, 139);
            label3.Name = "label3";
            label3.Size = new Size(70, 37);
            label3.TabIndex = 10;
            label3.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 8;
            label1.Text = "Create New Sale";
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Microsoft Sans Serif", 22F);
            button2.Location = new Point(266, 312);
            button2.Name = "button2";
            button2.Size = new Size(222, 51);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Microsoft Sans Serif", 22F);
            button1.Location = new Point(12, 312);
            button1.Name = "button1";
            button1.Size = new Size(222, 51);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(16, 232);
            label4.Name = "label4";
            label4.Size = new Size(185, 37);
            label4.TabIndex = 16;
            label4.Text = "Total payment";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(288, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 43);
            textBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 45);
            comboBox1.TabIndex = 18;
            // 
            // AddStoreSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 377);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StoreName);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "AddStoreSaleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStoreSaleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StoreName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
    }
}