namespace BookManagerWinForm
{
    partial class Purchase
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
            buttonBack = new Button();
            labelTitle = new Label();
            label1 = new Label();
            buttonBackPurchase = new Button();
            labelBookId = new Label();
            textBoxBookId = new TextBox();
            label3 = new Label();
            textBoxBookName = new TextBox();
            labelBookName = new Label();
            buttonApplication = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(264, -190);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(10, 10);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 16F);
            labelTitle.Location = new Point(-145, -197);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(302, 59);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Book Manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 59);
            label1.TabIndex = 8;
            label1.Text = "Book Manager";
            // 
            // buttonBackPurchase
            // 
            buttonBackPurchase.Location = new Point(352, 16);
            buttonBackPurchase.Name = "buttonBackPurchase";
            buttonBackPurchase.Size = new Size(302, 60);
            buttonBackPurchase.TabIndex = 9;
            buttonBackPurchase.Text = "back";
            buttonBackPurchase.UseVisualStyleBackColor = true;
            // 
            // labelBookId
            // 
            labelBookId.AutoSize = true;
            labelBookId.Location = new Point(12, 94);
            labelBookId.Name = "labelBookId";
            labelBookId.Size = new Size(95, 32);
            labelBookId.TabIndex = 10;
            labelBookId.Text = "book id";
            // 
            // textBoxBookId
            // 
            textBoxBookId.Location = new Point(12, 129);
            textBoxBookId.Name = "textBoxBookId";
            textBoxBookId.Size = new Size(211, 39);
            textBoxBookId.TabIndex = 11;
            textBoxBookId.Text = "3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 94);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 12;
            label3.Text = "yyyymmddnnn";
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(12, 221);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(642, 39);
            textBoxBookName.TabIndex = 14;
            textBoxBookName.Text = "c";
            // 
            // labelBookName
            // 
            labelBookName.AutoSize = true;
            labelBookName.Location = new Point(12, 186);
            labelBookName.Name = "labelBookName";
            labelBookName.Size = new Size(135, 32);
            labelBookName.TabIndex = 13;
            labelBookName.Text = "book name";
            // 
            // buttonApplication
            // 
            buttonApplication.Location = new Point(12, 275);
            buttonApplication.Name = "buttonApplication";
            buttonApplication.Size = new Size(211, 48);
            buttonApplication.TabIndex = 15;
            buttonApplication.Text = "application";
            buttonApplication.UseVisualStyleBackColor = true;
            // 
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 363);
            Controls.Add(buttonApplication);
            Controls.Add(textBoxBookName);
            Controls.Add(labelBookName);
            Controls.Add(label3);
            Controls.Add(textBoxBookId);
            Controls.Add(labelBookId);
            Controls.Add(buttonBackPurchase);
            Controls.Add(label1);
            Controls.Add(buttonBack);
            Controls.Add(labelTitle);
            Name = "Purchase";
            Text = "Purchase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonBack;
        private Label labelTitle;
        private Label label1;
        private Button buttonBackPurchase;
        private Label labelBookId;
        private TextBox textBoxBookId;
        private Label label3;
        private TextBox textBoxBookName;
        private Label labelBookName;
        private Button buttonApplication;
    }
}