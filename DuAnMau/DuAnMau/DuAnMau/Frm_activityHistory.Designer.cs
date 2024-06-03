namespace DuAnMau
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
            this.dgv_LichSu = new System.Windows.Forms.DataGridView();
            this.grp_find = new System.Windows.Forms.GroupBox();
            this.txt_find = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_shift = new System.Windows.Forms.ComboBox();
            this.cbo_counter = new System.Windows.Forms.ComboBox();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.lbl_IDShift = new System.Windows.Forms.Label();
            this.lbl_quay = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSu)).BeginInit();
            this.grp_find.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LichSu
            // 
            this.dgv_LichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LichSu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_LichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichSu.Location = new System.Drawing.Point(2, 253);
            this.dgv_LichSu.Name = "dgv_LichSu";
            this.dgv_LichSu.RowHeadersWidth = 62;
            this.dgv_LichSu.RowTemplate.Height = 28;
            this.dgv_LichSu.Size = new System.Drawing.Size(1241, 525);
            this.dgv_LichSu.TabIndex = 0;
            // 
            // grp_find
            // 
            this.grp_find.Controls.Add(this.lbl_status);
            this.grp_find.Controls.Add(this.lbl_quay);
            this.grp_find.Controls.Add(this.lbl_IDShift);
            this.grp_find.Controls.Add(this.cbo_status);
            this.grp_find.Controls.Add(this.cbo_counter);
            this.grp_find.Controls.Add(this.cbo_shift);
            this.grp_find.Controls.Add(this.txt_find);
            this.grp_find.Location = new System.Drawing.Point(2, 24);
            this.grp_find.Name = "grp_find";
            this.grp_find.Size = new System.Drawing.Size(1241, 173);
            this.grp_find.TabIndex = 1;
            this.grp_find.TabStop = false;
            this.grp_find.Text = "Finding information";
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
            this.txt_find.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_find.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_find.Location = new System.Drawing.Point(24, 48);
            this.txt_find.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_find.Name = "txt_find";
            this.txt_find.PasswordChar = '\0';
            this.txt_find.PlaceholderText = "";
            this.txt_find.SelectedText = "";
            this.txt_find.Size = new System.Drawing.Size(444, 60);
            this.txt_find.TabIndex = 0;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // cbo_shift
            // 
            this.cbo_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_shift.FormattingEnabled = true;
            this.cbo_shift.Location = new System.Drawing.Point(566, 62);
            this.cbo_shift.Name = "cbo_shift";
            this.cbo_shift.Size = new System.Drawing.Size(121, 33);
            this.cbo_shift.TabIndex = 1;
            // 
            // cbo_counter
            // 
            this.cbo_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_counter.FormattingEnabled = true;
            this.cbo_counter.Location = new System.Drawing.Point(811, 62);
            this.cbo_counter.Name = "cbo_counter";
            this.cbo_counter.Size = new System.Drawing.Size(121, 33);
            this.cbo_counter.TabIndex = 1;
            // 
            // cbo_status
            // 
            this.cbo_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Location = new System.Drawing.Point(1037, 62);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(121, 33);
            this.cbo_status.TabIndex = 1;
            // 
            // lbl_IDShift
            // 
            this.lbl_IDShift.AutoSize = true;
            this.lbl_IDShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDShift.Location = new System.Drawing.Point(485, 65);
            this.lbl_IDShift.Name = "lbl_IDShift";
            this.lbl_IDShift.Size = new System.Drawing.Size(75, 25);
            this.lbl_IDShift.TabIndex = 2;
            this.lbl_IDShift.Text = "ID Shift";
            // 
            // lbl_quay
            // 
            this.lbl_quay.AutoSize = true;
            this.lbl_quay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quay.Location = new System.Drawing.Point(723, 65);
            this.lbl_quay.Name = "lbl_quay";
            this.lbl_quay.Size = new System.Drawing.Size(82, 25);
            this.lbl_quay.TabIndex = 2;
            this.lbl_quay.Text = "Counter";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(963, 65);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(68, 25);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Status";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BorderRadius = 10;
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1052, 202);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(180, 45);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click_1);
            // 
            // Frm_activityHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1244, 778);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grp_find);
            this.Controls.Add(this.dgv_LichSu);
            this.Name = "Frm_activityHistory";
            this.Text = "Frm_activityHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSu)).EndInit();
            this.grp_find.ResumeLayout(false);
            this.grp_find.PerformLayout();
            this.ResumeLayout(false);

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
    }
}