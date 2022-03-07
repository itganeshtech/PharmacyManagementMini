
namespace PharmacyManagementMini.PharmacistUC
{
    partial class UC_P_UpdateMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_UpdateMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAvailableQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMediNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMediName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMediID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Medicine";
            // 
            // txtEDate
            // 
            this.txtEDate.CheckedState.Parent = this.txtEDate;
            this.txtEDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtEDate.HoverState.Parent = this.txtEDate;
            this.txtEDate.Location = new System.Drawing.Point(619, 111);
            this.txtEDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtEDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.ShadowDecoration.Parent = this.txtEDate;
            this.txtEDate.Size = new System.Drawing.Size(340, 36);
            this.txtEDate.TabIndex = 33;
            this.txtEDate.Value = new System.DateTime(2022, 3, 3, 2, 11, 47, 773);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(615, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Expire Date";
            // 
            // txtMDate
            // 
            this.txtMDate.CheckedState.Parent = this.txtMDate;
            this.txtMDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtMDate.HoverState.Parent = this.txtMDate;
            this.txtMDate.Location = new System.Drawing.Point(60, 460);
            this.txtMDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtMDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtMDate.Name = "txtMDate";
            this.txtMDate.ShadowDecoration.Parent = this.txtMDate;
            this.txtMDate.Size = new System.Drawing.Size(340, 36);
            this.txtMDate.TabIndex = 31;
            this.txtMDate.Value = new System.DateTime(2022, 3, 3, 2, 11, 47, 773);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Manufacturing Date";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.DefaultText = "";
            this.txtPricePerUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.DisabledState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.FocusedState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.HoverState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Location = new System.Drawing.Point(619, 354);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.PlaceholderText = "";
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.ShadowDecoration.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Size = new System.Drawing.Size(340, 36);
            this.txtPricePerUnit.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Price Per Unit";
            // 
            // txtAvailableQuantity
            // 
            this.txtAvailableQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAvailableQuantity.DefaultText = "";
            this.txtAvailableQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAvailableQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAvailableQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvailableQuantity.DisabledState.Parent = this.txtAvailableQuantity;
            this.txtAvailableQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvailableQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAvailableQuantity.FocusedState.Parent = this.txtAvailableQuantity;
            this.txtAvailableQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtAvailableQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAvailableQuantity.HoverState.Parent = this.txtAvailableQuantity;
            this.txtAvailableQuantity.Location = new System.Drawing.Point(619, 230);
            this.txtAvailableQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAvailableQuantity.Name = "txtAvailableQuantity";
            this.txtAvailableQuantity.PasswordChar = '\0';
            this.txtAvailableQuantity.PlaceholderText = "";
            this.txtAvailableQuantity.SelectedText = "";
            this.txtAvailableQuantity.ShadowDecoration.Parent = this.txtAvailableQuantity;
            this.txtAvailableQuantity.Size = new System.Drawing.Size(340, 36);
            this.txtAvailableQuantity.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Available Quantity";
            // 
            // txtMediNumber
            // 
            this.txtMediNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediNumber.DefaultText = "";
            this.txtMediNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediNumber.DisabledState.Parent = this.txtMediNumber;
            this.txtMediNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediNumber.FocusedState.Parent = this.txtMediNumber;
            this.txtMediNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediNumber.ForeColor = System.Drawing.Color.Black;
            this.txtMediNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediNumber.HoverState.Parent = this.txtMediNumber;
            this.txtMediNumber.Location = new System.Drawing.Point(60, 354);
            this.txtMediNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediNumber.Name = "txtMediNumber";
            this.txtMediNumber.PasswordChar = '\0';
            this.txtMediNumber.PlaceholderText = "";
            this.txtMediNumber.SelectedText = "";
            this.txtMediNumber.ShadowDecoration.Parent = this.txtMediNumber;
            this.txtMediNumber.Size = new System.Drawing.Size(340, 36);
            this.txtMediNumber.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Medcine Number";
            // 
            // txtMediName
            // 
            this.txtMediName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediName.DefaultText = "";
            this.txtMediName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediName.DisabledState.Parent = this.txtMediName;
            this.txtMediName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediName.FocusedState.Parent = this.txtMediName;
            this.txtMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediName.ForeColor = System.Drawing.Color.Black;
            this.txtMediName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediName.HoverState.Parent = this.txtMediName;
            this.txtMediName.Location = new System.Drawing.Point(60, 230);
            this.txtMediName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PasswordChar = '\0';
            this.txtMediName.PlaceholderText = "";
            this.txtMediName.SelectedText = "";
            this.txtMediName.ShadowDecoration.Parent = this.txtMediName;
            this.txtMediName.Size = new System.Drawing.Size(340, 36);
            this.txtMediName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Medicine Name";
            // 
            // txtMediID
            // 
            this.txtMediID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediID.DefaultText = "";
            this.txtMediID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediID.DisabledState.Parent = this.txtMediID;
            this.txtMediID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediID.FocusedState.Parent = this.txtMediID;
            this.txtMediID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediID.ForeColor = System.Drawing.Color.Black;
            this.txtMediID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediID.HoverState.Parent = this.txtMediID;
            this.txtMediID.Location = new System.Drawing.Point(60, 102);
            this.txtMediID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediID.Name = "txtMediID";
            this.txtMediID.PasswordChar = '\0';
            this.txtMediID.PlaceholderText = "";
            this.txtMediID.SelectedText = "";
            this.txtMediID.ShadowDecoration.Parent = this.txtMediID;
            this.txtMediID.Size = new System.Drawing.Size(340, 36);
            this.txtMediID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Medicine ID";
            // 
            // btnReset
            // 
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.BorderRadius = 21;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReset.Location = new System.Drawing.Point(786, 443);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(146, 48);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.BorderRadius = 21;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(625, 443);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(146, 48);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSearch.BorderRadius = 21;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(254, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(146, 40);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(706, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Add Quantity";
            // 
            // txtAddQuan
            // 
            this.txtAddQuan.BackColor = System.Drawing.Color.Black;
            this.txtAddQuan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtAddQuan.BorderThickness = 3;
            this.txtAddQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddQuan.DefaultText = "0";
            this.txtAddQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddQuan.DisabledState.Parent = this.txtAddQuan;
            this.txtAddQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuan.FocusedState.Parent = this.txtAddQuan;
            this.txtAddQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuan.ForeColor = System.Drawing.Color.Black;
            this.txtAddQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuan.HoverState.Parent = this.txtAddQuan;
            this.txtAddQuan.Location = new System.Drawing.Point(837, 274);
            this.txtAddQuan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddQuan.Name = "txtAddQuan";
            this.txtAddQuan.PasswordChar = '\0';
            this.txtAddQuan.PlaceholderText = "";
            this.txtAddQuan.SelectedText = "";
            this.txtAddQuan.SelectionStart = 1;
            this.txtAddQuan.ShadowDecoration.Parent = this.txtAddQuan;
            this.txtAddQuan.Size = new System.Drawing.Size(122, 38);
            this.txtAddQuan.TabIndex = 38;
            this.txtAddQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_P_UpdateMedicine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtAddQuan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAvailableQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMediID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_UpdateMedicine";
            this.Size = new System.Drawing.Size(1089, 720);
            this.Load += new System.EventHandler(this.UC_P_UpdateMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtEDate;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtMDate;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAvailableQuantity;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMediNumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMediName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMediID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtAddQuan;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
