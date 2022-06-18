namespace Account_management
{
    partial class Edite
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.submit = new Guna.UI2.WinForms.Guna2Button();
            this.deskripsi = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.id_user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(168, 47);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(89, 23);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "Edit Account";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(62, 34);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(100, 54);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.BorderRadius = 18;
            this.submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submit.FillColor = System.Drawing.Color.Blue;
            this.submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(317, 407);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(115, 34);
            this.submit.TabIndex = 31;
            this.submit.Text = "Submite";
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // deskripsi
            // 
            this.deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deskripsi.Location = new System.Drawing.Point(157, 359);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(168, 23);
            this.deskripsi.TabIndex = 30;
            // 
            // category
            // 
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category.Location = new System.Drawing.Point(157, 321);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(168, 23);
            this.category.TabIndex = 29;
            // 
            // contact
            // 
            this.contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contact.Location = new System.Drawing.Point(157, 182);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(168, 23);
            this.contact.TabIndex = 28;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(157, 277);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(168, 23);
            this.password.TabIndex = 27;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(157, 146);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 23);
            this.email.TabIndex = 26;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Location = new System.Drawing.Point(157, 232);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(168, 23);
            this.username.TabIndex = 25;
            // 
            // id_user
            // 
            this.id_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_user.Location = new System.Drawing.Point(157, 107);
            this.id_user.Name = "id_user";
            this.id_user.Size = new System.Drawing.Size(168, 23);
            this.id_user.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Deskripsi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Category ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID Akun";
            // 
            // Edite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(494, 500);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.category);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.id_user);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edite";
            this.Text = "Edite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2Button submit;
        private TextBox deskripsi;
        private TextBox category;
        private TextBox contact;
        private TextBox password;
        private TextBox email;
        private TextBox username;
        private TextBox id_user;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}