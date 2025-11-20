using System;
using System.Windows.Forms;

namespace deu_library
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoanReturnForm loanReturnForm = new LoanReturnForm();
            loanReturnForm.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new RequestForm { StartPosition = FormStartPosition.CenterParent };
            f.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new UserManagementForm { StartPosition = FormStartPosition.CenterParent };
            f.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var f = new RequestManagementForm { StartPosition = FormStartPosition.CenterParent };
            f.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var f = new StatisticsForm { StartPosition = FormStartPosition.CenterParent };
            f.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var f = new DataSearchForm { StartPosition = FormStartPosition.CenterParent };
            f.Show(this);
        }
    }
}