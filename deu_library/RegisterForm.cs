using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace deu_library
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            Text = "자료 등록 관리";
            StartPosition = FormStartPosition.CenterParent;
        }
    }
}
