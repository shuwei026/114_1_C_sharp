using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile; // 宣告 StreamReader 物件以讀取檔案  
            decimal totalsale = 0.0m; // 儲存總銷售額的變數
            decimal currentSale = 0.0m; // 儲存目前銷售額的變數
            string line; // 儲存讀取的資料列

            decimal[] sales = new decimal[8]; // 儲存銷售額的陣列
            int index = 0; // 陣列索引
            try
            {
                inputFile = File.OpenText("Sales.txt"); // 開啟 Sales.txt 檔案
                saleslistbox.Items.Clear(); // 清除清單框中的項目
                while (!inputFile.EndOfStream) // 讀取直到檔案結尾  
                {
                    if (decimal.TryParse (line =inputFile.ReadLine(), out currentSale) )
                    {
                        saleslistbox.Items.Add(line); // 將讀取的資料加入清單框中
                        sales[index] = currentSale; // 將目前銷售額存入陣列
                        index++;


                    }
                    else

                    {
                        MessageBox.Show("資料格式錯誤: " + line);
                        break; 
                    }
                    
                }
                inputFile.Close(); // 關閉檔案

                for (int i = 0; i < index; i++) // 計算總銷售額
                {
                    totalsale += sales[i];
                }   
                totalLabel.Text = totalsale.ToString("c"); // 顯示總銷售額
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤:" + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
