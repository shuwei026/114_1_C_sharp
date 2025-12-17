using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowMax_Click(object sender, EventArgs e)
        {
            string surname = textBoxLastName.Text;
            string givenname = textBoxFirstName.Text;
            int quiz1, quiz2, quiz3;
            if (int.TryParse(textBoxTest1.Text, out quiz1) &&
                int.TryParse(textBoxTest2.Text, out quiz2) &&
                int.TryParse(textBoxTest3.Text, out quiz3))
            {
                MessageBox.Show(string.Format("小考2 ={0}", quiz2));
                showresults(surname, givenname, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("Please enter valid integer scores for all quizzes.", "Input Error");
                clearTextBoxes();
            }
        }
        private void showresults(string suername, string givenname, int quiz1,  int quiz2, int quiz3)
        {
            int highestScore = FindHighestScore(quiz1, quiz2, quiz3);

            labelResult.Text = string.Format(" {0} {1}\nHighest Quiz Score: {2}", suername, givenname, highestScore);   
        }

        private int FindHighestScore(int score1, int score2, int score3)
        {
            int highestScore = score1;
            if (score2 > highestScore)
            {
                highestScore = score2;
            }
            if (score3 > highestScore)
            {
                highestScore = score3;
            }
            return highestScore;
        }   
        private void clearTextBoxes()
        {


            textBoxTest1.Clear();
            textBoxTest2.Clear();
            textBoxTest3.Clear();
            textBoxTest1.Focus();
        }
    }
}
