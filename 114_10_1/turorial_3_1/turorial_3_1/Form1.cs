using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turorial_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dayOfWeek =dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string year = yearTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;

            string output = "中華民國" + year + " 年 " + month + "月" + dayOfMonth + "日" + ",星期" + dayOfWeek;

            dateOutputLabel.Text = output;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";
            dateOutputLabel.Text = ""; 
        }
    }
}
