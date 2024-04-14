namespace BookManagerWinForm
{
    partial class PurchaseManagement
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
            buttonBack = new Button();
            dataGridView1 = new DataGridView();
            buttonPurchaseDisapproved = new Button();
            buttonPurchaseApproval = new Button();
            buttonPurchaseComplete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 16F);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(302, 59);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Book Manager";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(371, 16);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(302, 60);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += ButtonBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(64, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1901, 93);
            dataGridView1.TabIndex = 18;
            // 
            // buttonPurchaseDisapproved
            // 
            buttonPurchaseDisapproved.Location = new Point(548, 222);
            buttonPurchaseDisapproved.Name = "buttonPurchaseDisapproved";
            buttonPurchaseDisapproved.Size = new Size(359, 48);
            buttonPurchaseDisapproved.TabIndex = 19;
            buttonPurchaseDisapproved.Text = "purchase Disapproved";
            buttonPurchaseDisapproved.UseVisualStyleBackColor = true;
            buttonPurchaseDisapproved.Click += ButtonPurchaseDisapproved_Click;
            // 
            // buttonPurchaseApproval
            // 
            buttonPurchaseApproval.Location = new Point(64, 222);
            buttonPurchaseApproval.Name = "buttonPurchaseApproval";
            buttonPurchaseApproval.Size = new Size(359, 48);
            buttonPurchaseApproval.TabIndex = 20;
            buttonPurchaseApproval.Text = "purchase Approval";
            buttonPurchaseApproval.UseVisualStyleBackColor = true;
            buttonPurchaseApproval.Click += ButtonPurchaseApproval_Click;
            // 
            // buttonPurchaseComplete
            // 
            buttonPurchaseComplete.Location = new Point(999, 222);
            buttonPurchaseComplete.Name = "buttonPurchaseComplete";
            buttonPurchaseComplete.Size = new Size(359, 48);
            buttonPurchaseComplete.TabIndex = 21;
            buttonPurchaseComplete.Text = "purchase Complete";
            buttonPurchaseComplete.UseVisualStyleBackColor = true;
            buttonPurchaseComplete.Click += ButtonPurchaseComplete_Click;
            // 
            // PurchaseManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2165, 312);
            Controls.Add(buttonPurchaseComplete);
            Controls.Add(buttonPurchaseApproval);
            Controls.Add(buttonPurchaseDisapproved);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBack);
            Controls.Add(labelTitle);
            Name = "PurchaseManagement";
            Text = "PurchaseResponse";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridView1;
        private Button buttonPurchaseDisapproved;
        private Button buttonPurchaseComplete;
        private Button buttonBack;
        private Button buttonPurchaseApproval;
    }
}