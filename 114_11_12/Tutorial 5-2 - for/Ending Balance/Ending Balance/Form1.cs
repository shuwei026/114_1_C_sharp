using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    // 本檔案包含 Windows Form (Form1) 的程式邏輯。
    // Form1 的用途：接收使用者輸入的起始餘額與月份數量，
    // 顯示每個月的明細於 ListBox，並顯示最終結餘。
    // 以下方法為事件處理常見的三個按鈕事件：計算、清除、退出。
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件。
        /// 在此呼叫 InitializeComponent 以建立並配置 UI 控制項。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算按鈕的事件處理器 (calculateButton_Click)
        /// 說明：當使用者按下「計算」按鈕時會觸發此方法。
        /// 詳細註解（建議實作步驟）：
        /// 1. 讀取起始餘額 (startingBalTextBox.Text) 與月份數量 (monthsTextBox.Text)。
        /// 2. 驗證輸入：
        ///    - 確認起始餘額能轉換為數值 (decimal 或 double)，且為非負數。
        ///    - 確認月份數量能轉換為整數，且為正值。
        ///    - 若驗證失敗，可使用 MessageBox.Show 通知使用者並使用 Focus() 將焦點移回對應的 TextBox。
        /// 3. 若輸入有效，清除 detailListBox 的現有項目（若尚未清除）。
        /// 4. 使用迴圈 (for 或 while) 以月份為單位計算每月變化：
        ///    - 根據需求計算每個月的利息或增減（此範例未定義利率，實做時請加入利率來源）。
        ///    - 將每月的說明字串加入到 detailListBox.Items 中，讓使用者看到逐月明細。
        /// 5. 在迴圈結束後，將最終結餘顯示於 endingBalanceLabel.Text（格式化為貨幣或兩位小數）。
        /// 6. 若要改善使用者體驗，考慮在可能的錯誤情況下使用 try/catch 捕捉並處理例外。
        /// 注意：此方法目前為空，僅加入註解說明如何實作。請依實際業務邏輯補上計算程式碼。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // TODO: 在此實作計算邏輯。

            const decimal interestRate = 0.005m; // 假設每月利率為 0.5%
            decimal startingBalance; // 起始餘額
            int months; // 月份數量
            int count = 1; // 月份計數器

            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0)
                {
                   for (count = 1; count <= months; count++)
                   {
                       decimal interest = startingBalance * interestRate; // 計算當月利息
                       startingBalance += interest; // 更新餘額
                       // 將每月明細加入 ListBox
                       detailListBox.Items.Add($"第 {count} 個月：利息 {interest:C2}，結餘 {startingBalance:C2}");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數量（正整數）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    monthsTextBox.Focus(); // 將焦點回到月份數量文字方塊
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額和月份數量。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startingBalTextBox.Focus(); // 將焦點回到起始餘額文字方塊
            }
        }

        /// <summary>
        /// 清除按鈕的事件處理器 (clearButton_Click)
        /// 說明：當使用者按下「清除」按鈕時，會清除所有輸入與輸出控制項的內容，
        /// 並將輸入焦點重設到起始餘額的文字方塊。
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空 TextBox、顯示結餘的 Label，以及 ListBox 內的所有項目。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 將輸入焦點回到起始餘額的文字方塊，方便使用者繼續輸入。
            startingBalTextBox.Focus();
        }

        /// <summary>
        /// 退出按鈕的事件處理器 (exitButton_Click)
        /// 說明：當使用者按下「退出」按鈕時，關閉目前的表單 (Form1)，
        /// 若此表單是應用程式的主視窗，應用程式將結束。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
