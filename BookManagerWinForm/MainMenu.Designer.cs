

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
            buttonListDisplay = new Button();
            buttonPurchaseRequest = new Button();
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
            buttonLogOut.Click += ButtonLogOut_Click;
            // 
            // buttonListDisplay
            // 
            buttonListDisplay.Location = new Point(48, 113);
            buttonListDisplay.Name = "buttonListDisplay";
            buttonListDisplay.Size = new Size(232, 62);
            buttonListDisplay.TabIndex = 3;
            buttonListDisplay.Text = "list display";
            buttonListDisplay.UseVisualStyleBackColor = true;
            buttonListDisplay.Click += ButtonListDisplay_Click;
            // 
            // buttonPurchaseRequest
            // 
            buttonPurchaseRequest.Location = new Point(48, 197);
            buttonPurchaseRequest.Name = "buttonPurchaseRequest";
            buttonPurchaseRequest.Size = new Size(232, 62);
            buttonPurchaseRequest.TabIndex = 4;
            buttonPurchaseRequest.Text = "purchase request";
            buttonPurchaseRequest.UseVisualStyleBackColor = true;
            buttonPurchaseRequest.Click += buttonPurchaseRequest_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(48, 282);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(232, 62);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonPurchaseRequest);
            Controls.Add(buttonListDisplay);
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
        private Button buttonListDisplay;
        private Button buttonPurchaseRequest;
        private Button buttonEdit;
    }
}