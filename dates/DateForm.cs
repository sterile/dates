/*
 * Grading ID: M5477
 * Lab: 9
 * Due Date: April 21 2019
 * Course Section: 01
 * Description: A simple demonstration of using an external class
 */

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

        private void DateForm_Load(object sender, EventArgs e)
        {
            dateBox.Text = dateClass.ToString();
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            bool validInput;
            int month;

            validInput = int.TryParse(monthBox.Text, out month);

            if (validInput)
            {
                dateClass.Month = month;
                monthBox.Text = null;
                dateBox.Text = dateClass.ToString();
            }
            else
            {
                MessageBox.Show("Please update your input to contain whole numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dayButton_Click(object sender, EventArgs e)
        {
            bool validInput;
            int day;

            validInput = int.TryParse(dayBox.Text, out day);

            if (validInput)
            {
                dateClass.Day = day;
                dayBox.Text = null;
                dateBox.Text = dateClass.ToString();
            }
            else
            {
                MessageBox.Show("Please update your input to contain whole numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            bool validInput;
            int year;

            validInput = int.TryParse(yearBox.Text, out year);

            if (validInput)
            {
                dateClass.Year = year;
                yearBox.Text = null;
                dateBox.Text = dateClass.ToString();
            }
            else
            {
                MessageBox.Show("Please update your input to contain whole numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
