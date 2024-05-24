namespace DuAnMau
{
    partial class Frm_Product_Management
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
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.txt_pr_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_pr_Money = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Supplier_ID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_pr_Money = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pr_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pr_Unit = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grp_product_Information = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbx_Supplier_ID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_pr_DateOfManufacture = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_Expiration_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_pr_Quantity_Remaining = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Supplier_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_pr_Type = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_pr_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_pr_Product_Description = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Expiration_Date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_refesh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_repair = new Guna.UI2.WinForms.Guna2Button();
            this.btn_del = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.grp_product_Information.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Product
            // 
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Product.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.GridColor = System.Drawing.Color.White;
            this.dgv_Product.Location = new System.Drawing.Point(52, 16);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 24;
            this.dgv_Product.Size = new System.Drawing.Size(1013, 433);
            this.dgv_Product.TabIndex = 13;
            this.dgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellClick_1);
            // 
            // txt_pr_Name
            // 
            this.txt_pr_Name.Animated = true;
            this.txt_pr_Name.AutoRoundedCorners = true;
            this.txt_pr_Name.BackColor = System.Drawing.Color.Transparent;
            this.txt_pr_Name.BorderRadius = 16;
            this.txt_pr_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pr_Name.DefaultText = "";
            this.txt_pr_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pr_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pr_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Name.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pr_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pr_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_pr_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Name.Location = new System.Drawing.Point(56, 93);
            this.txt_pr_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pr_Name.Name = "txt_pr_Name";
            this.txt_pr_Name.PasswordChar = '\0';
            this.txt_pr_Name.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_pr_Name.PlaceholderText = "";
            this.txt_pr_Name.SelectedText = "";
            this.txt_pr_Name.Size = new System.Drawing.Size(176, 35);
            this.txt_pr_Name.TabIndex = 14;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(56, 64);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(176, 22);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Product\'s name:";
            // 
            // lbl_pr_Money
            // 
            this.lbl_pr_Money.AutoSize = false;
            this.lbl_pr_Money.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pr_Money.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pr_Money.ForeColor = System.Drawing.Color.Black;
            this.lbl_pr_Money.Location = new System.Drawing.Point(612, 64);
            this.lbl_pr_Money.Name = "lbl_pr_Money";
            this.lbl_pr_Money.Size = new System.Drawing.Size(176, 22);
            this.lbl_pr_Money.TabIndex = 15;
            this.lbl_pr_Money.Text = "Money:";
            // 
            // lbl_Supplier_ID
            // 
            this.lbl_Supplier_ID.AutoSize = false;
            this.lbl_Supplier_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Supplier_ID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_ID.Location = new System.Drawing.Point(334, 146);
            this.lbl_Supplier_ID.Name = "lbl_Supplier_ID";
            this.lbl_Supplier_ID.Size = new System.Drawing.Size(208, 22);
            this.lbl_Supplier_ID.TabIndex = 15;
            this.lbl_Supplier_ID.Text = "Supplier ID:";
            // 
            // txt_pr_Money
            // 
            this.txt_pr_Money.BackColor = System.Drawing.Color.Transparent;
            this.txt_pr_Money.BorderRadius = 12;
            this.txt_pr_Money.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pr_Money.DefaultText = "";
            this.txt_pr_Money.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pr_Money.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pr_Money.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Money.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Money.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pr_Money.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Money.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pr_Money.ForeColor = System.Drawing.Color.Black;
            this.txt_pr_Money.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Money.Location = new System.Drawing.Point(612, 93);
            this.txt_pr_Money.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pr_Money.Name = "txt_pr_Money";
            this.txt_pr_Money.PasswordChar = '\0';
            this.txt_pr_Money.PlaceholderText = "";
            this.txt_pr_Money.SelectedText = "";
            this.txt_pr_Money.Size = new System.Drawing.Size(176, 35);
            this.txt_pr_Money.TabIndex = 14;
            // 
            // txt_pr_Quantity
            // 
            this.txt_pr_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.txt_pr_Quantity.BorderRadius = 12;
            this.txt_pr_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pr_Quantity.DefaultText = "";
            this.txt_pr_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pr_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pr_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Quantity.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pr_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pr_Quantity.ForeColor = System.Drawing.Color.Black;
            this.txt_pr_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Quantity.Location = new System.Drawing.Point(851, 175);
            this.txt_pr_Quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pr_Quantity.Name = "txt_pr_Quantity";
            this.txt_pr_Quantity.PasswordChar = '\0';
            this.txt_pr_Quantity.PlaceholderText = "";
            this.txt_pr_Quantity.SelectedText = "";
            this.txt_pr_Quantity.Size = new System.Drawing.Size(59, 38);
            this.txt_pr_Quantity.TabIndex = 14;
            // 
            // txt_pr_Unit
            // 
            this.txt_pr_Unit.BackColor = System.Drawing.Color.Transparent;
            this.txt_pr_Unit.BorderRadius = 12;
            this.txt_pr_Unit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pr_Unit.DefaultText = "";
            this.txt_pr_Unit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pr_Unit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pr_Unit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Unit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Unit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pr_Unit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Unit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pr_Unit.ForeColor = System.Drawing.Color.Black;
            this.txt_pr_Unit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Unit.Location = new System.Drawing.Point(845, 94);
            this.txt_pr_Unit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pr_Unit.Name = "txt_pr_Unit";
            this.txt_pr_Unit.PasswordChar = '\0';
            this.txt_pr_Unit.PlaceholderText = "";
            this.txt_pr_Unit.SelectedText = "";
            this.txt_pr_Unit.Size = new System.Drawing.Size(59, 38);
            this.txt_pr_Unit.TabIndex = 14;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(334, 65);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(176, 22);
            this.guna2HtmlLabel4.TabIndex = 15;
            this.guna2HtmlLabel4.Text = "Product type:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(851, 146);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(187, 22);
            this.guna2HtmlLabel5.TabIndex = 15;
            this.guna2HtmlLabel5.Text = "Quantity";
            // 
            // grp_product_Information
            // 
            this.grp_product_Information.BorderRadius = 5;
            this.grp_product_Information.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.grp_product_Information.Controls.Add(this.cbx_Supplier_ID);
            this.grp_product_Information.Controls.Add(this.dtp_pr_DateOfManufacture);
            this.grp_product_Information.Controls.Add(this.dtp_Expiration_Date);
            this.grp_product_Information.Controls.Add(this.txt_pr_Quantity_Remaining);
            this.grp_product_Information.Controls.Add(this.guna2HtmlLabel2);
            this.grp_product_Information.Controls.Add(this.txt_pr_Quantity);
            this.grp_product_Information.Controls.Add(this.guna2HtmlLabel5);
            this.grp_product_Information.Controls.Add(this.txt_Supplier_Name);
            this.grp_product_Information.Controls.Add(this.txt_pr_Type);
            this.grp_product_Information.Controls.Add(this.txt_pr_Name);
            this.grp_product_Information.Controls.Add(this.guna2HtmlLabel7);
            this.grp_product_Information.Controls.Add(this.guna2HtmlLabel4);
            this.grp_product_Information.Controls.Add(this.txt_pr_Description);
            this.grp_product_Information.Controls.Add(this.txt_pr_Money);
            this.grp_product_Information.Controls.Add(this.lbl_pr_Product_Description);
            this.grp_product_Information.Controls.Add(this.guna2HtmlLabel9);
            this.grp_product_Information.Controls.Add(this.lbl_Supplier_ID);
            this.grp_product_Information.Controls.Add(this.lbl_Expiration_Date);
            this.grp_product_Information.Controls.Add(this.txt_pr_Unit);
            this.grp_product_Information.Controls.Add(this.lbl_pr_Money);
            this.grp_product_Information.Controls.Add(this.guna2HtmlLabel8);
            this.grp_product_Information.Controls.Add(this.guna2HtmlLabel1);
            this.grp_product_Information.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.grp_product_Information.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.grp_product_Information.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grp_product_Information.ForeColor = System.Drawing.Color.Black;
            this.grp_product_Information.Location = new System.Drawing.Point(12, 455);
            this.grp_product_Information.Name = "grp_product_Information";
            this.grp_product_Information.Size = new System.Drawing.Size(1092, 314);
            this.grp_product_Information.TabIndex = 16;
            this.grp_product_Information.Text = "Product Information";
            // 
            // cbx_Supplier_ID
            // 
            this.cbx_Supplier_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Supplier_ID.AutoRoundedCorners = true;
            this.cbx_Supplier_ID.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Supplier_ID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbx_Supplier_ID.BorderRadius = 17;
            this.cbx_Supplier_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Supplier_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Supplier_ID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_Supplier_ID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_Supplier_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_Supplier_ID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Supplier_ID.ForeColor = System.Drawing.Color.Black;
            this.cbx_Supplier_ID.ItemHeight = 30;
            this.cbx_Supplier_ID.Location = new System.Drawing.Point(334, 165);
            this.cbx_Supplier_ID.Name = "cbx_Supplier_ID";
            this.cbx_Supplier_ID.Size = new System.Drawing.Size(233, 36);
            this.cbx_Supplier_ID.TabIndex = 17;
            this.cbx_Supplier_ID.SelectedIndexChanged += new System.EventHandler(this.cbx_Supplier_ID_SelectedIndexChanged);
            // 
            // dtp_pr_DateOfManufacture
            // 
            this.dtp_pr_DateOfManufacture.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_pr_DateOfManufacture.Checked = true;
            this.dtp_pr_DateOfManufacture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.dtp_pr_DateOfManufacture.FocusedColor = System.Drawing.SystemColors.Control;
            this.dtp_pr_DateOfManufacture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_pr_DateOfManufacture.ForeColor = System.Drawing.Color.Black;
            this.dtp_pr_DateOfManufacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_pr_DateOfManufacture.Location = new System.Drawing.Point(227, 269);
            this.dtp_pr_DateOfManufacture.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_pr_DateOfManufacture.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_pr_DateOfManufacture.Name = "dtp_pr_DateOfManufacture";
            this.dtp_pr_DateOfManufacture.Size = new System.Drawing.Size(141, 21);
            this.dtp_pr_DateOfManufacture.TabIndex = 16;
            this.dtp_pr_DateOfManufacture.Value = new System.DateTime(2024, 5, 20, 16, 13, 40, 518);
            // 
            // dtp_Expiration_Date
            // 
            this.dtp_Expiration_Date.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_Expiration_Date.Checked = true;
            this.dtp_Expiration_Date.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.dtp_Expiration_Date.FocusedColor = System.Drawing.SystemColors.Control;
            this.dtp_Expiration_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Expiration_Date.ForeColor = System.Drawing.Color.Black;
            this.dtp_Expiration_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Expiration_Date.Location = new System.Drawing.Point(601, 268);
            this.dtp_Expiration_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Expiration_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Expiration_Date.Name = "dtp_Expiration_Date";
            this.dtp_Expiration_Date.Size = new System.Drawing.Size(141, 21);
            this.dtp_Expiration_Date.TabIndex = 16;
            this.dtp_Expiration_Date.Value = new System.DateTime(2024, 5, 20, 18, 57, 47, 911);
            // 
            // txt_pr_Quantity_Remaining
            // 
            this.txt_pr_Quantity_Remaining.BackColor = System.Drawing.Color.Transparent;
            this.txt_pr_Quantity_Remaining.BorderRadius = 12;
            this.txt_pr_Quantity_Remaining.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pr_Quantity_Remaining.DefaultText = "";
            this.txt_pr_Quantity_Remaining.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pr_Quantity_Remaining.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pr_Quantity_Remaining.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Quantity_Remaining.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Quantity_Remaining.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pr_Quantity_Remaining.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Quantity_Remaining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pr_Quantity_Remaining.ForeColor = System.Drawing.Color.Black;
            this.txt_pr_Quantity_Remaining.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Quantity_Remaining.Location = new System.Drawing.Point(942, 175);
            this.txt_pr_Quantity_Remaining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pr_Quantity_Remaining.Name = "txt_pr_Quantity_Remaining";
            this.txt_pr_Quantity_Remaining.PasswordChar = '\0';
            this.txt_pr_Quantity_Remaining.PlaceholderText = "";
            this.txt_pr_Quantity_Remaining.SelectedText = "";
            this.txt_pr_Quantity_Remaining.Size = new System.Drawing.Size(59, 38);
            this.txt_pr_Quantity_Remaining.TabIndex = 14;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(942, 146);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(268, 22);
            this.guna2HtmlLabel2.TabIndex = 15;
            this.guna2HtmlLabel2.Text = "Remain";
            // 
            // txt_Supplier_Name
            // 
            this.txt_Supplier_Name.Animated = true;
            this.txt_Supplier_Name.AutoRoundedCorners = true;
            this.txt_Supplier_Name.BackColor = System.Drawing.Color.Transparent;
            this.txt_Supplier_Name.BorderRadius = 16;
            this.txt_Supplier_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Supplier_Name.DefaultText = "";
            this.txt_Supplier_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Supplier_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Supplier_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Supplier_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Supplier_Name.Enabled = false;
            this.txt_Supplier_Name.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Supplier_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Supplier_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Supplier_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Supplier_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Supplier_Name.Location = new System.Drawing.Point(612, 175);
            this.txt_Supplier_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Supplier_Name.Name = "txt_Supplier_Name";
            this.txt_Supplier_Name.PasswordChar = '\0';
            this.txt_Supplier_Name.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_Supplier_Name.PlaceholderText = "";
            this.txt_Supplier_Name.SelectedText = "";
            this.txt_Supplier_Name.Size = new System.Drawing.Size(176, 35);
            this.txt_Supplier_Name.TabIndex = 14;
            // 
            // txt_pr_Type
            // 
            this.txt_pr_Type.Animated = true;
            this.txt_pr_Type.AutoRoundedCorners = true;
            this.txt_pr_Type.BackColor = System.Drawing.Color.Transparent;
            this.txt_pr_Type.BorderRadius = 16;
            this.txt_pr_Type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pr_Type.DefaultText = "";
            this.txt_pr_Type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pr_Type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pr_Type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Type.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pr_Type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pr_Type.ForeColor = System.Drawing.Color.Black;
            this.txt_pr_Type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Type.Location = new System.Drawing.Point(334, 94);
            this.txt_pr_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pr_Type.Name = "txt_pr_Type";
            this.txt_pr_Type.PasswordChar = '\0';
            this.txt_pr_Type.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_pr_Type.PlaceholderText = "";
            this.txt_pr_Type.SelectedText = "";
            this.txt_pr_Type.Size = new System.Drawing.Size(176, 35);
            this.txt_pr_Type.TabIndex = 14;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(56, 267);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(321, 22);
            this.guna2HtmlLabel7.TabIndex = 15;
            this.guna2HtmlLabel7.Text = "Date of manufacture:";
            // 
            // txt_pr_Description
            // 
            this.txt_pr_Description.BackColor = System.Drawing.Color.Transparent;
            this.txt_pr_Description.BorderRadius = 12;
            this.txt_pr_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pr_Description.DefaultText = "";
            this.txt_pr_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pr_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pr_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pr_Description.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pr_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pr_Description.ForeColor = System.Drawing.Color.Black;
            this.txt_pr_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pr_Description.Location = new System.Drawing.Point(56, 175);
            this.txt_pr_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pr_Description.Name = "txt_pr_Description";
            this.txt_pr_Description.PasswordChar = '\0';
            this.txt_pr_Description.PlaceholderText = "";
            this.txt_pr_Description.SelectedText = "";
            this.txt_pr_Description.Size = new System.Drawing.Size(176, 35);
            this.txt_pr_Description.TabIndex = 14;
            // 
            // lbl_pr_Product_Description
            // 
            this.lbl_pr_Product_Description.AutoSize = false;
            this.lbl_pr_Product_Description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pr_Product_Description.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pr_Product_Description.ForeColor = System.Drawing.Color.Black;
            this.lbl_pr_Product_Description.Location = new System.Drawing.Point(56, 146);
            this.lbl_pr_Product_Description.Name = "lbl_pr_Product_Description";
            this.lbl_pr_Product_Description.Size = new System.Drawing.Size(269, 22);
            this.lbl_pr_Product_Description.TabIndex = 15;
            this.lbl_pr_Product_Description.Text = "Product Description:";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(612, 146);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(208, 22);
            this.guna2HtmlLabel9.TabIndex = 15;
            this.guna2HtmlLabel9.Text = "Supplier\'s Name:";
            // 
            // lbl_Expiration_Date
            // 
            this.lbl_Expiration_Date.AutoSize = false;
            this.lbl_Expiration_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Expiration_Date.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiration_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expiration_Date.Location = new System.Drawing.Point(474, 268);
            this.lbl_Expiration_Date.Name = "lbl_Expiration_Date";
            this.lbl_Expiration_Date.Size = new System.Drawing.Size(213, 22);
            this.lbl_Expiration_Date.TabIndex = 15;
            this.lbl_Expiration_Date.Text = "Expiration Date:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(845, 65);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(156, 22);
            this.guna2HtmlLabel8.TabIndex = 15;
            this.guna2HtmlLabel8.Text = "Unit:";
            // 
            // btn_refesh
            // 
            this.btn_refesh.AutoRoundedCorners = true;
            this.btn_refesh.BorderRadius = 14;
            this.btn_refesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refesh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.btn_refesh.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.btn_refesh.ForeColor = System.Drawing.Color.Black;
            this.btn_refesh.Location = new System.Drawing.Point(422, 46);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(105, 30);
            this.btn_refesh.TabIndex = 16;
            this.btn_refesh.Text = "Refesh";
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BorderColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderRadius = 14;
            this.btn_add.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(16, 46);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 30);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_repair
            // 
            this.btn_repair.AutoRoundedCorners = true;
            this.btn_repair.BorderRadius = 14;
            this.btn_repair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_repair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_repair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_repair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_repair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.btn_repair.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.btn_repair.ForeColor = System.Drawing.Color.Black;
            this.btn_repair.Location = new System.Drawing.Point(156, 46);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Size = new System.Drawing.Size(105, 30);
            this.btn_repair.TabIndex = 16;
            this.btn_repair.Text = "Repair";
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // btn_del
            // 
            this.btn_del.AutoRoundedCorners = true;
            this.btn_del.BorderRadius = 14;
            this.btn_del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_del.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.btn_del.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.btn_del.ForeColor = System.Drawing.Color.Black;
            this.btn_del.Location = new System.Drawing.Point(289, 46);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(105, 30);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Delete";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(209)))), ((int)(((byte)(152)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.btn_del);
            this.guna2Panel1.Controls.Add(this.btn_refesh);
            this.guna2Panel1.Controls.Add(this.btn_add);
            this.guna2Panel1.Controls.Add(this.btn_repair);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(37, 779);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(542, 95);
            this.guna2Panel1.TabIndex = 17;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(176, 22);
            this.guna2HtmlLabel3.TabIndex = 17;
            this.guna2HtmlLabel3.Text = "Product Management Toolbar";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(209)))), ((int)(((byte)(152)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.Controls.Add(this.txt_Search);
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(613, 779);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(470, 95);
            this.guna2Panel2.TabIndex = 17;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txt_Search.Size = new System.Drawing.Size(439, 35);
            this.txt_Search.TabIndex = 14;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // Frm_Product_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 900);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.grp_product_Information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Product_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.grp_product_Information.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Product;
        private Guna.UI2.WinForms.Guna2TextBox txt_pr_Name;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_pr_Money;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Supplier_ID;
        private Guna.UI2.WinForms.Guna2TextBox txt_pr_Money;
        private Guna.UI2.WinForms.Guna2TextBox txt_pr_Quantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_pr_Unit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2GroupBox grp_product_Information;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_pr_DateOfManufacture;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Expiration_Date;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Expiration_Date;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txt_pr_Description;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_pr_Product_Description;
        private Guna.UI2.WinForms.Guna2TextBox txt_pr_Quantity_Remaining;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_pr_Type;
        private Guna.UI2.WinForms.Guna2Button btn_refesh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_del;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_repair;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_Supplier_ID;
        private Guna.UI2.WinForms.Guna2TextBox txt_Supplier_Name;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
    }
}