namespace BookManagerWinForm
{
    partial class MainMenu
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
            labelTitle = new Label();
            buttonLogOut = new Button();
            buttonList = new Button();
            buttonPurchase = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 16F);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(302, 59);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Book Manager";
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(48, 372);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(232, 52);
            buttonLogOut.TabIndex = 2;
            buttonLogOut.Text = "log out";
            buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonList
            // 
            buttonList.Location = new Point(48, 113);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(232, 62);
            buttonList.TabIndex = 3;
            buttonList.Text = "list";
            buttonList.UseVisualStyleBackColor = true;
            // 
            // buttonPurchase
            // 
            buttonPurchase.Location = new Point(48, 197);
            buttonPurchase.Name = "buttonPurchase";
            buttonPurchase.Size = new Size(232, 62);
            buttonPurchase.TabIndex = 4;
            buttonPurchase.Text = "purchase";
            buttonPurchase.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(48, 282);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(232, 62);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonPurchase);
            Controls.Add(buttonList);
            Controls.Add(buttonLogOut);
            Controls.Add(labelTitle);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonLogOut;
        private Button buttonList;
        private Button buttonPurchase;
        private Button buttonEdit;
    }
}