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
            buttonBack = new Button();
            buttonAddEmployee = new Button();
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
            // buttonBack
            // 
            buttonBack.Location = new Point(350, 16);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(302, 60);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(82, 109);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(232, 62);
            buttonAddEmployee.TabIndex = 13;
            buttonAddEmployee.Text = "add employee";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
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
            ClientSize = new Size(697, 227);
            Controls.Add(buttonAddBook);
            Controls.Add(buttonAddEmployee);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private Button buttonAddEmployee;
        private Button buttonAddBook;
    }
}