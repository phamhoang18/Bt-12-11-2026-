namespace Departments
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            imgSmall = new ImageList(components);
            imgLarge = new ImageList(components);
            statusStrip1 = new StatusStrip();
            tslInfo = new ToolStripStatusLabel();
            splitMain = new SplitContainer();
            tvDepartments = new TreeView();
            lsvEmployees = new ListView();
            colId = new ColumnHeader();
            colName = new ColumnHeader();
            colPosition = new ColumnHeader();
            colStartDate = new ColumnHeader();
            pnlTop = new Panel();
            lblView = new Label();
            cboView = new ComboBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // imgSmall
            // 
            imgSmall.ColorDepth = ColorDepth.Depth32Bit;
            imgSmall.ImageSize = new Size(16, 16);
            imgSmall.TransparentColor = Color.Transparent;
            // 
            // imgLarge
            // 
            imgLarge.ColorDepth = ColorDepth.Depth32Bit;
            imgLarge.ImageSize = new Size(32, 32);
            imgLarge.TransparentColor = Color.Transparent;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslInfo });
            statusStrip1.Location = new Point(0, 667);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1093, 26);
            statusStrip1.TabIndex = 1;
            // 
            // tslInfo
            // 
            tslInfo.Name = "tslInfo";
            tslInfo.Size = new Size(68, 20);
            tslInfo.Text = "Sẵn sàng";
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Margin = new Padding(3, 4, 3, 4);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(tvDepartments);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(lsvEmployees);
            splitMain.Panel2.Controls.Add(pnlTop);
            splitMain.Size = new Size(1093, 667);
            splitMain.SplitterDistance = 881;
            splitMain.SplitterWidth = 5;
            splitMain.TabIndex = 0;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.HideSelection = false;
            tvDepartments.ImageIndex = 0;
            tvDepartments.ImageList = imgSmall;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Margin = new Padding(3, 4, 3, 4);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.PathSeparator = " > ";
            tvDepartments.SelectedImageIndex = 0;
            tvDepartments.Size = new Size(881, 667);
            tvDepartments.TabIndex = 0;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Columns.AddRange(new ColumnHeader[] { colId, colName, colPosition, colStartDate });
            lsvEmployees.Dock = DockStyle.Fill;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.LargeImageList = imgLarge;
            lsvEmployees.Location = new Point(0, 53);
            lsvEmployees.Margin = new Padding(3, 4, 3, 4);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.ShowItemToolTips = true;
            lsvEmployees.Size = new Size(207, 614);
            lsvEmployees.SmallImageList = imgSmall;
            lsvEmployees.TabIndex = 1;
            lsvEmployees.TileSize = new Size(250, 44);
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "Mã NV";
            colId.Width = 80;
            // 
            // colName
            // 
            colName.Text = "Họ Tên";
            colName.Width = 190;
            // 
            // colPosition
            // 
            colPosition.Text = "Chức vụ";
            colPosition.Width = 150;
            // 
            // colStartDate
            // 
            colStartDate.Text = "Ngày vào làm";
            colStartDate.Width = 110;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblView);
            pnlTop.Controls.Add(cboView);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(207, 53);
            pnlTop.TabIndex = 2;
            // 
            // lblView
            // 
            lblView.AutoSize = true;
            lblView.Location = new Point(11, 17);
            lblView.Name = "lblView";
            lblView.Size = new Size(91, 20);
            lblView.TabIndex = 0;
            lblView.Text = "Chế độ xem:";
            // 
            // cboView
            // 
            cboView.DropDownStyle = ComboBoxStyle.DropDownList;
            cboView.Items.AddRange(new object[] { "Details", "List", "SmallIcon", "LargeIcon", "Tile" });
            cboView.Location = new Point(109, 12);
            cboView.Margin = new Padding(3, 4, 3, 4);
            cboView.Name = "cboView";
            cboView.Size = new Size(182, 28);
            cboView.TabIndex = 2;
            cboView.SelectedIndexChanged += cboView_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 693);
            Controls.Add(splitMain);
            Controls.Add(statusStrip1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(729, 518);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân sự theo cơ cấu tổ chức";
            Load += frmDepartments_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ImageList imgSmall;
        private System.Windows.Forms.ImageList imgLarge;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslInfo;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.ComboBox cboView;
    }
}
