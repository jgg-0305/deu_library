using System.Drawing;
using System.Windows.Forms;

namespace deu_library
{
    public class RequestForm : Form
    {
        public RequestForm()
        {
            Text = "자료신청";
            ClientSize = new Size(700, 500);
            var label = new Label
            {
                Text = "자료신청 화면",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14F)
            };
            Controls.Add(label);
        }
    }
}