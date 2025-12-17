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

namespace North_America
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the file name from the user.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <returns>A value indicating whether the operation succeeded.</returns>

        /// <summary>
        /// 取得國家資料的方法
        /// 接受檔名作為參數，開啟指定的檔案並在 countriesListBox 控制項中顯示其內容
        /// </summary>
        

        /// <summary>
        /// 取得國家按鈕的點擊事件處理方法
        /// 開啟檔案對話方塊讓使用者選擇要載入的檔案
        /// </summary>
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;
            // 呼叫 GetFileName 方法取得使用者選擇的檔案名稱
            GetFileName(out fileName);
            // 如果使用者選擇了檔案，則呼叫 GetCountries 方法載入國家資料
            getcountrries(fileName);


        }
        private void GetFileName(out string fileName)
        {
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // 取得使用者選擇的檔案名稱
                fileName = openFile.FileName;
            }
            else
            {
                // 如果使用者取消選擇，則將檔案名稱設為空字串
                fileName = string.Empty;
            }
        }
        private void getcountrries(string fileName)
        {
           string country;
            // 清空 countriesListBox 控制項中的現有項目
            countriesListBox.Items.Clear();
            if (openFile.FileName != string.Empty)
            {
                StreamReader inputfile = File.OpenText(fileName);
                // 逐行讀取檔案內容，直到檔案結尾
                while (!inputfile.EndOfStream)
                {
                    country = inputfile.ReadLine();
                    // 將讀取到的國家名稱加入到 countriesListBox 控制項中
                    countriesListBox.Items.Add(country);
                }
            }
        }

        /// <summary>
        /// 退出按鈕的點擊事件處理方法
        /// 關閉表單視窗
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

    }
}
