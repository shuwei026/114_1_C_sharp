using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    /// <summary>
    /// 樂透號碼產生器表單
    /// 此表單用於產生隨機的樂透號碼
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form1 建構函式
        /// 初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 產生號碼按鈕的點擊事件處理程式
        /// 點擊此按鈕時會隨機產生五個樂透號碼並顯示在標籤上
        /// </summary>
        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];
            Label[] labels =  { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            Random rand = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                lotteryNumbers[i] = rand.Next(1, 50); // 產生 1 到 49 的隨機數字
            }
            //firstLabel.Text = lotteryNumbers[4].ToString();
            //secondLabel.Text = lotteryNumbers[3].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[1].ToString();
            //fifthLabel.Text = lotteryNumbers[0].ToString();

            for (int i = 0; i < SIZE; i++)
            {
                labels[i].Text = lotteryNumbers[i].ToString();
            }

        }

        /// <summary>
        /// 結束按鈕的點擊事件處理程式
        /// 點擊此按鈕時會關閉應用程式
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗
            this.Close();
        }
    }
}
