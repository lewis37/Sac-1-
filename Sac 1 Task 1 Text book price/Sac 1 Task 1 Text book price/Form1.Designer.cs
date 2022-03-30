namespace Sac_1_Task_1_Text_book_price
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonWorth = new System.Windows.Forms.Button();
            this.EndQuote = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.WorthOfBook = new System.Windows.Forms.Label();
            this.TotalWorth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "How Old is the textbook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "How much did you pay for it? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "It is Worth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "The total collection is worth ";
            // 
            // ButtonWorth
            // 
            this.ButtonWorth.Location = new System.Drawing.Point(210, 238);
            this.ButtonWorth.Name = "ButtonWorth";
            this.ButtonWorth.Size = new System.Drawing.Size(75, 23);
            this.ButtonWorth.TabIndex = 6;
            this.ButtonWorth.Text = "Calculate";
            this.ButtonWorth.UseVisualStyleBackColor = true;
            this.ButtonWorth.Click += new System.EventHandler(this.ButtonWorth_Click);
            // 
            // EndQuote
            // 
            this.EndQuote.Location = new System.Drawing.Point(404, 238);
            this.EndQuote.Name = "EndQuote";
            this.EndQuote.Size = new System.Drawing.Size(106, 23);
            this.EndQuote.TabIndex = 7;
            this.EndQuote.Text = "End the Quote";
            this.EndQuote.UseVisualStyleBackColor = true;
            this.EndQuote.Click += new System.EventHandler(this.EndQuote_Click);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(210, 87);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 20);
            this.Age.TabIndex = 8;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(210, 187);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 9;
            // 
            // WorthOfBook
            // 
            this.WorthOfBook.AutoSize = true;
            this.WorthOfBook.Location = new System.Drawing.Point(560, 54);
            this.WorthOfBook.Name = "WorthOfBook";
            this.WorthOfBook.Size = new System.Drawing.Size(19, 13);
            this.WorthOfBook.TabIndex = 10;
            this.WorthOfBook.Text = "$0";
            this.WorthOfBook.UseMnemonic = false;
            // 
            // TotalWorth
            // 
            this.TotalWorth.AutoSize = true;
            this.TotalWorth.Location = new System.Drawing.Point(635, 95);
            this.TotalWorth.Name = "TotalWorth";
            this.TotalWorth.Size = new System.Drawing.Size(13, 13);
            this.TotalWorth.TabIndex = 11;
            this.TotalWorth.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalWorth);
            this.Controls.Add(this.WorthOfBook);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.EndQuote);
            this.Controls.Add(this.ButtonWorth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonWorth;
        private System.Windows.Forms.Button EndQuote;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label WorthOfBook;
        private System.Windows.Forms.Label TotalWorth;
    }
}

