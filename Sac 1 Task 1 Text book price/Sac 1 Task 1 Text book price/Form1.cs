using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sac_1_Task_1_Text_book_price
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ButtonWorth_Click(object sender, EventArgs e)
        {
            
            double BookWorth = 0;
            BookWorth = double.Parse(Price.Text) - (double.Parse(Price.Text) * (double.Parse(Age.Text) * 0.2));
            double WorthTotal = double.Parse(TotalWorth.Text); 
            WorthOfBook.Text = "$" + BookWorth;
            double RealTotal = WorthTotal + BookWorth;
            TotalWorth.Text = ""+ RealTotal;
            


        }

        private void EndQuote_Click(object sender, EventArgs e)
        {
            Age.Text = "";
            Price.Text = "";
            WorthOfBook.Text = "$0";
            TotalWorth.Text = "0";
        }
    }
}
