namespace ProductList
{
    partial class frmProducts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            this.grpInfo.Controls.Add(this.lblProductId);
            this.grpInfo.Controls.Add(this.txtProductId);
            this.grpInfo.Controls.Add(this.lblProductName);
            this.grpInfo.Controls.Add(this.txtProductName);
            this.grpInfo.Controls.Add(this.lblCategory);
            this.grpInfo.Controls.Add(this.cboCategory);
            this.grpInfo.Controls.Add(this.lblUnitPrice);
            this.grpInfo.Controls.Add(this.txtUnitPrice);
            this.grpInfo.Controls.Add(this.lblQuantity);
            this.grpInfo.Controls.Add(this.numQuantity);
            this.grpInfo.Location = new System.Drawing.Point(15, 15);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(730, 135);
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin sản phẩm";

            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(20, 33);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Text = "Mã SP:";

            this.txtProductId.Location = new System.Drawing.Point(110, 30);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(200, 23);
            this.txtProductId.TabIndex = 0;

            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 68);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Text = "Tên SP:";

            this.txtProductName.Location = new System.Drawing.Point(110, 65);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 23);
            this.txtProductName.TabIndex = 1;

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 103);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Danh mục:";

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Items.AddRange(new object[] { "Điện tử", "Gia dụng", "Thực phẩm", "Thời trang", "Khác" });
            this.cboCategory.Location = new System.Drawing.Point(110, 100);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 23);
            this.cboCategory.TabIndex = 2;

            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(380, 33);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Text = "Đơn giá:";

            this.txtUnitPrice.Location = new System.Drawing.Point(470, 30);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 23);
            this.txtUnitPrice.TabIndex = 3;

            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(380, 68);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Text = "Số lượng:";

            this.numQuantity.Location = new System.Drawing.Point(470, 65);
            this.numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(200, 23);
            this.numQuantity.TabIndex = 4;

            this.grpActions.Controls.Add(this.btnAdd);
            this.grpActions.Controls.Add(this.btnEdit);
            this.grpActions.Controls.Add(this.btnDelete);
            this.grpActions.Controls.Add(this.lblSearch);
            this.grpActions.Controls.Add(this.txtSearch);
            this.grpActions.Controls.Add(this.btnSearch);
            this.grpActions.Location = new System.Drawing.Point(15, 160);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(730, 70);
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Chức năng";

            this.btnAdd.Location = new System.Drawing.Point(20, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Location = new System.Drawing.Point(120, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Location = new System.Drawing.Point(220, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(350, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Tên SP:";

            this.txtSearch.Location = new System.Drawing.Point(410, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 23);
            this.txtSearch.TabIndex = 8;

            this.btnSearch.Location = new System.Drawing.Point(600, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProducts.Location = new System.Drawing.Point(15, 240);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(730, 260);
            this.dgvProducts.TabIndex = 10;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 515);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.dgvProducts);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh sách sản phẩm";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}
