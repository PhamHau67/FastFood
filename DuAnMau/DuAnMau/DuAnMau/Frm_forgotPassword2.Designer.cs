namespace DuAnMau
{
    partial class Frm_forgotPassword2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_forgotPassword2));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_enter = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_newPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_rePass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_recover = new Guna.UI2.WinForms.Guna2Button();
            this.btn_openEye = new Guna.UI2.WinForms.Guna2Button();
            this.btn_closeEye = new Guna.UI2.WinForms.Guna2Button();
            this.btn_closeEye2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_openEye1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_resend = new Guna.UI2.WinForms.Guna2Button();
            this.countdown_Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recover password";
            // 
            // txt_enter
            // 
            this.txt_enter.BorderRadius = 10;
            this.txt_enter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_enter.DefaultText = "";
            this.txt_enter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_enter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_enter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_enter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_enter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_enter.Font = new System.Drawing.Font("Segoe Print", 16.2F);
            this.txt_enter.ForeColor = System.Drawing.Color.Black;
            this.txt_enter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_enter.Location = new System.Drawing.Point(15, 80);
            this.txt_enter.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_enter.Name = "txt_enter";
            this.txt_enter.PasswordChar = '\0';
            this.txt_enter.PlaceholderText = "Enter OTP code";
            this.txt_enter.SelectedText = "";
            this.txt_enter.Size = new System.Drawing.Size(570, 45);
            this.txt_enter.TabIndex = 2;
            // 
            // txt_newPass
            // 
            this.txt_newPass.BorderRadius = 10;
            this.txt_newPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_newPass.DefaultText = "";
            this.txt_newPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_newPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_newPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_newPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_newPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_newPass.Font = new System.Drawing.Font("Segoe Print", 16.2F);
            this.txt_newPass.ForeColor = System.Drawing.Color.Black;
            this.txt_newPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_newPass.Location = new System.Drawing.Point(15, 162);
            this.txt_newPass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.PasswordChar = '*';
            this.txt_newPass.PlaceholderText = "Enter new password";
            this.txt_newPass.SelectedText = "";
            this.txt_newPass.Size = new System.Drawing.Size(570, 45);
            this.txt_newPass.TabIndex = 3;
            // 
            // txt_rePass
            // 
            this.txt_rePass.BorderRadius = 10;
            this.txt_rePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rePass.DefaultText = "";
            this.txt_rePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_rePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_rePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rePass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rePass.Font = new System.Drawing.Font("Segoe Print", 16.2F);
            this.txt_rePass.ForeColor = System.Drawing.Color.Black;
            this.txt_rePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rePass.Location = new System.Drawing.Point(15, 248);
            this.txt_rePass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_rePass.Name = "txt_rePass";
            this.txt_rePass.PasswordChar = '*';
            this.txt_rePass.PlaceholderText = "Re-enter new password";
            this.txt_rePass.SelectedText = "";
            this.txt_rePass.Size = new System.Drawing.Size(570, 45);
            this.txt_rePass.TabIndex = 4;
            // 
            // btn_recover
            // 
            this.btn_recover.BorderRadius = 20;
            this.btn_recover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_recover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_recover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_recover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_recover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_recover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_recover.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_recover.ForeColor = System.Drawing.Color.Black;
            this.btn_recover.Location = new System.Drawing.Point(363, 331);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(225, 45);
            this.btn_recover.TabIndex = 5;
            this.btn_recover.Text = "Recover password";
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // btn_openEye
            // 
            this.btn_openEye.BackColor = System.Drawing.Color.White;
            this.btn_openEye.BorderRadius = 20;
            this.btn_openEye.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_openEye.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_openEye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_openEye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_openEye.FillColor = System.Drawing.Color.White;
            this.btn_openEye.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_openEye.ForeColor = System.Drawing.Color.Black;
            this.btn_openEye.Image = ((System.Drawing.Image)(resources.GetObject("btn_openEye.Image")));
            this.btn_openEye.Location = new System.Drawing.Point(544, 162);
            this.btn_openEye.Name = "btn_openEye";
            this.btn_openEye.Size = new System.Drawing.Size(41, 45);
            this.btn_openEye.TabIndex = 6;
            this.btn_openEye.Click += new System.EventHandler(this.btn_openEye_Click);
            // 
            // btn_closeEye
            // 
            this.btn_closeEye.BackColor = System.Drawing.Color.White;
            this.btn_closeEye.BorderRadius = 20;
            this.btn_closeEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeEye.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_closeEye.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_closeEye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_closeEye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_closeEye.FillColor = System.Drawing.Color.White;
            this.btn_closeEye.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_closeEye.ForeColor = System.Drawing.Color.Black;
            this.btn_closeEye.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeEye.Image")));
            this.btn_closeEye.Location = new System.Drawing.Point(544, 162);
            this.btn_closeEye.Name = "btn_closeEye";
            this.btn_closeEye.Size = new System.Drawing.Size(41, 45);
            this.btn_closeEye.TabIndex = 7;
            this.btn_closeEye.Click += new System.EventHandler(this.btn_closeEye_Click);
            // 
            // btn_closeEye2
            // 
            this.btn_closeEye2.BackColor = System.Drawing.Color.White;
            this.btn_closeEye2.BorderRadius = 20;
            this.btn_closeEye2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeEye2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_closeEye2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_closeEye2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_closeEye2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_closeEye2.FillColor = System.Drawing.Color.White;
            this.btn_closeEye2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_closeEye2.ForeColor = System.Drawing.Color.Black;
            this.btn_closeEye2.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeEye2.Image")));
            this.btn_closeEye2.Location = new System.Drawing.Point(544, 248);
            this.btn_closeEye2.Name = "btn_closeEye2";
            this.btn_closeEye2.Size = new System.Drawing.Size(41, 45);
            this.btn_closeEye2.TabIndex = 9;
            this.btn_closeEye2.Click += new System.EventHandler(this.btn_closeEye2_Click);
            // 
            // btn_openEye1
            // 
            this.btn_openEye1.BackColor = System.Drawing.Color.White;
            this.btn_openEye1.BorderRadius = 20;
            this.btn_openEye1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_openEye1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_openEye1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_openEye1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_openEye1.FillColor = System.Drawing.Color.White;
            this.btn_openEye1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_openEye1.ForeColor = System.Drawing.Color.Black;
            this.btn_openEye1.Image = ((System.Drawing.Image)(resources.GetObject("btn_openEye1.Image")));
            this.btn_openEye1.Location = new System.Drawing.Point(544, 248);
            this.btn_openEye1.Name = "btn_openEye1";
            this.btn_openEye1.Size = new System.Drawing.Size(41, 45);
            this.btn_openEye1.TabIndex = 8;
            this.btn_openEye1.Click += new System.EventHandler(this.btn_openEye1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(15, 325);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(65, 51);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_resend
            // 
            this.btn_resend.BackColor = System.Drawing.Color.White;
            this.btn_resend.BorderRadius = 20;
            this.btn_resend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_resend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_resend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_resend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_resend.FillColor = System.Drawing.Color.White;
            this.btn_resend.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_resend.ForeColor = System.Drawing.Color.Black;
            this.btn_resend.Location = new System.Drawing.Point(349, 80);
            this.btn_resend.Name = "btn_resend";
            this.btn_resend.Size = new System.Drawing.Size(239, 45);
            this.btn_resend.TabIndex = 11;
            this.btn_resend.Text = "Resend OTP";
            this.btn_resend.Click += new System.EventHandler(this.btn_resend_Click_1);
            // 
            // countdown_Timer
            // 
            this.countdown_Timer.Tick += new System.EventHandler(this.countdown_Timer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(527, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Frm_forgotPassword2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_resend);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_closeEye2);
            this.Controls.Add(this.btn_openEye1);
            this.Controls.Add(this.btn_closeEye);
            this.Controls.Add(this.btn_openEye);
            this.Controls.Add(this.btn_recover);
            this.Controls.Add(this.txt_rePass);
            this.Controls.Add(this.txt_newPass);
            this.Controls.Add(this.txt_enter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_forgotPassword2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_forgotPassword2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_enter;
        private Guna.UI2.WinForms.Guna2TextBox txt_newPass;
        private Guna.UI2.WinForms.Guna2TextBox txt_rePass;
        private Guna.UI2.WinForms.Guna2Button btn_recover;
        private Guna.UI2.WinForms.Guna2Button btn_openEye;
        private Guna.UI2.WinForms.Guna2Button btn_closeEye;
        private Guna.UI2.WinForms.Guna2Button btn_closeEye2;
        private Guna.UI2.WinForms.Guna2Button btn_openEye1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btn_resend;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Timer countdown_Timer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}