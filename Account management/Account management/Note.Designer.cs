namespace Account_management
{
    partial class Note
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
            this.closeN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.id = new System.Windows.Forms.TextBox();
            this.IDdata = new System.Windows.Forms.Label();
            this.ctgry = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.TextBox();
            this.Create = new Guna.UI2.WinForms.Guna2Button();
            this.tlph = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.log = new FontAwesome.Sharp.IconButton();
            this.home = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.show = new FontAwesome.Sharp.IconButton();
            this.akun = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.pnldata = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeN
            // 
            this.closeN.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeN.FlatAppearance.BorderSize = 0;
            this.closeN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeN.ForeColor = System.Drawing.Color.White;
            this.closeN.Location = new System.Drawing.Point(860, 3);
            this.closeN.Name = "closeN";
            this.closeN.Size = new System.Drawing.Size(37, 35);
            this.closeN.TabIndex = 0;
            this.closeN.Text = "X";
            this.closeN.UseVisualStyleBackColor = true;
            this.closeN.Click += new System.EventHandler(this.closeN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.closeN, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(211, 54);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id.Size = new System.Drawing.Size(156, 23);
            this.id.TabIndex = 12;
            // 
            // IDdata
            // 
            this.IDdata.AutoSize = true;
            this.IDdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDdata.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDdata.ForeColor = System.Drawing.Color.White;
            this.IDdata.Location = new System.Drawing.Point(211, 34);
            this.IDdata.Name = "IDdata";
            this.IDdata.Size = new System.Drawing.Size(20, 17);
            this.IDdata.TabIndex = 11;
            this.IDdata.Text = "ID";
            // 
            // ctgry
            // 
            this.ctgry.Items.AddRange(new object[] {
            "Media Sosial",
            "Academic",
            "Ttechnical ",
            "Emails",
            "Other"});
            this.ctgry.Location = new System.Drawing.Point(522, 190);
            this.ctgry.Name = "ctgry";
            this.ctgry.Size = new System.Drawing.Size(156, 23);
            this.ctgry.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deskripsi);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.IDdata);
            this.panel1.Controls.Add(this.ctgry);
            this.panel1.Controls.Add(this.Create);
            this.panel1.Controls.Add(this.tlph);
            this.panel1.Controls.Add(this.mail);
            this.panel1.Controls.Add(this.passwd);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 559);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Deskripsi";
            // 
            // deskripsi
            // 
            this.deskripsi.Location = new System.Drawing.Point(211, 234);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deskripsi.Size = new System.Drawing.Size(156, 23);
            this.deskripsi.TabIndex = 13;
            // 
            // Create
            // 
            this.Create.BorderRadius = 18;
            this.Create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Create.FillColor = System.Drawing.Color.Green;
            this.Create.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create.ForeColor = System.Drawing.Color.White;
            this.Create.Location = new System.Drawing.Point(211, 322);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(151, 37);
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // tlph
            // 
            this.tlph.Location = new System.Drawing.Point(211, 117);
            this.tlph.Name = "tlph";
            this.tlph.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlph.Size = new System.Drawing.Size(156, 23);
            this.tlph.TabIndex = 8;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(522, 70);
            this.mail.Name = "mail";
            this.mail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mail.Size = new System.Drawing.Size(156, 23);
            this.mail.TabIndex = 7;
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(211, 174);
            this.passwd.Name = "passwd";
            this.passwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwd.Size = new System.Drawing.Size(156, 23);
            this.passwd.TabIndex = 6;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(522, 133);
            this.user.Name = "user";
            this.user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user.Size = new System.Drawing.Size(156, 23);
            this.user.TabIndex = 5;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Location = new System.Drawing.Point(522, 170);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(63, 17);
            this.category.TabIndex = 4;
            this.category.Text = "Category";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phone.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(211, 97);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(44, 17);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.email.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(522, 47);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(37, 17);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(211, 151);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(63, 17);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Username.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(522, 113);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(66, 17);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // log
            // 
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.log.IconColor = System.Drawing.Color.White;
            this.log.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log.IconSize = 60;
            this.log.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log.Location = new System.Drawing.Point(3, 3);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(163, 96);
            this.log.TabIndex = 2;
            this.log.Text = "Management Account";
            this.log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.log.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home.IconColor = System.Drawing.Color.Azure;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.IconSize = 30;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(3, 105);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(163, 47);
            this.home.TabIndex = 2;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Neos;
            this.iconButton1.IconColor = System.Drawing.Color.Azure;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 158);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(163, 51);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Notes";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // show
            // 
            this.show.FlatAppearance.BorderSize = 0;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.IconChar = FontAwesome.Sharp.IconChar.List;
            this.show.IconColor = System.Drawing.Color.Azure;
            this.show.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.show.IconSize = 30;
            this.show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show.Location = new System.Drawing.Point(3, 215);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(163, 54);
            this.show.TabIndex = 4;
            this.show.Text = "Show ";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // akun
            // 
            this.akun.FlatAppearance.BorderSize = 0;
            this.akun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.akun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.akun.ForeColor = System.Drawing.Color.White;
            this.akun.IconChar = FontAwesome.Sharp.IconChar.User;
            this.akun.IconColor = System.Drawing.Color.Azure;
            this.akun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.akun.IconSize = 30;
            this.akun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.akun.Location = new System.Drawing.Point(3, 338);
            this.akun.Name = "akun";
            this.akun.Size = new System.Drawing.Size(163, 57);
            this.akun.TabIndex = 5;
            this.akun.Text = "Account";
            this.akun.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.flowLayoutPanel1.Controls.Add(this.log);
            this.flowLayoutPanel1.Controls.Add(this.home);
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Controls.Add(this.show);
            this.flowLayoutPanel1.Controls.Add(this.btnCategory);
            this.flowLayoutPanel1.Controls.Add(this.akun);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 600);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.Centos;
            this.btnCategory.IconColor = System.Drawing.Color.Azure;
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategory.IconSize = 30;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(3, 275);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(163, 57);
            this.btnCategory.TabIndex = 6;
            this.btnCategory.Text = "Cetegory";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // pnldata
            // 
            this.pnldata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(2)))), ((int)(((byte)(73)))));
            this.pnldata.Controls.Add(this.panel1);
            this.pnldata.Controls.Add(this.tableLayoutPanel1);
            this.pnldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldata.Location = new System.Drawing.Point(0, 0);
            this.pnldata.Name = "pnldata";
            this.pnldata.Size = new System.Drawing.Size(900, 600);
            this.pnldata.TabIndex = 7;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnldata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Note";
            this.Text = "Note";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnldata.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button closeN;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox id;
        private Label IDdata;
        private ComboBox ctgry;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Create;
        private TextBox tlph;
        private TextBox mail;
        private TextBox passwd;
        private TextBox user;
        private Label category;
        private Label phone;
        private Label email;
        private Label password;
        private Label Username;
        private FontAwesome.Sharp.IconButton log;
        private FontAwesome.Sharp.IconButton home;
        public FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton show;
        private FontAwesome.Sharp.IconButton akun;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnldata;
        private Label label1;
        private TextBox deskripsi;
        private FontAwesome.Sharp.IconButton btnCategory;
    }
}