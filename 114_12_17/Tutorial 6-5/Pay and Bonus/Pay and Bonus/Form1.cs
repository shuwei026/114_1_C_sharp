using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    /// <summary>
    /// 給與獎金計算表單 - 用於計算員工的退休提撥額
    /// </summary>
    public partial class Form1 : Form
    {
        // 常數：提撥率為5%
        private const decimal CONTRIB_RATE = 0.05m;

        /// <summary>
        /// 建構子 - 初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        // InputIsValid方法將使用者輸入轉換並將其儲存在
        // 引數（以傳址方式傳遞）中。如果轉換成功，
        // 該方法傳回true。否則傳回false。
        
        /// <summary>
        /// 計算按鈕點擊事件處理器 - 計算基於總給付金額和獎金的退休提撥額
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
           decimal grossPay =0; // 總給付金額
           decimal bonus =0;    // 獎金金額
           decimal contribution = 0; // 退休提撥額
            if (InputIsValid(ref grossPay, ref bonus))
            {
                // 計算退休提撥額
                contribution = (grossPay + bonus) * CONTRIB_RATE;
                // 顯示結果
                contributionLabel.Text = "退休提撥額為：" + contribution.ToString("c");
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
            }
        }
        private bool InputIsValid(ref decimal grossPay, ref decimal bonus)
        {
            bool isValid = false;
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    isValid = true;
                }
                else
                {
                    MessageBox.Show("請輸入有效的獎金金額。", "輸入錯誤");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的總給付金額。", "輸入錯誤");
            }
            return isValid;
        }
        

        /// <summary>
        /// 結束按鈕點擊事件處理器 - 關閉表單
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
