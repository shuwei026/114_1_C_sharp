using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CupsToOunces 方法接受杯子數量作為參數
        // 並返回對應的流體盎司數量
        // 轉換公式：1杯 = 8流體盎司
        
        /// <summary>
        /// 將杯子轉換為流體盎司的方法
        /// </summary>
        /// <param name="cups">輸入的杯子數量</param>
        /// <returns>返回對應的流體盎司數量</returns>
        private double CupsToOunces(double cups)
        {
            return cups * 8;
        }

        /// <summary>
        /// 轉換按鈕點擊事件處理程序
        /// 從輸入框獲取杯子數量，進行轉換，並顯示結果
        /// </summary>
        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups;
            double ounces;

            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // 調用 CupsToOunces 方法進行轉換
                ounces = CupsToOunces(cups);
                // 顯示結果
                ouncesLabel.Text = ounces.ToString("F2") + " 流體盎司";
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("請輸入有效的杯子數量。", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CupToOunces(double cups)
        {
           return cups * 8.0;
        }

        /// <summary>
        /// 結束按鈕點擊事件處理程序
        /// 關閉應用程式視窗
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉應用程式視窗
            this.Close();
        }

        private void ouncesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
