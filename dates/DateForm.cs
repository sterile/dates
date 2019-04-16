using System;
using System.Windows.Forms;

namespace dates
{
    public partial class DateForm : Form
    {
        private Date dateClass = new Date(1, 1, 2000);

        public DateForm()
        {
            InitializeComponent();
        }

        private void UpdateDate()
        {
            dateBox.Text = dateClass.ToString();
        }

        private void ChangeDate(TextBox input, int change)
        {
            int update;
            bool validInput;

            validInput = int.TryParse(input.Text, out update);

            if (validInput)
            {
                change = update;
                UpdateDate();
            }
            else
            {
                MessageBox.Show("Please input integers only!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            ChangeDate(monthBox, dateClass.Month);
        }

        private void dayButton_Click(object sender, EventArgs e)
        {
            ChangeDate(dayBox, dateClass.Day);
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            ChangeDate(yearBox, dateClass.Year);
        }
    }
}
