namespace Account_management
{
    partial class list
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeN = new System.Windows.Forms.Button();
            this.pnldata = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_user = new System.Windows.Forms.TextBox();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.edit = new Guna.UI2.WinForms.Guna2Button();
            this.log = new FontAwesome.Sharp.IconButton();
            this.home = new FontAwesome.Sharp.IconButton();
            this.notes = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.akun = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnldata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.closeN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 39);
            this.panel1.TabIndex = 0;
            // 
            // closeN
            // 
            this.closeN.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeN.FlatAppearance.BorderSize = 0;
            this.closeN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeN.ForeColor = System.Drawing.Color.White;
            this.closeN.Location = new System.Drawing.Point(697, 0);
            this.closeN.Name = "closeN";
            this.closeN.Size = new System.Drawing.Size(37, 39);
            this.closeN.TabIndex = 2;
            this.closeN.Text = "X";
            this.closeN.UseVisualStyleBackColor = true;
            this.closeN.Click += new System.EventHandler(this.closeN_Click);
            // 
            // pnldata
            // 
            this.pnldata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.pnldata.Controls.Add(this.DataGridView1);
            this.pnldata.Controls.Add(this.label5);
            this.pnldata.Controls.Add(this.label4);
            this.pnldata.Controls.Add(this.label3);
            this.pnldata.Controls.Add(this.label2);
            this.pnldata.Controls.Add(this.deskripsi);
            this.pnldata.Controls.Add(this.category);
            this.pnldata.Controls.Add(this.label7);
            this.pnldata.Controls.Add(this.label6);
            this.pnldata.Controls.Add(this.Password);
            this.pnldata.Controls.Add(this.user);
            this.pnldata.Controls.Add(this.contact);
            this.pnldata.Controls.Add(this.email);
            this.pnldata.Controls.Add(this.label1);
            this.pnldata.Controls.Add(this.id_user);
            this.pnldata.Controls.Add(this.delete);
            this.pnldata.Controls.Add(this.edit);
            this.pnldata.Controls.Add(this.panel1);
            this.pnldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldata.Location = new System.Drawing.Point(166, 0);
            this.pnldata.Name = "pnldata";
            this.pnldata.Size = new System.Drawing.Size(734, 600);
            this.pnldata.TabIndex = 7;
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(-1, 36);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(734, 285);
            this.DataGridView1.TabIndex = 39;
            this.DataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(143, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(432, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(428, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Password";
            // 
            // deskripsi
            // 
            this.deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deskripsi.Location = new System.Drawing.Point(534, 534);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(168, 23);
            this.deskripsi.TabIndex = 34;
            // 
            // category
            // 
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category.Location = new System.Drawing.Point(534, 492);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(168, 23);
            this.category.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(432, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Deskripsi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(428, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Category ";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(534, 443);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(168, 23);
            this.Password.TabIndex = 10;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(534, 395);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(168, 23);
            this.user.TabIndex = 9;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(228, 516);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(151, 23);
            this.contact.TabIndex = 8;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(228, 460);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(151, 23);
            this.email.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID_User";
            // 
            // id_user
            // 
            this.id_user.Location = new System.Drawing.Point(228, 395);
            this.id_user.Name = "id_user";
            this.id_user.Size = new System.Drawing.Size(151, 23);
            this.id_user.TabIndex = 5;
            // 
            // delete
            // 
            this.delete.BorderRadius = 20;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(31, 443);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(95, 40);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BorderRadius = 20;
            this.edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(31, 386);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(95, 40);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit";
            this.edit.Click += new System.EventHandler(this.edit_Click);
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
            this.log.Size = new System.Drawing.Size(163, 93);
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
            this.home.Location = new System.Drawing.Point(3, 102);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(163, 47);
            this.home.TabIndex = 2;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // notes
            // 
            this.notes.FlatAppearance.BorderSize = 0;
            this.notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notes.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.notes.ForeColor = System.Drawing.Color.White;
            this.notes.IconChar = FontAwesome.Sharp.IconChar.Neos;
            this.notes.IconColor = System.Drawing.Color.Azure;
            this.notes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.notes.IconSize = 30;
            this.notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notes.Location = new System.Drawing.Point(3, 155);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(163, 51);
            this.notes.TabIndex = 3;
            this.notes.Text = "Notes";
            this.notes.UseVisualStyleBackColor = true;
            this.notes.Click += new System.EventHandler(this.notes_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.Azure;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 212);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(163, 54);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Show ";
            this.iconButton1.UseVisualStyleBackColor = true;
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
            this.akun.Location = new System.Drawing.Point(3, 272);
            this.akun.Name = "akun";
            this.akun.Size = new System.Drawing.Size(163, 57);
            this.akun.TabIndex = 5;
            this.akun.Text = "Account";
            this.akun.UseVisualStyleBackColor = true;
            this.akun.Click += new System.EventHandler(this.akun_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.flowLayoutPanel1.Controls.Add(this.log);
            this.flowLayoutPanel1.Controls.Add(this.home);
            this.flowLayoutPanel1.Controls.Add(this.notes);
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Controls.Add(this.akun);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 600);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnldata);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list";
            this.Load += new System.EventHandler(this.list_Load);
            this.panel1.ResumeLayout(false);
            this.pnldata.ResumeLayout(false);
            this.pnldata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button closeN;
        private Panel pnldata;
        private FontAwesome.Sharp.IconButton log;
        private FontAwesome.Sharp.IconButton home;
        public FontAwesome.Sharp.IconButton notes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton akun;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox id_user;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button edit;
        private TextBox Password;
        private TextBox user;
        private TextBox contact;
        private TextBox email;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox deskripsi;
        private TextBox category;
        private Label label7;
        private Label label6;
        private DataGridView DataGridView1;
    }
}