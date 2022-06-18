namespace Account_management
{
    partial class Dasboard
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.log = new FontAwesome.Sharp.IconButton();
            this.home = new FontAwesome.Sharp.IconButton();
            this.notes = new FontAwesome.Sharp.IconButton();
            this.show = new FontAwesome.Sharp.IconButton();
            this.akun = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closeN = new System.Windows.Forms.Button();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.pnldata = new System.Windows.Forms.Panel();
            this.ProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnldata.SuspendLayout();
            this.ProgressBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.flowLayoutPanel1.Controls.Add(this.log);
            this.flowLayoutPanel1.Controls.Add(this.home);
            this.flowLayoutPanel1.Controls.Add(this.notes);
            this.flowLayoutPanel1.Controls.Add(this.show);
            this.flowLayoutPanel1.Controls.Add(this.akun);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 560);
            this.flowLayoutPanel1.TabIndex = 3;
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
            this.show.Location = new System.Drawing.Point(3, 212);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(163, 54);
            this.show.TabIndex = 4;
            this.show.Text = "Show ";
            this.show.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 40);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.closeN.Size = new System.Drawing.Size(37, 34);
            this.closeN.TabIndex = 1;
            this.closeN.Text = "X";
            this.closeN.UseVisualStyleBackColor = true;
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // pnldata
            // 
            this.pnldata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.pnldata.Controls.Add(this.ProgressBar1);
            this.pnldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldata.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnldata.Location = new System.Drawing.Point(0, 0);
            this.pnldata.Name = "pnldata";
            this.pnldata.Size = new System.Drawing.Size(900, 600);
            this.pnldata.TabIndex = 5;
            this.pnldata.Paint += new System.Windows.Forms.PaintEventHandler(this.pnldata_Paint);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar1.Controls.Add(this.panel1);
            this.ProgressBar1.Controls.Add(this.iconButton1);
            this.ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.ProgressBar1.Location = new System.Drawing.Point(366, 66);
            this.ProgressBar1.Minimum = 0;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.ProgressBar1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.ProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBar1.Size = new System.Drawing.Size(221, 221);
            this.ProgressBar1.TabIndex = 3;
            this.ProgressBar1.TabStop = false;
            this.ProgressBar1.Text = "ProgressBar1";
            this.ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBar1.ValueChanged += new System.EventHandler(this.ProgressBar1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.panel1.Location = new System.Drawing.Point(84, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 44);
            this.panel1.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 60;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(29, 63);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(150, 89);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Management Account";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnldata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dasboard";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dasboard";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnldata.ResumeLayout(false);
            this.ProgressBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton log;
        private FontAwesome.Sharp.IconButton home;
        public FontAwesome.Sharp.IconButton notes;
        private FontAwesome.Sharp.IconButton show;
        private FontAwesome.Sharp.IconButton akun;
        private TableLayoutPanel tableLayoutPanel1;
        private Button closeN;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Panel pnldata;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}