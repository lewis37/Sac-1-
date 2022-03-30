namespace Sac_1_Task_3_filtering_and_sorthing_the_sale_data
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
            this.FileSelect = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Textbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileSelect
            // 
            this.FileSelect.Location = new System.Drawing.Point(58, 31);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(75, 23);
            this.FileSelect.TabIndex = 0;
            this.FileSelect.Text = "Choose File ";
            this.FileSelect.UseVisualStyleBackColor = true;
            this.FileSelect.Click += new System.EventHandler(this.FileSelect_Click);
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "textbook",
            "subject",
            "rating"});
            this.Filter.Location = new System.Drawing.Point(261, 85);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(121, 21);
            this.Filter.TabIndex = 1;
            this.Filter.SelectedIndexChanged += new System.EventHandler(this.Filter_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Textbook,
            this.Subject,
            this.PurchasePrice,
            this.SalePrice,
            this.Rating});
            this.dataGridView1.Location = new System.Drawing.Point(146, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 184);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Textbook
            // 
            this.Textbook.HeaderText = "Textbook";
            this.Textbook.Name = "Textbook";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Purchase price ";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "Sale Price ";
            this.SalePrice.Name = "SalePrice";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating ";
            this.Rating.Name = "Rating";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(399, 86);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(158, 20);
            this.Search.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.FileSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSelect;
        private System.Windows.Forms.ComboBox Filter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Textbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
    }
}

