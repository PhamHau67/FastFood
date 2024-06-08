namespace DuAnMau
{
    partial class Frm_Manage_invoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstv_ChiTietHoaDon = new System.Windows.Forms.ListView();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dt_start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dt_end = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_time = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_odernow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_total = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Summ = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_in = new Guna.UI2.WinForms.Guna2Button();
            this.btn_remove = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_status = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstv_ChiTietHoaDon
            // 
            this.lstv_ChiTietHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_ChiTietHoaDon.HideSelection = false;
            this.lstv_ChiTietHoaDon.Location = new System.Drawing.Point(583, 304);
            this.lstv_ChiTietHoaDon.Name = "lstv_ChiTietHoaDon";
            this.lstv_ChiTietHoaDon.Size = new System.Drawing.Size(510, 378);
            this.lstv_ChiTietHoaDon.TabIndex = 1;
            this.lstv_ChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.Location = new System.Drawing.Point(21, 18);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(99, 23);
            this.lbl_start.TabIndex = 0;
            this.lbl_start.Text = "Date Start";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(21, 74);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(89, 23);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date End";
            // 
            // dt_start
            // 
            this.dt_start.BorderRadius = 15;
            this.dt_start.Checked = true;
            this.dt_start.CustomFormat = "dd/MM/yyyy";
            this.dt_start.FillColor = System.Drawing.Color.LightSalmon;
            this.dt_start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_start.Location = new System.Drawing.Point(205, 3);
            this.dt_start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(187, 36);
            this.dt_start.TabIndex = 2;
            this.dt_start.Value = new System.DateTime(2024, 5, 27, 14, 6, 14, 653);
            // 
            // dt_end
            // 
            this.dt_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.dt_end.BorderRadius = 15;
            this.dt_end.Checked = true;
            this.dt_end.CustomFormat = "dd/MM/yyyy";
            this.dt_end.FillColor = System.Drawing.Color.LightSalmon;
            this.dt_end.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_end.Location = new System.Drawing.Point(205, 61);
            this.dt_end.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_end.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(187, 36);
            this.dt_end.TabIndex = 3;
            this.dt_end.Value = new System.DateTime(2024, 5, 27, 13, 12, 30, 229);
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_HoaDon.Location = new System.Drawing.Point(13, 304);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(543, 378);
            this.dgv_HoaDon.TabIndex = 3;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Location = new System.Drawing.Point(562, 304);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(15, 378);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.guna2Panel2.BorderRadius = 50;
            this.guna2Panel2.Location = new System.Drawing.Point(12, 688);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1080, 17);
            this.guna2Panel2.TabIndex = 5;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.guna2Panel3.BorderRadius = 50;
            this.guna2Panel3.Location = new System.Drawing.Point(13, 281);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1080, 17);
            this.guna2Panel3.TabIndex = 6;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lbl_odernow);
            this.guna2Panel4.Location = new System.Drawing.Point(310, 12);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(533, 70);
            this.guna2Panel4.TabIndex = 7;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = false;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(353, 66);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(527, 94);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "  time";
            // 
            // lbl_odernow
            // 
            this.lbl_odernow.AutoSize = false;
            this.lbl_odernow.BackColor = System.Drawing.Color.Transparent;
            this.lbl_odernow.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_odernow.Location = new System.Drawing.Point(166, 7);
            this.lbl_odernow.Name = "lbl_odernow";
            this.lbl_odernow.Size = new System.Drawing.Size(404, 81);
            this.lbl_odernow.TabIndex = 0;
            this.lbl_odernow.Text = "Invoice";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.guna2Panel5.BorderRadius = 20;
            this.guna2Panel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel5.Controls.Add(this.txt_Search);
            this.guna2Panel5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Location = new System.Drawing.Point(12, 175);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(543, 100);
            this.guna2Panel5.TabIndex = 18;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(13, 3);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(176, 22);
            this.guna2HtmlLabel6.TabIndex = 17;
            this.guna2HtmlLabel6.Text = "Search Product";
            // 
            // txt_Search
            // 
            this.txt_Search.Animated = true;
            this.txt_Search.AutoRoundedCorners = true;
            this.txt_Search.BackColor = System.Drawing.Color.Transparent;
            this.txt_Search.BorderRadius = 16;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(13, 46);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(504, 35);
            this.txt_Search.TabIndex = 14;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.guna2Panel6.BorderRadius = 20;
            this.guna2Panel6.Controls.Add(this.lbl_date);
            this.guna2Panel6.Controls.Add(this.dt_end);
            this.guna2Panel6.Controls.Add(this.dt_start);
            this.guna2Panel6.Controls.Add(this.lbl_start);
            this.guna2Panel6.Location = new System.Drawing.Point(584, 175);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(509, 100);
            this.guna2Panel6.TabIndex = 19;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = false;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(595, 736);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(132, 30);
            this.lbl_total.TabIndex = 21;
            this.lbl_total.Text = "Total Prices";
            // 
            // txt_Summ
            // 
            this.txt_Summ.BorderRadius = 15;
            this.txt_Summ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Summ.DefaultText = "";
            this.txt_Summ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Summ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Summ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Summ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Summ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Summ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Summ.ForeColor = System.Drawing.Color.Red;
            this.txt_Summ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Summ.Location = new System.Drawing.Point(749, 726);
            this.txt_Summ.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_Summ.Name = "txt_Summ";
            this.txt_Summ.PasswordChar = '\0';
            this.txt_Summ.PlaceholderText = "";
            this.txt_Summ.ReadOnly = true;
            this.txt_Summ.SelectedText = "";
            this.txt_Summ.Size = new System.Drawing.Size(253, 40);
            this.txt_Summ.TabIndex = 20;
            // 
            // btn_in
            // 
            this.btn_in.BorderRadius = 15;
            this.btn_in.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_in.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_in.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_in.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_in.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_in.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.ForeColor = System.Drawing.Color.Black;
            this.btn_in.Location = new System.Drawing.Point(310, 721);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(242, 45);
            this.btn_in.TabIndex = 22;
            this.btn_in.Text = "Print";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BorderRadius = 15;
            this.btn_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(13, 721);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(236, 45);
            this.btn_remove.TabIndex = 23;
            this.btn_remove.Text = "Remove";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(595, 803);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(132, 30);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.BorderRadius = 15;
            this.txt_status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_status.DefaultText = "";
            this.txt_status.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_status.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.ForeColor = System.Drawing.Color.Red;
            this.txt_status.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_status.Location = new System.Drawing.Point(749, 793);
            this.txt_status.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_status.Name = "txt_status";
            this.txt_status.PasswordChar = '\0';
            this.txt_status.PlaceholderText = "";
            this.txt_status.ReadOnly = true;
            this.txt_status.SelectedText = "";
            this.txt_status.Size = new System.Drawing.Size(253, 40);
            this.txt_status.TabIndex = 24;
            // 
            // Frm_Manage_invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1105, 857);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_Summ);
            this.Controls.Add(this.guna2Panel6);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.lstv_ChiTietHoaDon);
            this.Name = "Frm_Manage_invoices";
            this.Text = "Frm_Manage_invoices";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstv_ChiTietHoaDon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_end;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_start;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_time;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_odernow;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_total;
        private Guna.UI2.WinForms.Guna2TextBox txt_Summ;
        private Guna.UI2.WinForms.Guna2Button btn_in;
        private Guna.UI2.WinForms.Guna2Button btn_remove;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_status;
    }
}