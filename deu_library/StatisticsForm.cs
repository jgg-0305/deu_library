using System;
using System.Drawing;
using System.Windows.Forms;

namespace deu_library
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            Text = "통계";
            ClientSize = new Size(900, 600);
            var label = new Label
            {
                Text = "통계 화면",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14F)
            };
            Controls.Add(label);
        }
    }
}
