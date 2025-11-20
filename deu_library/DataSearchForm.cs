using System;
using System.Drawing;
using System.Windows.Forms;

namespace deu_library
{
    public class DataSearchForm : Form
    {
        public DataSearchForm()
        {
            Text = "자료 찾기";
            ClientSize = new Size(600, 420);

            var label = new Label
            {
                Text = "자료 찾기 화면",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14F)
            };

            Controls.Add(label);
        }
    }
}