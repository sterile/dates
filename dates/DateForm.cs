using System;
using System.Windows.Forms;

namespace dates
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            Date dateClass = new Date(1, 1, 2000);
            dateBox.Text = dateClass.ToString();
        }
    }
}
