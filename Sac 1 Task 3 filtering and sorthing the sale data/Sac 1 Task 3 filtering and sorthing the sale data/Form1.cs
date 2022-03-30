using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sac_1_Task_3_filtering_and_sorthing_the_sale_data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FileSelect_Click(object sender, EventArgs e)
        {
            //gets the file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                

                foreach (string line in lines)
                {
                    //splits the data to make the diffrent rows 
                    List<string> fields = line.Split(',').ToList();
                    dataGridView1.Rows.Add(fields.ToArray());
                }
            }
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //the combobox Filter updates the datagridview with the use of the user input with Search to minipulate the grid 
            string FilterGrid = Filter.Text;
            //does some if statements to change the grid 
            if (Filter.Text == "textbook")
            {
                dataGridView1.Sort(dataGridView1.Columns[0], Textbook = Search.Text);
            }
            if (Filter.Text == "subject")
            {
                dataGridView1.Sort(dataGridView1.Columns[1], Subject = Search.Text);
            }
            if (Filter.Text == "rating")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], Rating = Search.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
    }
}