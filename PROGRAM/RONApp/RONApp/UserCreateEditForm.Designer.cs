namespace RONApp
{
    partial class UserCreateEditForm
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
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Roles = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe UI", 22F);
            button2.Location = new Point(340, 346);
            button2.Name = "button2";
            button2.Size = new Size(215, 54);
            button2.TabIndex = 17;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(12, 346);
            button1.Name = "button1";
            button1.Size = new Size(205, 54);
            button1.TabIndex = 16;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(155, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 43);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(224, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 43);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(137, 37);
            label3.TabIndex = 13;
            label3.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(84, 37);
            label2.TabIndex = 12;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 37);
            label1.TabIndex = 11;
            label1.Text = "Add User";
            // 
            // Roles
            // 
            Roles.Font = new Font("Segoe UI", 18F);
            Roles.FormattingEnabled = true;
            Roles.Location = new Point(224, 273);
            Roles.Name = "Roles";
            Roles.Size = new Size(331, 40);
            Roles.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(128, 37);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(12, 272);
            label5.Name = "label5";
            label5.Size = new Size(69, 37);
            label5.TabIndex = 13;
            label5.Text = "Role";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(224, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(331, 43);
            textBox3.TabIndex = 15;
            // 
            // UserCreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 413);
            Controls.Add(Roles);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "UserCreateEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserCreateEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox Roles;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
    }
}