namespace DuAnMau
{
    partial class Frm_Order
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
            this.pn_Menu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_TableNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.Nud_quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.Cbo_dish = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cbo_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_Sum = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Pay = new Guna.UI2.WinForms.Guna2Button();
            this.lstv_HoaDon = new System.Windows.Forms.ListView();
            this.txt_Summ = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_odernow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_time = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.pn_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_quantity)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Menu
            // 
            this.pn_Menu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_Menu.BorderRadius = 20;
            this.pn_Menu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pn_Menu.Controls.Add(this.guna2Panel3);
            this.pn_Menu.Controls.Add(this.guna2HtmlLabel1);
            this.pn_Menu.Controls.Add(this.txt_TableNumber);
            this.pn_Menu.Controls.Add(this.Nud_quantity);
            this.pn_Menu.Controls.Add(this.Cbo_dish);
            this.pn_Menu.Controls.Add(this.Cbo_Type);
            this.pn_Menu.Controls.Add(this.btn_add);
            this.pn_Menu.Location = new System.Drawing.Point(0, 2);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(540, 840);
            this.pn_Menu.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(304, 137);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(127, 33);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Số Bàn";
            // 
            // txt_TableNumber
            // 
            this.txt_TableNumber.BorderRadius = 15;
            this.txt_TableNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TableNumber.DefaultText = "";
            this.txt_TableNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TableNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TableNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TableNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TableNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TableNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TableNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TableNumber.Location = new System.Drawing.Point(37, 130);
            this.txt_TableNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_TableNumber.Name = "txt_TableNumber";
            this.txt_TableNumber.PasswordChar = '\0';
            this.txt_TableNumber.PlaceholderText = "";
            this.txt_TableNumber.SelectedText = "";
            this.txt_TableNumber.Size = new System.Drawing.Size(259, 40);
            this.txt_TableNumber.TabIndex = 4;
            // 
            // Nud_quantity
            // 
            this.Nud_quantity.BackColor = System.Drawing.Color.Transparent;
            this.Nud_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nud_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nud_quantity.Location = new System.Drawing.Point(304, 239);
            this.Nud_quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nud_quantity.Name = "Nud_quantity";
            this.Nud_quantity.Size = new System.Drawing.Size(72, 32);
            this.Nud_quantity.TabIndex = 3;
            this.Nud_quantity.UpDownButtonFillColor = System.Drawing.Color.LemonChiffon;
            // 
            // Cbo_dish
            // 
            this.Cbo_dish.BackColor = System.Drawing.Color.Transparent;
            this.Cbo_dish.BorderRadius = 15;
            this.Cbo_dish.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_dish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_dish.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbo_dish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbo_dish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_dish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cbo_dish.ItemHeight = 30;
            this.Cbo_dish.Location = new System.Drawing.Point(37, 281);
            this.Cbo_dish.Name = "Cbo_dish";
            this.Cbo_dish.Size = new System.Drawing.Size(260, 36);
            this.Cbo_dish.TabIndex = 2;
            // 
            // Cbo_Type
            // 
            this.Cbo_Type.BackColor = System.Drawing.Color.Transparent;
            this.Cbo_Type.BorderRadius = 15;
            this.Cbo_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbo_Type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbo_Type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cbo_Type.ItemHeight = 30;
            this.Cbo_Type.Location = new System.Drawing.Point(37, 199);
            this.Cbo_Type.Name = "Cbo_Type";
            this.Cbo_Type.Size = new System.Drawing.Size(260, 36);
            this.Cbo_Type.TabIndex = 1;
            this.Cbo_Type.SelectedIndexChanged += new System.EventHandler(this.Cbo_Type_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 20;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(396, 223);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 62);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.txt_Summ);
            this.guna2Panel1.Controls.Add(this.txt_Sum);
            this.guna2Panel1.Controls.Add(this.btn_Remove);
            this.guna2Panel1.Controls.Add(this.btn_Clear);
            this.guna2Panel1.Controls.Add(this.btn_Pay);
            this.guna2Panel1.Controls.Add(this.lstv_HoaDon);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(561, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(540, 840);
            this.guna2Panel1.TabIndex = 3;
            // 
            // txt_Sum
            // 
            this.txt_Sum.BorderRadius = 10;
            this.txt_Sum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Sum.DefaultText = "";
            this.txt_Sum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Sum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Sum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Sum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Sum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Sum.Location = new System.Drawing.Point(15, 1088);
            this.txt_Sum.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_Sum.Name = "txt_Sum";
            this.txt_Sum.PasswordChar = '\0';
            this.txt_Sum.PlaceholderText = "";
            this.txt_Sum.ReadOnly = true;
            this.txt_Sum.SelectedText = "";
            this.txt_Sum.Size = new System.Drawing.Size(422, 67);
            this.txt_Sum.TabIndex = 7;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BorderRadius = 20;
            this.btn_Remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_Remove.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.Black;
            this.btn_Remove.Location = new System.Drawing.Point(10, 627);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(253, 65);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BorderRadius = 20;
            this.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(297, 627);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(231, 65);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.BorderRadius = 20;
            this.btn_Pay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Pay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(153)))));
            this.btn_Pay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.ForeColor = System.Drawing.Color.Black;
            this.btn_Pay.Location = new System.Drawing.Point(297, 736);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.PressedColor = System.Drawing.Color.RoyalBlue;
            this.btn_Pay.Size = new System.Drawing.Size(231, 69);
            this.btn_Pay.TabIndex = 1;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // lstv_HoaDon
            // 
            this.lstv_HoaDon.AllowColumnReorder = true;
            this.lstv_HoaDon.Enabled = false;
            this.lstv_HoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_HoaDon.HideSelection = false;
            this.lstv_HoaDon.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lstv_HoaDon.Location = new System.Drawing.Point(10, 11);
            this.lstv_HoaDon.Name = "lstv_HoaDon";
            this.lstv_HoaDon.Size = new System.Drawing.Size(518, 610);
            this.lstv_HoaDon.TabIndex = 0;
            this.lstv_HoaDon.UseCompatibleStateImageBehavior = false;
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
            this.txt_Summ.Location = new System.Drawing.Point(10, 755);
            this.txt_Summ.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_Summ.Name = "txt_Summ";
            this.txt_Summ.PasswordChar = '\0';
            this.txt_Summ.PlaceholderText = "";
            this.txt_Summ.ReadOnly = true;
            this.txt_Summ.SelectedText = "";
            this.txt_Summ.Size = new System.Drawing.Size(253, 40);
            this.txt_Summ.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.guna2Panel2.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(11, 712);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(517, 10);
            this.guna2Panel2.TabIndex = 8;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lbl_time);
            this.guna2Panel3.Controls.Add(this.lbl_odernow);
            this.guna2Panel3.Location = new System.Drawing.Point(4, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(533, 100);
            this.guna2Panel3.TabIndex = 6;
            // 
            // lbl_odernow
            // 
            this.lbl_odernow.AutoSize = false;
            this.lbl_odernow.BackColor = System.Drawing.Color.Transparent;
            this.lbl_odernow.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_odernow.Location = new System.Drawing.Point(126, 7);
            this.lbl_odernow.Name = "lbl_odernow";
            this.lbl_odernow.Size = new System.Drawing.Size(404, 81);
            this.lbl_odernow.TabIndex = 0;
            this.lbl_odernow.Text = "Order Now";
            // 
            // lbl_time
            // 
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(152, 49);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(106, 39);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "lbl_time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.guna2Panel4.Location = new System.Drawing.Point(543, 8);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(15, 814);
            this.guna2Panel4.TabIndex = 4;
            // 
            // Frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1101, 853);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pn_Menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Frm_Order_Load);
            this.pn_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_quantity)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pn_Menu;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2ComboBox Cbo_dish;
        private Guna.UI2.WinForms.Guna2ComboBox Cbo_Type;
        private Guna.UI2.WinForms.Guna2NumericUpDown Nud_quantity;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Pay;
        private System.Windows.Forms.ListView lstv_HoaDon;
        private Guna.UI2.WinForms.Guna2Button btn_Remove;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private Guna.UI2.WinForms.Guna2TextBox txt_Sum;
        private Guna.UI2.WinForms.Guna2TextBox txt_TableNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Summ;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_odernow;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_time;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
    }
}