namespace RONApp
{
    partial class SaleStoreForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            button1 = new Button();
            updateSaleStoreBtn = new Button();
            deleteSaleStoreBtn = new Button();
            addSaleStoreBtn = new Button();
            labelShopName = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(773, 16);
            button1.Name = "button1";
            button1.Size = new Size(97, 95);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // updateSaleStoreBtn
            // 
            updateSaleStoreBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            updateSaleStoreBtn.Location = new Point(430, 63);
            updateSaleStoreBtn.Name = "updateSaleStoreBtn";
            updateSaleStoreBtn.Size = new Size(196, 48);
            updateSaleStoreBtn.TabIndex = 10;
            updateSaleStoreBtn.Text = "Update Sale";
            updateSaleStoreBtn.UseVisualStyleBackColor = true;
            updateSaleStoreBtn.Click += updateSaleStoreBtn_Click;
            // 
            // deleteSaleStoreBtn
            // 
            deleteSaleStoreBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            deleteSaleStoreBtn.Location = new Point(214, 63);
            deleteSaleStoreBtn.Name = "deleteSaleStoreBtn";
            deleteSaleStoreBtn.Size = new Size(193, 48);
            deleteSaleStoreBtn.TabIndex = 9;
            deleteSaleStoreBtn.Text = "Delete Sale";
            deleteSaleStoreBtn.UseVisualStyleBackColor = true;
            deleteSaleStoreBtn.Click += deleteSaleStoreBtn_Click;
            // 
            // addSaleStoreBtn
            // 
            addSaleStoreBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            addSaleStoreBtn.Location = new Point(14, 63);
            addSaleStoreBtn.Name = "addSaleStoreBtn";
            addSaleStoreBtn.Size = new Size(185, 48);
            addSaleStoreBtn.TabIndex = 8;
            addSaleStoreBtn.Text = "Add Sale";
            addSaleStoreBtn.UseVisualStyleBackColor = true;
            addSaleStoreBtn.Click += addSaleStoreBtn_Click;
            // 
            // labelShopName
            // 
            labelShopName.AutoSize = true;
            labelShopName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelShopName.ForeColor = SystemColors.HotTrack;
            labelShopName.Location = new Point(136, 11);
            labelShopName.Name = "labelShopName";
            labelShopName.Size = new Size(91, 37);
            labelShopName.TabIndex = 12;
            labelShopName.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 41);
            label1.TabIndex = 11;
            label1.Text = "Sales In";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(856, 587);
            dataGridView1.TabIndex = 13;
            // 
            // SaleStoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 733);
            Controls.Add(dataGridView1);
            Controls.Add(labelShopName);
            Controls.Add(label1);
            Controls.Add(updateSaleStoreBtn);
            Controls.Add(deleteSaleStoreBtn);
            Controls.Add(addSaleStoreBtn);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "SaleStoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaleStoreForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button updateSaleStoreBtn;
        private Button deleteSaleStoreBtn;
        private Button addSaleStoreBtn;
        private Label labelShopName;
        private Label label1;
        private DataGridView dataGridView1;
    }
}