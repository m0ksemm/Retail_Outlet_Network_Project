namespace RONApp
{
    partial class InventoryStoreForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            addProductStoreBtn = new Button();
            deleteProductStoreBtn = new Button();
            updateProductStoreBtn = new Button();
            labelShopName = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(858, 595);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 41);
            label1.TabIndex = 1;
            label1.Text = "Products In";
            // 
            // addProductStoreBtn
            // 
            addProductStoreBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            addProductStoreBtn.Location = new Point(12, 59);
            addProductStoreBtn.Name = "addProductStoreBtn";
            addProductStoreBtn.Size = new Size(185, 48);
            addProductStoreBtn.TabIndex = 2;
            addProductStoreBtn.Text = "Add Product";
            addProductStoreBtn.UseVisualStyleBackColor = true;
            addProductStoreBtn.Click += addProductStoreBtn_Click;
            // 
            // deleteProductStoreBtn
            // 
            deleteProductStoreBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            deleteProductStoreBtn.Location = new Point(212, 59);
            deleteProductStoreBtn.Name = "deleteProductStoreBtn";
            deleteProductStoreBtn.Size = new Size(193, 48);
            deleteProductStoreBtn.TabIndex = 3;
            deleteProductStoreBtn.Text = "Delete Product";
            deleteProductStoreBtn.UseVisualStyleBackColor = true;
            deleteProductStoreBtn.Click += deleteProductStoreBtn_Click;
            // 
            // updateProductStoreBtn
            // 
            updateProductStoreBtn.Font = new Font("Microsoft Sans Serif", 14.25F);
            updateProductStoreBtn.Location = new Point(428, 59);
            updateProductStoreBtn.Name = "updateProductStoreBtn";
            updateProductStoreBtn.Size = new Size(196, 48);
            updateProductStoreBtn.TabIndex = 4;
            updateProductStoreBtn.Text = "Update Product";
            updateProductStoreBtn.UseVisualStyleBackColor = true;
            updateProductStoreBtn.Click += updateProductStoreBtn_Click;
            // 
            // labelShopName
            // 
            labelShopName.AutoSize = true;
            labelShopName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelShopName.ForeColor = SystemColors.HotTrack;
            labelShopName.Location = new Point(186, 11);
            labelShopName.Name = "labelShopName";
            labelShopName.Size = new Size(91, 37);
            labelShopName.TabIndex = 5;
            labelShopName.Text = "label2";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(773, 12);
            button1.Name = "button1";
            button1.Size = new Size(97, 95);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InventoryStoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 731);
            Controls.Add(button1);
            Controls.Add(labelShopName);
            Controls.Add(updateProductStoreBtn);
            Controls.Add(deleteProductStoreBtn);
            Controls.Add(addProductStoreBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "InventoryStoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryStore";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button addProductStoreBtn;
        private Button deleteProductStoreBtn;
        private Button updateProductStoreBtn;
        private Label labelShopName;
        private Button button1;
    }
}