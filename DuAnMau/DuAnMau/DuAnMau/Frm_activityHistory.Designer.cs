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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_IDCa = new System.Windows.Forms.Label();
            this.lbl_IDStaff = new System.Windows.Forms.Label();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(677, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(565, 546);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_IDCa
            // 
            this.lbl_IDCa.AutoSize = true;
            this.lbl_IDCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDCa.Location = new System.Drawing.Point(58, 69);
            this.lbl_IDCa.Name = "lbl_IDCa";
            this.lbl_IDCa.Size = new System.Drawing.Size(71, 25);
            this.lbl_IDCa.TabIndex = 1;
            this.lbl_IDCa.Text = "ID shift";
            // 
            // lbl_IDStaff
            // 
            this.lbl_IDStaff.AutoSize = true;
            this.lbl_IDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDStaff.Location = new System.Drawing.Point(58, 198);
            this.lbl_IDStaff.Name = "lbl_IDStaff";
            this.lbl_IDStaff.Size = new System.Drawing.Size(76, 25);
            this.lbl_IDStaff.TabIndex = 1;
            this.lbl_IDStaff.Text = "ID Staff";
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.Location = new System.Drawing.Point(58, 335);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(117, 25);
            this.lbl_counter.TabIndex = 1;
            this.lbl_counter.Text = "The counter";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(58, 469);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(53, 25);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(58, 604);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(68, 25);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Status";
            // 
            // Frm_activityHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 1070);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_IDStaff);
            this.Controls.Add(this.lbl_IDCa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_activityHistory";
            this.Text = "Frm_activityHistory";
            this.Load += new System.EventHandler(this.Frm_activityHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_IDCa;
        private System.Windows.Forms.Label lbl_IDStaff;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_status;
    }
}