namespace ERRORPROVIDER
{
    partial class frmRegister
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
            this.components = new System.ComponentModel.Container();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.grpExtra = new System.Windows.Forms.GroupBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPersonal.SuspendLayout();
            this.grpExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();

            this.grpPersonal.Controls.Add(this.lblUsername);
            this.grpPersonal.Controls.Add(this.txtUsername);
            this.grpPersonal.Controls.Add(this.lblPassword);
            this.grpPersonal.Controls.Add(this.txtPassword);
            this.grpPersonal.Controls.Add(this.lblConfirm);
            this.grpPersonal.Controls.Add(this.txtConfirm);
            this.grpPersonal.Location = new System.Drawing.Point(15, 15);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(410, 170);
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Thông tin cá nhân";

            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Tên đăng nhập:";

            this.txtUsername.Location = new System.Drawing.Point(150, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.Input_Changed);

            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Mật khẩu:";

            this.txtPassword.Location = new System.Drawing.Point(150, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;             
            this.txtPassword.TextChanged += new System.EventHandler(this.Input_Changed);

            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(20, 125);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Text = "Xác nhận mật khẩu:";

            this.txtConfirm.Location = new System.Drawing.Point(150, 122);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(220, 23);
            this.txtConfirm.TabIndex = 2;
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.TextChanged += new System.EventHandler(this.Input_Changed);

            this.grpExtra.Controls.Add(this.lblBirthDate);
            this.grpExtra.Controls.Add(this.dtpBirthDate);
            this.grpExtra.Controls.Add(this.lblGender);
            this.grpExtra.Controls.Add(this.rdoMale);
            this.grpExtra.Controls.Add(this.rdoFemale);
            this.grpExtra.Controls.Add(this.rdoOther);
            this.grpExtra.Controls.Add(this.chkTerms);
            this.grpExtra.Location = new System.Drawing.Point(15, 195);
            this.grpExtra.Name = "grpExtra";
            this.grpExtra.Size = new System.Drawing.Size(410, 170);
            this.grpExtra.TabStop = false;
            this.grpExtra.Text = "Thông tin bổ sung";

            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(20, 35);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Text = "Ngày sinh:";

            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(150, 32);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(150, 23);
            this.dtpBirthDate.TabIndex = 3;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.Input_Changed);

            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 82);
            this.lblGender.Name = "lblGender";
            this.lblGender.Text = "Giới tính:";

            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(150, 80);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.TabIndex = 4;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";

            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(230, 80);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.TabIndex = 5;
            this.rdoFemale.Text = "Nữ";

            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(300, 80);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.TabIndex = 6;
            this.rdoOther.Text = "Khác";

            this.chkTerms.AutoSize = true;
            this.chkTerms.Location = new System.Drawing.Point(20, 125);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.TabIndex = 7;
            this.chkTerms.Text = "Tôi đồng ý với Điều khoản dịch vụ";
            this.chkTerms.UseVisualStyleBackColor = true;
            this.chkTerms.CheckedChanged += new System.EventHandler(this.Input_Changed);

            this.btnRegister.Location = new System.Drawing.Point(95, 385);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 36);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.btnReset.Location = new System.Drawing.Point(225, 385);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 36);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.epCheck.ContainerControl = this;

            this.AcceptButton = this.btnRegister;                     
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 440);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpExtra);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpExtra.ResumeLayout(false);
            this.grpExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.GroupBox grpExtra;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}
