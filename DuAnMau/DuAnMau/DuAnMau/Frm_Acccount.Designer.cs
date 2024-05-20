namespace DuAnMau
{
    partial class Frm_Acccount
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.grp_timKiem = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_repair = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.grb_chucNang = new System.Windows.Forms.GroupBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cbx_Role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Gmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Account = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.grp_thongTin = new System.Windows.Forms.GroupBox();
            this.txt_AccountID = new Guna.UI2.WinForms.Guna2TextBox();
            this.grp_timKiem.SuspendLayout();
            this.grb_chucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.grp_thongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(27, 33);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(447, 31);
            this.txt_search.TabIndex = 5;
            // 
            // grp_timKiem
            // 
            this.grp_timKiem.Controls.Add(this.btn_search);
            this.grp_timKiem.Controls.Add(this.txt_search);
            this.grp_timKiem.Location = new System.Drawing.Point(839, 784);
            this.grp_timKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_timKiem.Name = "grp_timKiem";
            this.grp_timKiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_timKiem.Size = new System.Drawing.Size(599, 86);
            this.grp_timKiem.TabIndex = 12;
            this.grp_timKiem.TabStop = false;
            this.grp_timKiem.Text = "Tìm kiếm";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(501, 33);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 31);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(317, 36);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(91, 28);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(211, 36);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(71, 28);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_repair
            // 
            this.btn_repair.Location = new System.Drawing.Point(107, 36);
            this.btn_repair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Size = new System.Drawing.Size(71, 28);
            this.btn_repair.TabIndex = 0;
            this.btn_repair.Text = "Sửa";
            this.btn_repair.UseVisualStyleBackColor = true;
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(5, 36);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(71, 28);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm ";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // grb_chucNang
            // 
            this.grb_chucNang.Controls.Add(this.btn_refresh);
            this.grb_chucNang.Controls.Add(this.btn_delete);
            this.grb_chucNang.Controls.Add(this.btn_repair);
            this.grb_chucNang.Controls.Add(this.btn_add);
            this.grb_chucNang.Location = new System.Drawing.Point(402, 784);
            this.grb_chucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_chucNang.Name = "grb_chucNang";
            this.grb_chucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_chucNang.Size = new System.Drawing.Size(431, 86);
            this.grb_chucNang.TabIndex = 11;
            this.grb_chucNang.TabStop = false;
            this.grb_chucNang.Text = "Chỉnh Sửa";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(120, 81);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(297, 31);
            this.txt_Password.TabIndex = 2;
            // 
            // cbx_Role
            // 
            this.cbx_Role.FormattingEnabled = true;
            this.cbx_Role.Items.AddRange(new object[] {
            "Quản lí",
            "Nhân viên ",
            "Admin"});
            this.cbx_Role.Location = new System.Drawing.Point(731, 153);
            this.cbx_Role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Role.Name = "cbx_Role";
            this.cbx_Role.Size = new System.Drawing.Size(297, 24);
            this.cbx_Role.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gmail";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(732, 27);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(297, 22);
            this.txt_Username.TabIndex = 2;
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Location = new System.Drawing.Point(731, 90);
            this.txt_EmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(297, 22);
            this.txt_EmployeeID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Nhân viên";
            // 
            // txt_Gmail
            // 
            this.txt_Gmail.Location = new System.Drawing.Point(120, 153);
            this.txt_Gmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Gmail.Multiline = true;
            this.txt_Gmail.Name = "txt_Gmail";
            this.txt_Gmail.Size = new System.Drawing.Size(297, 31);
            this.txt_Gmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // dgv_Account
            // 
            this.dgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account.Location = new System.Drawing.Point(402, 222);
            this.dgv_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.RowHeadersWidth = 51;
            this.dgv_Account.RowTemplate.Height = 24;
            this.dgv_Account.Size = new System.Drawing.Size(1036, 558);
            this.dgv_Account.TabIndex = 9;
            this.dgv_Account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Accout_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(209)))), ((int)(((byte)(152)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 884);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vai Trò";
            // 
            // grp_thongTin
            // 
            this.grp_thongTin.Controls.Add(this.txt_AccountID);
            this.grp_thongTin.Controls.Add(this.txt_Password);
            this.grp_thongTin.Controls.Add(this.cbx_Role);
            this.grp_thongTin.Controls.Add(this.label6);
            this.grp_thongTin.Controls.Add(this.txt_Username);
            this.grp_thongTin.Controls.Add(this.label5);
            this.grp_thongTin.Controls.Add(this.txt_EmployeeID);
            this.grp_thongTin.Controls.Add(this.label4);
            this.grp_thongTin.Controls.Add(this.txt_Gmail);
            this.grp_thongTin.Controls.Add(this.label3);
            this.grp_thongTin.Controls.Add(this.label1);
            this.grp_thongTin.Controls.Add(this.label2);
            this.grp_thongTin.Location = new System.Drawing.Point(402, 12);
            this.grp_thongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_thongTin.Name = "grp_thongTin";
            this.grp_thongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_thongTin.Size = new System.Drawing.Size(1036, 204);
            this.grp_thongTin.TabIndex = 10;
            this.grp_thongTin.TabStop = false;
            this.grp_thongTin.Text = "Thông tin tài khoản";
            // 
            // txt_AccountID
            // 
            this.txt_AccountID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AccountID.DefaultText = "";
            this.txt_AccountID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AccountID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AccountID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AccountID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AccountID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AccountID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_AccountID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AccountID.Location = new System.Drawing.Point(120, 17);
            this.txt_AccountID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AccountID.Name = "txt_AccountID";
            this.txt_AccountID.PasswordChar = '\0';
            this.txt_AccountID.PlaceholderText = "Mã tài khoản";
            this.txt_AccountID.SelectedText = "";
            this.txt_AccountID.ShadowDecoration.BorderRadius = 9;
            this.txt_AccountID.Size = new System.Drawing.Size(297, 31);
            this.txt_AccountID.TabIndex = 5;
            // 
            // Frm_Acccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 884);
            this.Controls.Add(this.grp_timKiem);
            this.Controls.Add(this.grb_chucNang);
            this.Controls.Add(this.dgv_Account);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grp_thongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Acccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Acccount";
            this.grp_timKiem.ResumeLayout(false);
            this.grp_timKiem.PerformLayout();
            this.grb_chucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.grp_thongTin.ResumeLayout(false);
            this.grp_thongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox grp_timKiem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_repair;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox grb_chucNang;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.ComboBox cbx_Role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Gmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Account;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grp_thongTin;
        private Guna.UI2.WinForms.Guna2TextBox txt_AccountID;
    }
}