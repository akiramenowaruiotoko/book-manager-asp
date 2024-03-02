namespace BookManagerWinForm
{
    partial class Edit
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
            buttonBackPurchase = new Button();
            buttonEditAccount = new Button();
            buttonEditBook = new Button();
            buttonAddAccount = new Button();
            buttonAddBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 59);
            label1.TabIndex = 9;
            label1.Text = "Book Manager";
            // 
            // buttonBackPurchase
            // 
            buttonBackPurchase.Location = new Point(350, 16);
            buttonBackPurchase.Name = "buttonBackPurchase";
            buttonBackPurchase.Size = new Size(302, 60);
            buttonBackPurchase.TabIndex = 10;
            buttonBackPurchase.Text = "back";
            buttonBackPurchase.UseVisualStyleBackColor = true;
            buttonBackPurchase.Click += buttonBackEdit_Click;
            // 
            // buttonEditAccount
            // 
            buttonEditAccount.Location = new Point(82, 209);
            buttonEditAccount.Name = "buttonEditAccount";
            buttonEditAccount.Size = new Size(232, 62);
            buttonEditAccount.TabIndex = 11;
            buttonEditAccount.Text = "edit account";
            buttonEditAccount.UseVisualStyleBackColor = true;
            // 
            // buttonEditBook
            // 
            buttonEditBook.Location = new Point(381, 209);
            buttonEditBook.Name = "buttonEditBook";
            buttonEditBook.Size = new Size(232, 62);
            buttonEditBook.TabIndex = 12;
            buttonEditBook.Text = "edit book";
            buttonEditBook.UseVisualStyleBackColor = true;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Location = new Point(82, 109);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(232, 62);
            buttonAddAccount.TabIndex = 13;
            buttonAddAccount.Text = "add account";
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(381, 109);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(232, 62);
            buttonAddBook.TabIndex = 14;
            buttonAddBook.Text = "add book";
            buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 306);
            Controls.Add(buttonAddBook);
            Controls.Add(buttonAddAccount);
            Controls.Add(buttonEditBook);
            Controls.Add(buttonEditAccount);
            Controls.Add(buttonBackPurchase);
            Controls.Add(label1);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBackPurchase;
        private Button buttonEditAccount;
        private Button buttonEditBook;
        private Button buttonAddAccount;
        private Button buttonAddBook;
    }
}