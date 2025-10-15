namespace RONApp
{
    partial class StoreProductCreateEditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            StoreName = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Microsoft Sans Serif", 22F);
            button1.Location = new Point(23, 293);
            button1.Name = "button1";
            button1.Size = new Size(210, 51);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Microsoft Sans Serif", 22F);
            button2.Location = new Point(299, 293);
            button2.Name = "button2";
            button2.Size = new Size(210, 51);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(23, 74);
            label1.Name = "label1";
            label1.Size = new Size(323, 37);
            label1.TabIndex = 2;
            label1.Text = "Add product to Inventory ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(23, 141);
            label2.Name = "label2";
            label2.Size = new Size(109, 37);
            label2.TabIndex = 3;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(23, 219);
            label3.Name = "label3";
            label3.Size = new Size(119, 37);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 20F);
            numericUpDown1.Location = new Point(347, 213);
            numericUpDown1.Margin = new Padding(0);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(162, 43);
            numericUpDown1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(371, 45);
            comboBox1.TabIndex = 6;
            // 
            // StoreName
            // 
            StoreName.AutoSize = true;
            StoreName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            StoreName.ForeColor = SystemColors.Highlight;
            StoreName.Location = new Point(23, 18);
            StoreName.Name = "StoreName";
            StoreName.Size = new Size(92, 37);
            StoreName.TabIndex = 7;
            StoreName.Text = "label4";
            // 
            // StoreProductCreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 361);
            Controls.Add(StoreName);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "StoreProductCreateEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStoreProductForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label StoreName;
    }
}