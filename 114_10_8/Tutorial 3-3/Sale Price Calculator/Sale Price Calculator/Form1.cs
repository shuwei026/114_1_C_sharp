using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    // Form1 類別：主視窗表單，負責顯示折扣計算器的介面
    public partial class Form1 : Form
    {
        // 建構函式：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化所有視窗元件
        }

        // 當使用者點擊「計算折後價格」按鈕時觸發的事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 此處尚未實作計算邏輯
            decimal oringinalPrice;
            decimal discountPercentage;
            decimal salePrice;// 此處尚未實作計算邏輯
            // 建議：可在此加入取得原價與折扣百分比，並計算折後價格的程式碼
            oringinalPrice = Convert.ToDecimal(originalPriceTextBox.Text);
            discountPercentage = Convert.ToDecimal(discountPercentageTextBox.Text);
            salePrice = oringinalPrice * (1 - discountPercentage / 100.0m);

            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 當使用者點擊「離開」按鈕時觸發的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }

        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
