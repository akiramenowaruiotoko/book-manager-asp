namespace BookManagerWinForm
{
    partial class EditBook
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
            label1 = new Label();
            buttonBack = new Button();
            buttonEditBook = new Button();
            textBoxBookId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxBookName = new TextBox();
            buttonDeleteBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 59);
            label1.TabIndex = 10;
            label1.Text = "Book Manager";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(344, 16);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(302, 60);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += ButtonBack_Click;
            // 
            // buttonEditBook
            // 
            buttonEditBook.Location = new Point(28, 193);
            buttonEditBook.Name = "buttonEditBook";
            buttonEditBook.Size = new Size(245, 51);
            buttonEditBook.TabIndex = 12;
            buttonEditBook.Text = "Edit Book";
            buttonEditBook.UseVisualStyleBackColor = true;
            buttonEditBook.Click += buttonEditBook_Click;
            // 
            // textBoxBookId
            // 
            textBoxBookId.Location = new Point(28, 133);
            textBoxBookId.Name = "textBoxBookId";
            textBoxBookId.Size = new Size(245, 39);
            textBoxBookId.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 98);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 14;
            label2.Text = "book id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 98);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 15;
            label3.Text = "book name";
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(344, 133);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(245, 39);
            textBoxBookName.TabIndex = 16;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.Location = new Point(344, 193);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(245, 51);
            buttonDeleteBook.TabIndex = 17;
            buttonDeleteBook.Text = "Delete Book";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            buttonDeleteBook.Click += buttonDeleteBook_Click;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 272);
            Controls.Add(buttonDeleteBook);
            Controls.Add(textBoxBookName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxBookId);
            Controls.Add(buttonEditBook);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "EditBook";
            Text = "EditBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private Button buttonEditBook;
        private TextBox textBoxBookId;
        private Label label2;
        private Label label3;
        private TextBox textBoxBookName;
        private Button buttonDeleteBook;
    }
}