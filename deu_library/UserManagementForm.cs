using System;
using System.Drawing;
using System.Windows.Forms;

namespace deu_library
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            Text = "이용자 관리";
            ClientSize = new Size(800, 600);
            var label = new Label
            {
                Text = "이용자 관리 화면",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14F)
            };
            Controls.Add(label);
        }
    }
}