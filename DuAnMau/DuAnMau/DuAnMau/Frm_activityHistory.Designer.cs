﻿namespace DuAnMau
{
    partial class Frm_activityHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_LichSu = new System.Windows.Forms.DataGridView();
            this.grp_find = new System.Windows.Forms.GroupBox();
            this.btn_export = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_dateEnd = new System.Windows.Forms.Label();
            this.lbl_dateStart = new System.Windows.Forms.Label();
            this.dtp_end = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_status = new System.Windows.Forms.Label();
            this.dtp_start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_quay = new System.Windows.Forms.Label();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_IDShift = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.cbo_counter = new System.Windows.Forms.ComboBox();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.txt_find = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_IDShift_edit = new System.Windows.Forms.ComboBox();
            this.cbo_IDStaff_edit = new System.Windows.Forms.ComboBox();
            this.dtp_dateWork = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_IDShift_edit = new System.Windows.Forms.Label();
            this.lbl_counter_edit = new System.Windows.Forms.Label();
            this.lbl_IDStaff_edit = new System.Windows.Forms.Label();
            this.lbl_status_edit = new System.Windows.Forms.Label();
            this.lbl_dateWork = new System.Windows.Forms.Label();
            this.chk_status = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbo_counter_edit = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSu)).BeginInit();
            this.grp_find.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LichSu
            // 
            this.dgv_LichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_LichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LichSu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_LichSu.Location = new System.Drawing.Point(2, 414);
            this.dgv_LichSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LichSu.Name = "dgv_LichSu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LichSu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_LichSu.RowHeadersWidth = 62;
            this.dgv_LichSu.RowTemplate.Height = 28;
            this.dgv_LichSu.Size = new System.Drawing.Size(1103, 420);
            this.dgv_LichSu.TabIndex = 0;
            this.dgv_LichSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LichSu_CellClick);
            // 
            // grp_find
            // 
            this.grp_find.Controls.Add(this.btn_export);
            this.grp_find.Controls.Add(this.lbl_dateEnd);
            this.grp_find.Controls.Add(this.lbl_dateStart);
            this.grp_find.Controls.Add(this.dtp_end);
            this.grp_find.Controls.Add(this.lbl_status);
            this.grp_find.Controls.Add(this.dtp_start);
            this.grp_find.Controls.Add(this.lbl_quay);
            this.grp_find.Controls.Add(this.btn_refresh);
            this.grp_find.Controls.Add(this.lbl_IDShift);
            this.grp_find.Controls.Add(this.cbo_status);
            this.grp_find.Controls.Add(this.cbo_counter);
            this.grp_find.Controls.Add(this.cbo_shift);
            this.grp_find.Controls.Add(this.txt_find);
            this.grp_find.Location = new System.Drawing.Point(2, 10);
            this.grp_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_find.Name = "grp_find";
            this.grp_find.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_find.Size = new System.Drawing.Size(1103, 242);
            this.grp_find.TabIndex = 1;
            this.grp_find.TabStop = false;
            this.grp_find.Text = "Finding information";
            // 
            // btn_export
            // 
            this.btn_export.BorderRadius = 10;
            this.btn_export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_export.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.Black;
            this.btn_export.Location = new System.Drawing.Point(696, 185);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(160, 46);
            this.btn_export.TabIndex = 6;
            this.btn_export.Text = "Export excel";
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // lbl_dateEnd
            // 
            this.lbl_dateEnd.AutoSize = true;
            this.lbl_dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateEnd.Location = new System.Drawing.Point(724, 109);
            this.lbl_dateEnd.Name = "lbl_dateEnd";
            this.lbl_dateEnd.Size = new System.Drawing.Size(79, 20);
            this.lbl_dateEnd.TabIndex = 5;
            this.lbl_dateEnd.Text = "Date End";
            // 
            // lbl_dateStart
            // 
            this.lbl_dateStart.AutoSize = true;
            this.lbl_dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateStart.Location = new System.Drawing.Point(724, 46);
            this.lbl_dateStart.Name = "lbl_dateStart";
            this.lbl_dateStart.Size = new System.Drawing.Size(86, 20);
            this.lbl_dateStart.TabIndex = 5;
            this.lbl_dateStart.Text = "Date Start";
            // 
            // dtp_end
            // 
            this.dtp_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.dtp_end.BorderRadius = 15;
            this.dtp_end.Checked = true;
            this.dtp_end.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtp_end.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_end.Location = new System.Drawing.Point(831, 102);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_end.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_end.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(222, 36);
            this.dtp_end.TabIndex = 4;
            this.dtp_end.Value = new System.DateTime(2024, 6, 3, 10, 29, 50, 741);
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(457, 53);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(57, 20);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Status";
            // 
            // dtp_start
            // 
            this.dtp_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.dtp_start.BorderRadius = 15;
            this.dtp_start.Checked = true;
            this.dtp_start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtp_start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_start.Location = new System.Drawing.Point(831, 37);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(222, 36);
            this.dtp_start.TabIndex = 4;
            this.dtp_start.Value = new System.DateTime(2024, 6, 3, 10, 29, 50, 741);
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // lbl_quay
            // 
            this.lbl_quay.AutoSize = true;
            this.lbl_quay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quay.Location = new System.Drawing.Point(242, 53);
            this.lbl_quay.Name = "lbl_quay";
            this.lbl_quay.Size = new System.Drawing.Size(68, 20);
            this.lbl_quay.TabIndex = 2;
            this.lbl_quay.Text = "Counter";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BorderRadius = 10;
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(893, 185);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(160, 46);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click_1);
            // 
            // lbl_IDShift
            // 
            this.lbl_IDShift.AutoSize = true;
            this.lbl_IDShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDShift.Location = new System.Drawing.Point(48, 53);
            this.lbl_IDShift.Name = "lbl_IDShift";
            this.lbl_IDShift.Size = new System.Drawing.Size(65, 20);
            this.lbl_IDShift.TabIndex = 2;
            this.lbl_IDShift.Text = "ID Shift";
            // 
            // cbo_status
            // 
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Location = new System.Drawing.Point(523, 50);
            this.cbo_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(108, 28);
            this.cbo_status.TabIndex = 1;
            // 
            // cbo_counter
            // 
            this.cbo_counter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_counter.FormattingEnabled = true;
            this.cbo_counter.Location = new System.Drawing.Point(320, 50);
            this.cbo_counter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_counter.Name = "cbo_counter";
            this.cbo_counter.Size = new System.Drawing.Size(108, 28);
            this.cbo_counter.TabIndex = 1;
            // 
            // cbo_shift
            // 
            this.cbo_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Location = new System.Drawing.Point(120, 50);
            this.cbo_shift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(108, 28);
            this.cbo_shift.TabIndex = 1;
            // 
            // txt_find
            // 
            this.txt_find.BorderRadius = 20;
            this.txt_find.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_find.DefaultText = "";
            this.txt_find.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_find.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_find.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_find.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_find.ForeColor = System.Drawing.Color.Black;
            this.txt_find.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_find.Location = new System.Drawing.Point(52, 97);
            this.txt_find.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_find.Name = "txt_find";
            this.txt_find.PasswordChar = '\0';
            this.txt_find.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_find.PlaceholderText = "Nhập thông tin cần tìm";
            this.txt_find.SelectedText = "";
            this.txt_find.Size = new System.Drawing.Size(395, 41);
            this.txt_find.TabIndex = 0;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // btn_update
            // 
            this.btn_update.BorderRadius = 10;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(918, 354);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(160, 46);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 10;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(721, 354);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(160, 46);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbo_IDShift_edit
            // 
            this.cbo_IDShift_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_IDShift_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_IDShift_edit.FormattingEnabled = true;
            this.cbo_IDShift_edit.Location = new System.Drawing.Point(99, 278);
            this.cbo_IDShift_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_IDShift_edit.Name = "cbo_IDShift_edit";
            this.cbo_IDShift_edit.Size = new System.Drawing.Size(108, 28);
            this.cbo_IDShift_edit.TabIndex = 1;
            // 
            // cbo_IDStaff_edit
            // 
            this.cbo_IDStaff_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_IDStaff_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_IDStaff_edit.FormattingEnabled = true;
            this.cbo_IDStaff_edit.Location = new System.Drawing.Point(284, 278);
            this.cbo_IDStaff_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_IDStaff_edit.Name = "cbo_IDStaff_edit";
            this.cbo_IDStaff_edit.Size = new System.Drawing.Size(108, 28);
            this.cbo_IDStaff_edit.TabIndex = 1;
            // 
            // dtp_dateWork
            // 
            this.dtp_dateWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.dtp_dateWork.BorderRadius = 15;
            this.dtp_dateWork.Checked = true;
            this.dtp_dateWork.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtp_dateWork.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_dateWork.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_dateWork.Location = new System.Drawing.Point(502, 278);
            this.dtp_dateWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_dateWork.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_dateWork.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_dateWork.Name = "dtp_dateWork";
            this.dtp_dateWork.Size = new System.Drawing.Size(222, 36);
            this.dtp_dateWork.TabIndex = 4;
            this.dtp_dateWork.Value = new System.DateTime(2024, 6, 3, 10, 29, 50, 741);
            this.dtp_dateWork.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // lbl_IDShift_edit
            // 
            this.lbl_IDShift_edit.AutoSize = true;
            this.lbl_IDShift_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDShift_edit.Location = new System.Drawing.Point(23, 283);
            this.lbl_IDShift_edit.Name = "lbl_IDShift_edit";
            this.lbl_IDShift_edit.Size = new System.Drawing.Size(65, 20);
            this.lbl_IDShift_edit.TabIndex = 7;
            this.lbl_IDShift_edit.Text = "ID Shift";
            // 
            // lbl_counter_edit
            // 
            this.lbl_counter_edit.AutoSize = true;
            this.lbl_counter_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter_edit.Location = new System.Drawing.Point(23, 332);
            this.lbl_counter_edit.Name = "lbl_counter_edit";
            this.lbl_counter_edit.Size = new System.Drawing.Size(68, 20);
            this.lbl_counter_edit.TabIndex = 7;
            this.lbl_counter_edit.Text = "Counter";
            // 
            // lbl_IDStaff_edit
            // 
            this.lbl_IDStaff_edit.AutoSize = true;
            this.lbl_IDStaff_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDStaff_edit.Location = new System.Drawing.Point(212, 283);
            this.lbl_IDStaff_edit.Name = "lbl_IDStaff_edit";
            this.lbl_IDStaff_edit.Size = new System.Drawing.Size(66, 20);
            this.lbl_IDStaff_edit.TabIndex = 7;
            this.lbl_IDStaff_edit.Text = "ID Staff";
            // 
            // lbl_status_edit
            // 
            this.lbl_status_edit.AutoSize = true;
            this.lbl_status_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_edit.Location = new System.Drawing.Point(212, 332);
            this.lbl_status_edit.Name = "lbl_status_edit";
            this.lbl_status_edit.Size = new System.Drawing.Size(57, 20);
            this.lbl_status_edit.TabIndex = 7;
            this.lbl_status_edit.Text = "Status";
            // 
            // lbl_dateWork
            // 
            this.lbl_dateWork.AutoSize = true;
            this.lbl_dateWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateWork.Location = new System.Drawing.Point(404, 283);
            this.lbl_dateWork.Name = "lbl_dateWork";
            this.lbl_dateWork.Size = new System.Drawing.Size(89, 20);
            this.lbl_dateWork.TabIndex = 7;
            this.lbl_dateWork.Text = "Date Work";
            // 
            // chk_status
            // 
            this.chk_status.AutoSize = true;
            this.chk_status.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_status.CheckedState.BorderRadius = 0;
            this.chk_status.CheckedState.BorderThickness = 0;
            this.chk_status.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_status.Location = new System.Drawing.Point(284, 332);
            this.chk_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_status.Name = "chk_status";
            this.chk_status.Size = new System.Drawing.Size(89, 24);
            this.chk_status.TabIndex = 8;
            this.chk_status.Text = "Present";
            this.chk_status.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_status.UncheckedState.BorderRadius = 0;
            this.chk_status.UncheckedState.BorderThickness = 0;
            this.chk_status.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbo_counter_edit
            // 
            this.cbo_counter_edit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbo_counter_edit.DefaultText = "";
            this.cbo_counter_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbo_counter_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cbo_counter_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbo_counter_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbo_counter_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_counter_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbo_counter_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_counter_edit.Location = new System.Drawing.Point(98, 321);
            this.cbo_counter_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_counter_edit.Name = "cbo_counter_edit";
            this.cbo_counter_edit.PasswordChar = '\0';
            this.cbo_counter_edit.PlaceholderText = "";
            this.cbo_counter_edit.SelectedText = "";
            this.cbo_counter_edit.Size = new System.Drawing.Size(108, 35);
            this.cbo_counter_edit.TabIndex = 9;
            // 
            // Frm_activityHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1106, 834);
            this.Controls.Add(this.cbo_counter_edit);
            this.Controls.Add(this.chk_status);
            this.Controls.Add(this.lbl_dateWork);
            this.Controls.Add(this.lbl_status_edit);
            this.Controls.Add(this.lbl_counter_edit);
            this.Controls.Add(this.lbl_IDStaff_edit);
            this.Controls.Add(this.lbl_IDShift_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.grp_find);
            this.Controls.Add(this.dgv_LichSu);
            this.Controls.Add(this.dtp_dateWork);
            this.Controls.Add(this.cbo_IDShift_edit);
            this.Controls.Add(this.cbo_IDStaff_edit);
            this.Controls.Add(this.btn_update);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_activityHistory";
            this.Text = "Frm_activityHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSu)).EndInit();
            this.grp_find.ResumeLayout(false);
            this.grp_find.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_LichSu;
        private System.Windows.Forms.GroupBox grp_find;
        private Guna.UI2.WinForms.Guna2TextBox txt_find;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_quay;
        private System.Windows.Forms.Label lbl_IDShift;
        private System.Windows.Forms.ComboBox cbo_status;
        private System.Windows.Forms.ComboBox cbo_counter;
        private System.Windows.Forms.ComboBox cbo_shift;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_start;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_end;
        private System.Windows.Forms.Label lbl_dateEnd;
        private System.Windows.Forms.Label lbl_dateStart;
        private Guna.UI2.WinForms.Guna2Button btn_export;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private System.Windows.Forms.ComboBox cbo_IDShift_edit;
        private System.Windows.Forms.ComboBox cbo_IDStaff_edit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dateWork;
        private System.Windows.Forms.Label lbl_IDShift_edit;
        private System.Windows.Forms.Label lbl_counter_edit;
        private System.Windows.Forms.Label lbl_IDStaff_edit;
        private System.Windows.Forms.Label lbl_status_edit;
        private System.Windows.Forms.Label lbl_dateWork;
        private Guna.UI2.WinForms.Guna2CheckBox chk_status;
        private Guna.UI2.WinForms.Guna2TextBox cbo_counter_edit;
    }
}