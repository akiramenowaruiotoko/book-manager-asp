namespace BookManagerWinForm
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            buttonLogIn = new Button();
            textBoxEmpNum = new TextBox();
            textBoxEmpPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 16F);
            labelTitle.Location = new Point(138, 43);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(302, 59);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Book Manager";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(138, 333);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(302, 60);
            buttonLogIn.TabIndex = 1;
            buttonLogIn.Text = "log in";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += ButtonLogIn_Click;
            // 
            // textBoxEmpNum
            // 
            textBoxEmpNum.Location = new Point(138, 161);
            textBoxEmpNum.Name = "textBoxEmpNum";
            textBoxEmpNum.Size = new Size(302, 39);
            textBoxEmpNum.TabIndex = 2;
            // 
            // textBoxEmpPass
            // 
            textBoxEmpPass.Location = new Point(138, 269);
            textBoxEmpPass.Name = "textBoxEmpPass";
            textBoxEmpPass.Size = new Size(302, 39);
            textBoxEmpPass.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 126);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 4;
            label1.Text = "employee number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 234);
            label2.Name = "label2";
            label2.Size = new Size(226, 32);
            label2.TabIndex = 5;
            label2.Text = "employee password";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 429);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmpPass);
            Controls.Add(textBoxEmpNum);
            Controls.Add(buttonLogIn);
            Controls.Add(labelTitle);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonLogIn;
        private TextBox textBoxEmpNum;
        private TextBox textBoxEmpPass;
        private Label label1;
        private Label label2;
    }
}
