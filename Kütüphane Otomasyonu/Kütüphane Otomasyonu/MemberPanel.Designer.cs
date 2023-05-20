namespace Kütüphane_Otomasyonu
{
    partial class MemberPanel
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
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(611, 376);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Ara";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(586, 350);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_search.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 405);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Çıkış Yap";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookName,
            this.author,
            this.language,
            this.publisher,
            this.genre,
            this.count,
            this.pageCount,
            this.publicationYear});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 332);
            this.dataGridView1.TabIndex = 14;
            // 
            // bookId
            // 
            this.bookId.HeaderText = "Id";
            this.bookId.Name = "bookId";
            this.bookId.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Ad";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "Yazar";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // language
            // 
            this.language.HeaderText = "Dil";
            this.language.Name = "language";
            this.language.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Yayın Evi";
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.HeaderText = "Tür";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Adet";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // pageCount
            // 
            this.pageCount.HeaderText = "Sayfa Sayısı";
            this.pageCount.Name = "pageCount";
            this.pageCount.ReadOnly = true;
            // 
            // publicationYear
            // 
            this.publicationYear.HeaderText = "Basım Yılı";
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.ReadOnly = true;
            // 
            // MemberPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Name = "MemberPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberPanel";
            this.Load += new System.EventHandler(this.MemberPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationYear;
    }
}