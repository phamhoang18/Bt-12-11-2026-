namespace LISTBOX___COMBOBOX
{
    partial class frmBilling
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstSelectedServices = new System.Windows.Forms.ListBox();
            this.grpBilling = new System.Windows.Forms.GroupBox();
            this.lblSubtotalCaption = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblDiscountCaption = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 20);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Loại dịch vụ:";

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Items.AddRange(new object[] { "Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin" });
            this.cboCategory.Location = new System.Drawing.Point(20, 42);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(300, 23);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);

            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(20, 80);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Text = "Dịch vụ có sẵn:";

            this.lstAvailableServices.FormattingEnabled = true;
            this.lstAvailableServices.ItemHeight = 15;
            this.lstAvailableServices.Location = new System.Drawing.Point(20, 102);
            this.lstAvailableServices.Name = "lstAvailableServices";
            this.lstAvailableServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended; 
            this.lstAvailableServices.Size = new System.Drawing.Size(300, 184);
            this.lstAvailableServices.TabIndex = 1;
            this.lstAvailableServices.DoubleClick += new System.EventHandler(this.lstAvailableServices_DoubleClick);

            this.btnSelect.Location = new System.Drawing.Point(335, 135);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 32);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);

            this.btnRemove.Location = new System.Drawing.Point(335, 177);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 32);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            this.btnClearAll.Location = new System.Drawing.Point(335, 219);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(50, 32);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "<<";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);

            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(400, 80);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Text = "Dịch vụ đã chọn:";

            this.lstSelectedServices.FormattingEnabled = true;
            this.lstSelectedServices.ItemHeight = 15;
            this.lstSelectedServices.Location = new System.Drawing.Point(400, 102);
            this.lstSelectedServices.Name = "lstSelectedServices";
            this.lstSelectedServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedServices.Size = new System.Drawing.Size(300, 184);
            this.lstSelectedServices.TabIndex = 5;
            this.lstSelectedServices.DoubleClick += new System.EventHandler(this.lstSelectedServices_DoubleClick);

            this.grpBilling.Controls.Add(this.lblSubtotalCaption);
            this.grpBilling.Controls.Add(this.txtSubtotal);
            this.grpBilling.Controls.Add(this.lblDiscountCaption);
            this.grpBilling.Controls.Add(this.numDiscount);
            this.grpBilling.Controls.Add(this.lblTotalCaption);
            this.grpBilling.Controls.Add(this.lblTotal);
            this.grpBilling.Location = new System.Drawing.Point(20, 305);
            this.grpBilling.Name = "grpBilling";
            this.grpBilling.Size = new System.Drawing.Size(680, 115);
            this.grpBilling.TabStop = false;
            this.grpBilling.Text = "Tính tiền";

            this.lblSubtotalCaption.AutoSize = true;
            this.lblSubtotalCaption.Location = new System.Drawing.Point(20, 33);
            this.lblSubtotalCaption.Name = "lblSubtotalCaption";
            this.lblSubtotalCaption.Text = "Tổng tiền chưa giảm:";

            this.txtSubtotal.Location = new System.Drawing.Point(165, 30);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;                          
            this.txtSubtotal.Size = new System.Drawing.Size(170, 23);
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.Text = "0 đ";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.lblDiscountCaption.AutoSize = true;
            this.lblDiscountCaption.Location = new System.Drawing.Point(20, 70);
            this.lblDiscountCaption.Name = "lblDiscountCaption";
            this.lblDiscountCaption.Text = "Tỷ lệ chiết khấu (%):";

            this.numDiscount.Location = new System.Drawing.Point(165, 67);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(170, 23);
            this.numDiscount.TabIndex = 6;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);  

            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(375, 33);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Text = "Thành tiền thanh toán:";

            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(375, 55);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(290, 40);
            this.lblTotal.Text = "0 đ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 440);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lstAvailableServices);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.grpBilling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng tính tiền dịch vụ và chiết khấu";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            this.grpBilling.ResumeLayout(false);
            this.grpBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.GroupBox grpBilling;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblDiscountCaption;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
    }
}
