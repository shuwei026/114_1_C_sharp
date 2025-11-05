using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "點餐內容: ";
            string drink = "";
            string sandwich = "";

            if (radioButton1.Checked == true)

            {
                drink = "咖啡";

               
            }
            else if (radioButton2.Checked == true)
            {
                drink = "奶茶";
            }
            else if (radioButton3.Checked == true)
            {
                drink = "紅茶";

            }
            else if (radioButton4.Checked == true)
            {
                drink = "果汁";
            }
            else
            {
                drink = "無飲料";
            }
            if (radioButton5.Checked == true)
            {
                sandwich = "鮪魚三明治";
            }
            else if (radioButton6.Checked == true)
            {
                sandwich = "火腿三明治";
            }
            else if (radioButton7.Checked == true)
            {
                sandwich = "果醬三明治";
            }
            
            else
            {
                sandwich = "無三明治";
            }
            message += drink + "、" + sandwich;
            MessageBox.Show(message,"您的點餐內容");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
