using System;
using System.Windows.Forms;
namespace ERRORPROVIDER
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            dtpBirthDate.MaxDate = DateTime.Today;               
            dtpBirthDate.Value = DateTime.Today.AddYears(-20);
        }

        private void Input_Changed(object sender, EventArgs e)
        {
            epCheck.SetError((Control)sender, "");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            epCheck.Clear();                                     
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirm.Text) || txtConfirm.Text != txtPassword.Text)
            {
                epCheck.SetError(txtConfirm, "Mật khẩu nhập lại không khớp!");
                isValid = false;
            }

            int age = CalculateAge(dtpBirthDate.Value);
            if (age < 18)
            {
                epCheck.SetError(dtpBirthDate, "Bạn phải đủ 18 tuổi trở lên (hiện tại: " + age + " tuổi)!");
                isValid = false;
            }

            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms, "Bạn phải đồng ý với Điều khoản dịch vụ!");
                isValid = false;
            }

            if (!isValid) return;                                

            string gender = rdoMale.Checked ? "Nam" : rdoFemale.Checked ? "Nữ" : "Khác";

            MessageBox.Show("Đăng ký thành công!\n\n" +
                            "Tên đăng nhập: " + txtUsername.Text.Trim() + "\n" +
                            "Ngày sinh: " + dtpBirthDate.Value.ToString("dd/MM/yyyy") + " (" + age + " tuổi)\n" +
                            "Giới tính: " + gender,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age))
                age--;
            return age;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            dtpBirthDate.Value = DateTime.Today.AddYears(-20);
            rdoMale.Checked = true;
            chkTerms.Checked = false;
            epCheck.Clear();
            txtUsername.Focus();
        }
    }
}