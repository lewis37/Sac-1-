namespace Sac_1_Task_2_Book_Reading_CSV_file
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
            this.ChooseAFile = new System.Windows.Forms.Button();
            this.BookData = new System.Windows.Forms.DataGridView();
            this.Textbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookData)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseAFile
            // 
            this.ChooseAFile.Location = new System.Drawing.Point(98, 24);
            this.ChooseAFile.Name = "ChooseAFile";
            this.ChooseAFile.Size = new System.Drawing.Size(120, 29);
            this.ChooseAFile.TabIndex = 0;
            this.ChooseAFile.Text = "Choose a file ";
            this.ChooseAFile.UseVisualStyleBackColor = true;
            this.ChooseAFile.Click += new System.EventHandler(this.ChooseAFile_Click);
            // 
            // BookData
            // 
            this.BookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Textbook,
            this.Subject,
            this.Seller,
            this.Purchaser,
            this.purchasePrice,
            this.saleprice,
            this.Profit});
            this.BookData.Location = new System.Drawing.Point(12, 76);
            this.BookData.Name = "BookData";
            this.BookData.Size = new System.Drawing.Size(743, 251);
            this.BookData.TabIndex = 1;
            this.BookData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookData_CellContentClick);
            // 
            // Textbook
            // 
            this.Textbook.HeaderText = "Textbook";
            this.Textbook.Name = "Textbook";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject ";
            this.Subject.Name = "Subject";
            // 
            // Seller
            // 
            this.Seller.HeaderText = "Seller";
            this.Seller.Name = "Seller";
            // 
            // Purchaser
            // 
            this.Purchaser.HeaderText = "Purchaser";
            this.Purchaser.Name = "Purchaser";
            // 
            // purchasePrice
            // 
            this.purchasePrice.HeaderText = "Purchase Price ";
            this.purchasePrice.Name = "purchasePrice";
            // 
            // saleprice
            // 
            this.saleprice.HeaderText = "Sale Price ";
            this.saleprice.Name = "saleprice";
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "choose a CSV file to calculate profit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookData);
            this.Controls.Add(this.ChooseAFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BookData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseAFile;
        private System.Windows.Forms.DataGridView BookData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Textbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Label label1;
    }
}

