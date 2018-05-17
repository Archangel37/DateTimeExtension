using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace YieldDateTime
{
    public partial class FormYieldDateTime : Form
    {
        public FormYieldDateTime()
        {
            InitializeComponent();
        }

        private void buttonGetDays_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDays.Text, out int days))
            {
                richTextBoxResultDays.Text = string.Join("\n", DateTime.Now.TakeDays(days).Select(d => d.ToHumanView()));
            }
        }
    }
}
