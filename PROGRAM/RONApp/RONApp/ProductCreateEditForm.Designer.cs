namespace RONApp
{
    partial class ProductCreateEditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            CategoryNames = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(56, 67);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(56, 127);
            label2.Name = "label2";
            label2.Size = new Size(203, 37);
            label2.TabIndex = 1;
            label2.Text = "Category Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(56, 183);
            label3.Name = "label3";
            label3.Size = new Size(74, 37);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(56, 235);
            label4.Name = "label4";
            label4.Size = new Size(66, 37);
            label4.TabIndex = 3;
            label4.Text = "SKU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20F);
            label5.Location = new Point(211, 9);
            label5.Name = "label5";
            label5.Size = new Size(197, 31);
            label5.TabIndex = 4;
            label5.Text = "Create Product";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(311, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F);
            textBox3.Location = new Point(311, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 39);
            textBox3.TabIndex = 8;
            // 
            // CategoryNames
            // 
            CategoryNames.Font = new Font("Segoe UI", 18F);
            CategoryNames.FormattingEnabled = true;
            CategoryNames.Location = new Point(311, 128);
            CategoryNames.Name = "CategoryNames";
            CategoryNames.Size = new Size(263, 40);
            CategoryNames.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(51, 287);
            button1.Name = "button1";
            button1.Size = new Size(192, 58);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe UI", 22F);
            button2.Location = new Point(359, 287);
            button2.Name = "button2";
            button2.Size = new Size(215, 58);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 20F);
            textBox4.Location = new Point(311, 235);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 43);
            textBox4.TabIndex = 12;
            // 
            // ProductCreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 357);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CategoryNames);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ProductCreateEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox CategoryNames;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
    }
}