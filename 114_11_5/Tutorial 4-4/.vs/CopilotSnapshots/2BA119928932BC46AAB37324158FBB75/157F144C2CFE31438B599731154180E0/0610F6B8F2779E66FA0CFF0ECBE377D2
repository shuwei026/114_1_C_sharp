using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 此事件處理常駐按鈕點擊，負責從使用者輸入讀取公里數與公升數，
            // 驗證輸入是否為有效數值，接著計算並顯示 L/100km（每百公里油耗）。

            // 宣告本方法使用的變數：kilometers (公里)、liters (公升)
            double kilometers;
            double liters;

            // 使用 double.TryParse 嘗試將使用者輸入（文字）轉成 double。
            // TryParse 在解析失敗時不會拋出例外，而會回傳 false，便於我們處理錯誤輸入。
            if (!double.TryParse(milesTextBox.Text, out kilometers))
            {

                // 解析失敗：提醒使用者輸入必須為數字，並將焦點回到公里輸入欄位
                MessageBox.Show("請輸入有效的公里數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                milesTextBox.Focus();
                return; // 中止計算流程
            }

            if (!double.TryParse(gallonsTextBox.Text, out liters))
            {
                // 解析失敗：提醒使用者輸入必須為數字，並將焦點回到公升輸入欄位
                MessageBox.Show("請輸入有效的公升數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gallonsTextBox.Focus();
                return; // 中止計算流程
            }

            // 檢查邊界條件：公里數與公升數必須大於 0，否則無法計算
            if (kilometers <= 0)
            {
                MessageBox.Show("公里數必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                milesTextBox.Focus();
                return;
            }

            if (liters <= 0)
            {
                MessageBox.Show("公升數必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gallonsTextBox.Focus();
                return;
            }

            // 計算公式：L/100km = (liters / kilometers) * 100
            // 先用 double 儲存計算結果，然後格式化為小數點兩位顯示。
            double consumption = (liters / kilometers) * 100.0;

            // 將結果顯示在 mpgLabel（此範例仍沿用該控制項名稱），並附加單位文字 L/100km
            mpgLabel.Text = consumption.ToString("F2") + " L/100km";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單（結束應用程式視窗）
            this.Close();
        }
    }
}
