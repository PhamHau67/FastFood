namespace DuAnMau
{
    partial class Frm_employeeManager
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
            this.txt_NameStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IDStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Gmail = new System.Windows.Forms.Label();
            this.lbl_SignUpDay = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_Gentle = new System.Windows.Forms.Label();
            this.lbl_IDDepartment = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.lbl_IDRole = new System.Windows.Forms.Label();
            this.lbl_NameStaff = new System.Windows.Forms.Label();
            this.lbl_IDStaff = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.txt_CCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IDDepartment = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_IDRole = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_Birthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NameStaff
            // 
            this.txt_NameStaff.BorderRadius = 20;
            this.txt_NameStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameStaff.DefaultText = "Nhập tên nhân viên";
            this.txt_NameStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NameStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NameStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NameStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NameStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NameStaff.Location = new System.Drawing.Point(24, 486);
            this.txt_NameStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NameStaff.Name = "txt_NameStaff";
            this.txt_NameStaff.PasswordChar = '\0';
            this.txt_NameStaff.PlaceholderText = "";
            this.txt_NameStaff.SelectedText = "";
            this.txt_NameStaff.Size = new System.Drawing.Size(229, 48);
            this.txt_NameStaff.TabIndex = 17;
            // 
            // txt_IDStaff
            // 
            this.txt_IDStaff.BorderRadius = 20;
            this.txt_IDStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDStaff.DefaultText = "Nhập mã nhân viên";
            this.txt_IDStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IDStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDStaff.Location = new System.Drawing.Point(24, 396);
            this.txt_IDStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDStaff.Name = "txt_IDStaff";
            this.txt_IDStaff.PasswordChar = '\0';
            this.txt_IDStaff.PlaceholderText = "";
            this.txt_IDStaff.SelectedText = "";
            this.txt_IDStaff.Size = new System.Drawing.Size(229, 48);
            this.txt_IDStaff.TabIndex = 16;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(912, 457);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(84, 20);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "Trạng thái";
            // 
            // lbl_Gmail
            // 
            this.lbl_Gmail.AutoSize = true;
            this.lbl_Gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gmail.Location = new System.Drawing.Point(729, 599);
            this.lbl_Gmail.Name = "lbl_Gmail";
            this.lbl_Gmail.Size = new System.Drawing.Size(53, 20);
            this.lbl_Gmail.TabIndex = 6;
            this.lbl_Gmail.Text = "Gmail";
            // 
            // lbl_SignUpDay
            // 
            this.lbl_SignUpDay.AutoSize = true;
            this.lbl_SignUpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignUpDay.Location = new System.Drawing.Point(729, 457);
            this.lbl_SignUpDay.Name = "lbl_SignUpDay";
            this.lbl_SignUpDay.Size = new System.Drawing.Size(105, 20);
            this.lbl_SignUpDay.TabIndex = 7;
            this.lbl_SignUpDay.Text = "Ngày đăng kí";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(555, 599);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(106, 20);
            this.lbl_PhoneNumber.TabIndex = 8;
            this.lbl_PhoneNumber.Text = "Số điện thoại";
            // 
            // lbl_Gentle
            // 
            this.lbl_Gentle.AutoSize = true;
            this.lbl_Gentle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gentle.Location = new System.Drawing.Point(660, 503);
            this.lbl_Gentle.Name = "lbl_Gentle";
            this.lbl_Gentle.Size = new System.Drawing.Size(71, 20);
            this.lbl_Gentle.TabIndex = 9;
            this.lbl_Gentle.Text = "Giới tính";
            // 
            // lbl_IDDepartment
            // 
            this.lbl_IDDepartment.AutoSize = true;
            this.lbl_IDDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDDepartment.Location = new System.Drawing.Point(60, 641);
            this.lbl_IDDepartment.Name = "lbl_IDDepartment";
            this.lbl_IDDepartment.Size = new System.Drawing.Size(96, 20);
            this.lbl_IDDepartment.TabIndex = 10;
            this.lbl_IDDepartment.Text = "Mã bộ phận";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(353, 462);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(83, 20);
            this.lbl_Birthday.TabIndex = 11;
            this.lbl_Birthday.Text = "Ngày sinh";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CCCD.Location = new System.Drawing.Point(60, 547);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(58, 20);
            this.lbl_CCCD.TabIndex = 12;
            this.lbl_CCCD.Text = "CCCD";
            // 
            // lbl_IDRole
            // 
            this.lbl_IDRole.AutoSize = true;
            this.lbl_IDRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDRole.Location = new System.Drawing.Point(353, 372);
            this.lbl_IDRole.Name = "lbl_IDRole";
            this.lbl_IDRole.Size = new System.Drawing.Size(83, 20);
            this.lbl_IDRole.TabIndex = 13;
            this.lbl_IDRole.Text = "Mã vai trò";
            // 
            // lbl_NameStaff
            // 
            this.lbl_NameStaff.AutoSize = true;
            this.lbl_NameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameStaff.Location = new System.Drawing.Point(60, 462);
            this.lbl_NameStaff.Name = "lbl_NameStaff";
            this.lbl_NameStaff.Size = new System.Drawing.Size(113, 20);
            this.lbl_NameStaff.TabIndex = 14;
            this.lbl_NameStaff.Text = "Tên nhân viên";
            // 
            // lbl_IDStaff
            // 
            this.lbl_IDStaff.AutoSize = true;
            this.lbl_IDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDStaff.Location = new System.Drawing.Point(60, 372);
            this.lbl_IDStaff.Name = "lbl_IDStaff";
            this.lbl_IDStaff.Size = new System.Drawing.Size(108, 20);
            this.lbl_IDStaff.TabIndex = 15;
            this.lbl_IDStaff.Text = "Mã nhân viên";
            // 
            // dgv_staff
            // 
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(12, 12);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.RowTemplate.Height = 24;
            this.dgv_staff.Size = new System.Drawing.Size(1095, 343);
            this.dgv_staff.TabIndex = 4;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderRadius = 20;
            this.txt_CCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CCCD.DefaultText = "Nhập số CCCD";
            this.txt_CCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CCCD.Location = new System.Drawing.Point(24, 571);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.PasswordChar = '\0';
            this.txt_CCCD.PlaceholderText = "";
            this.txt_CCCD.SelectedText = "";
            this.txt_CCCD.Size = new System.Drawing.Size(229, 48);
            this.txt_CCCD.TabIndex = 18;
            // 
            // txt_IDDepartment
            // 
            this.txt_IDDepartment.BorderRadius = 20;
            this.txt_IDDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDDepartment.DefaultText = "Nhập mã bộ phận";
            this.txt_IDDepartment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDDepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDDepartment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IDDepartment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDDepartment.Location = new System.Drawing.Point(24, 665);
            this.txt_IDDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDDepartment.Name = "txt_IDDepartment";
            this.txt_IDDepartment.PasswordChar = '\0';
            this.txt_IDDepartment.PlaceholderText = "";
            this.txt_IDDepartment.SelectedText = "";
            this.txt_IDDepartment.Size = new System.Drawing.Size(229, 48);
            this.txt_IDDepartment.TabIndex = 19;
            // 
            // txt_IDRole
            // 
            this.txt_IDRole.BorderRadius = 20;
            this.txt_IDRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDRole.DefaultText = "Nhập mã vai trò";
            this.txt_IDRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IDRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDRole.Location = new System.Drawing.Point(340, 396);
            this.txt_IDRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDRole.Name = "txt_IDRole";
            this.txt_IDRole.PasswordChar = '\0';
            this.txt_IDRole.PlaceholderText = "";
            this.txt_IDRole.SelectedText = "";
            this.txt_IDRole.Size = new System.Drawing.Size(229, 48);
            this.txt_IDRole.TabIndex = 20;
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.BorderRadius = 20;
            this.dtp_Birthday.Checked = true;
            this.dtp_Birthday.FillColor = System.Drawing.Color.Transparent;
            this.dtp_Birthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_Birthday.Location = new System.Drawing.Point(340, 498);
            this.dtp_Birthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Birthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(229, 36);
            this.dtp_Birthday.TabIndex = 21;
            this.dtp_Birthday.Value = new System.DateTime(2024, 5, 19, 22, 37, 7, 593);
            // 
            // Frm_employeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 853);
            this.Controls.Add(this.dtp_Birthday);
            this.Controls.Add(this.txt_IDRole);
            this.Controls.Add(this.txt_IDDepartment);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.txt_NameStaff);
            this.Controls.Add(this.txt_IDStaff);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Gmail);
            this.Controls.Add(this.lbl_SignUpDay);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.lbl_Gentle);
            this.Controls.Add(this.lbl_IDDepartment);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_CCCD);
            this.Controls.Add(this.lbl_IDRole);
            this.Controls.Add(this.lbl_NameStaff);
            this.Controls.Add(this.lbl_IDStaff);
            this.Controls.Add(this.dgv_staff);
            this.Name = "Frm_employeeManager";
            this.Text = "Frm_employeeManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_NameStaff;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDStaff;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Gmail;
        private System.Windows.Forms.Label lbl_SignUpDay;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_Gentle;
        private System.Windows.Forms.Label lbl_IDDepartment;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.Label lbl_IDRole;
        private System.Windows.Forms.Label lbl_NameStaff;
        private System.Windows.Forms.Label lbl_IDStaff;
        private System.Windows.Forms.DataGridView dgv_staff;
        private Guna.UI2.WinForms.Guna2TextBox txt_CCCD;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDDepartment;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDRole;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Birthday;
    }
}