using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deu_library
{
    public partial class LoanReturnForm : Form
    {
        public LoanReturnForm()
        {
            InitializeComponent();
            Text = "대출 / 반납";
            ClientSize = new Size(800, 600);
            var label = new Label
            {
                Text = "대출·반납 화면",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14F)
            };
            Controls.Add(label);
        }
    }
}
