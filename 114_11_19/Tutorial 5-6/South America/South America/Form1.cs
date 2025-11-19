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

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            StreamReader inputfile; // 修正類型為 StreamReader
            string countryName;

            try
            {
                inputfile = File.OpenText(@"C:\Users\m303\Desktop\114_1_C_sharp\114_11_19\Countries.txt");
                countriesListBox.Items.Clear();

                while (!inputfile.EndOfStream)
                {
                    countryName = inputfile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // 修正缺少的閉合大括號
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
