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
using System.Globalization;

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
            OpenFileDialog openFileDialog = new OpenFileDialog(); // 初始化 OpenFileDialog
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("未選取檔案");
                return;
            }

            string filePath = openFileDialog.FileName;
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額

            try
            {
                using (StreamReader inputFile = new StreamReader(filePath))
                {
                    salesListBox.Items.Clear();

                    while (!inputFile.EndOfStream)
                    {
                        string line = inputFile.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        line = line.Trim();

                        // 支援多種分隔符
                        string[] parts = line.Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        string month = "";
                        string salesValue = null;

                        // 嘗試從每個欄位找出金額
                        foreach (var part in parts.Reverse())
                        {
                            string cleaned = part.Replace("$", "").Replace(",", "").Replace("NT$", "").Replace("¥", "").Trim();
                            if (decimal.TryParse(cleaned, NumberStyles.Any, CultureInfo.CurrentCulture, out currentSales) ||
                                decimal.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out currentSales))
                            {
                                salesValue = cleaned;
                                break;
                            }
                        }
                        if (salesValue != null)
                        {
                            // 取金額前面的欄位當月份
                            int idx = Array.FindLastIndex(parts, p => p.Replace("$", "").Replace(",", "").Replace("NT$", "").Replace("¥", "").Trim() == salesValue);
                            if (idx > 0)
                                month = string.Join(" ", parts.Take(idx));
                            salesListBox.Items.Add((string.IsNullOrEmpty(month) ? "" : month + " ") + currentSales.ToString("C"));
                            totalSales += currentSales;
                        }
                        else
                        {
                            MessageBox.Show("無法解析銷售額: " + line);
                            continue;
                        }
                    }
                }
                totalLabel.Text = totalSales.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
