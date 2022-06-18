namespace akun_management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pw = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.user = new System.Windows.Forms.TextBox();
            this.paswd = new System.Windows.Forms.TextBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.regis = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(-131, -93);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(264, 247);
            this.guna2CircleButton2.TabIndex = 1;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 20;
            this.guna2GradientButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.Location = new System.Drawing.Point(275, 235);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(241, 86);
            this.guna2GradientButton1.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(224, 35);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(207, 27);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Account Management ";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.username.Location = new System.Drawing.Point(156, 82);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 23);
            this.username.TabIndex = 4;
            this.username.Text = "Username";
            // 
            // pw
            // 
            this.pw.BackColor = System.Drawing.Color.Transparent;
            this.pw.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pw.Location = new System.Drawing.Point(156, 131);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(78, 23);
            this.pw.TabIndex = 5;
            this.pw.Text = "Password";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(253, 82);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(178, 23);
            this.user.TabIndex = 6;
            // 
            // paswd
            // 
            this.paswd.Location = new System.Drawing.Point(253, 131);
            this.paswd.Name = "paswd";
            this.paswd.Size = new System.Drawing.Size(178, 23);
            this.paswd.TabIndex = 7;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.BorderRadius = 18;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.btnlogin.Location = new System.Drawing.Point(113, 190);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(91, 39);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "Login";
            this.btnlogin.MouseEnter += new System.EventHandler(this.btnlogin_MouseEnter);
            this.btnlogin.MouseLeave += new System.EventHandler(this.btnlogin_MouseLeave);
            // 
            // regis
            // 
            this.regis.BackColor = System.Drawing.Color.White;
            this.regis.BorderRadius = 18;
            this.regis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.regis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.regis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.regis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.regis.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.regis.Location = new System.Drawing.Point(224, 190);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(119, 39);
            this.regis.TabIndex = 9;
            this.regis.Text = "Register";
            this.regis.MouseEnter += new System.EventHandler(this.regis_MouseEnter);
            this.regis.MouseLeave += new System.EventHandler(this.regis_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 296);
            this.Controls.Add(this.regis);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.paswd);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.username);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2CircleButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel username;
        private Guna.UI2.WinForms.Guna2HtmlLabel pw;
        private TextBox user;
        private TextBox paswd;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Guna.UI2.WinForms.Guna2Button regis;
    }
}