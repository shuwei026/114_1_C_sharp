using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕的事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3;

            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                double average = (test1 + test2 + test3) / 3.0;

                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外發生!");
            }
        }
            







                // 此處可加入計算平均分數的程式碼


            // 清除按鈕的事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除所有輸入與輸出欄位
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
            // 將焦點設回第一個輸入欄位
            test1TextBox.Focus();
        }

        // 離開按鈕的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void averageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
