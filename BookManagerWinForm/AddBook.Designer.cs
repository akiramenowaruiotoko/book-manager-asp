namespace BookManagerWinForm
{
    partial class AddBook
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
            buttonAddBook = new Button();
            textBoxBookId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxBookName = new TextBox();
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
            buttonBack.Location = new Point(486, 16);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(302, 60);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(26, 218);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(294, 51);
            buttonAddBook.TabIndex = 12;
            buttonAddBook.Text = "add book";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // textBoxBookId
            // 
            textBoxBookId.Location = new Point(26, 140);
            textBoxBookId.Name = "textBoxBookId";
            textBoxBookId.Size = new Size(245, 39);
            textBoxBookId.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 105);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 14;
            label2.Text = "book id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 105);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 15;
            label3.Text = "book name";
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(303, 140);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(245, 39);
            textBoxBookName.TabIndex = 16;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 310);
            Controls.Add(textBoxBookName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxBookId);
            Controls.Add(buttonAddBook);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "AddBook";
            Text = "AddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private Button buttonAddBook;
        private TextBox textBoxBookId;
        private Label label2;
        private Label label3;
        private TextBox textBoxBookName;
    }
}