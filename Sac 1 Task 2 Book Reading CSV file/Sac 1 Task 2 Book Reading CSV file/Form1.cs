using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sac_1_Task_2_Book_Reading_CSV_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BookData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //choose a file and calculates the total profit
        private void ChooseAFile_Click(object sender, EventArgs e)
        {
            //gets the file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                float total = 0f; ;

                foreach (string line in lines)
                {
                    //splits the data to make the diffrent rows 
                    List<string> fields = line.Split(',').ToList();
                    float profit;
                    //gets the sale and purchase price 
                    string salePrice = fields[5];
                    float purchasedPrice = float.Parse(fields[4]);
                    //checks if its a number 
                    if (float.TryParse(salePrice, out float _saleprice))
                    {
                        profit = _saleprice - purchasedPrice;
                    }
                    //if not a number then just makes profit = to negative purchase price since not sold for any money 
                    else
                    {
                        profit = purchasedPrice * -1;
                    }
                    //adds the profit to the total proft 
                    total += profit;                   
                    fields.Add(profit.ToString());
                    BookData.Rows.Add(fields.ToArray());
                }
            }
        }
    }
}
