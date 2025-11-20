using System;
using System.Windows.Forms;

namespace deu_library
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            // Enter 누르면 로그인, Esc 누르면 취소
            this.AcceptButton = this.buttonLogin;
            this.CancelButton = this.buttonCancel;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = textBoxUser.Text?.Trim();
                var pass = textBoxPassword.Text ?? string.Empty;

                // 데모 인증: 필요하면 실제 인증 로직으로 교체
                if (string.Equals(user, "admin", StringComparison.OrdinalIgnoreCase) &&
                    pass == "1234")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "아이디 또는 비밀번호가 올바르지 않습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPassword.SelectAll();
                    textBoxPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"로그인 중 오류가 발생했습니다:\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
