using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        // 建構函式：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算總薪資」按鈕時觸發
        private void calculateButton_Click(object sender, EventArgs e)
        {
           // 此處可加入計算薪資的程式邏輯
           const decimal BASE_HOURS = 40m;
           const decimal OT_MULTIPLIER = 1.5m;

            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    grossPay = (BASE_HOURS * hourlyPayRate) +
                               ((hoursWorked - BASE_HOURS) * hourlyPayRate * OT_MULTIPLIER);
                }
                grossPayLabel.TextAlign =ContentAlignment.MiddleCenter;
                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 當使用者按下「清除」按鈕時觸發
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空工時、時薪輸入框及總薪資標籤
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標焦點移回工時輸入框，方便再次輸入
            hoursWorkedTextBox.Focus();
        }

        // 當使用者按下「離開」按鈕時觸發
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }

        private void grossPayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
