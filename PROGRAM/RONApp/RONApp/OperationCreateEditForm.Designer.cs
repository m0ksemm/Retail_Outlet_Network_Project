namespace RONApp
{
    partial class OperationCreateEditForm
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ProductNames = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20F);
            label5.Location = new Point(156, 9);
            label5.Name = "label5";
            label5.Size = new Size(222, 31);
            label5.TabIndex = 9;
            label5.Text = "Create Operation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(11, 183);
            label3.Name = "label3";
            label3.Size = new Size(74, 37);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(11, 125);
            label2.Name = "label2";
            label2.Size = new Size(119, 37);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 5;
            label1.Text = "Product Name";
            // 
            // ProductNames
            // 
            ProductNames.Font = new Font("Segoe UI", 18F);
            ProductNames.FormattingEnabled = true;
            ProductNames.Location = new Point(205, 66);
            ProductNames.Name = "ProductNames";
            ProductNames.Size = new Size(294, 40);
            ProductNames.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(205, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 39);
            textBox1.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe UI", 22F);
            button2.Location = new Point(730, 159);
            button2.Name = "button2";
            button2.Size = new Size(215, 68);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(730, 66);
            button1.Name = "button1";
            button1.Size = new Size(215, 70);
            button1.TabIndex = 17;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 18F);
            numericUpDown1.Location = new Point(205, 123);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 39);
            numericUpDown1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(12, 239);
            label4.Name = "label4";
            label4.Size = new Size(66, 37);
            label4.TabIndex = 20;
            label4.Text = "Sale";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(205, 240);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(740, 40);
            comboBox1.TabIndex = 21;
            // 
            // OperationCreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 296);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ProductNames);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "OperationCreateEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OperationCreateEditForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox ProductNames;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private ComboBox comboBox1;
    }
}