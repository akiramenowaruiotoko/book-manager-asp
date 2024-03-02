namespace BookManagerWinForm
{
    partial class PurchaseCheck
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
            buttonBackList = new Button();
            dataGridView1 = new DataGridView();
            buttonPurchaseApplication = new Button();
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
            // buttonBackList
            // 
            buttonBackList.Location = new Point(371, 16);
            buttonBackList.Name = "buttonBackList";
            buttonBackList.Size = new Size(302, 60);
            buttonBackList.TabIndex = 4;
            buttonBackList.Text = "back";
            buttonBackList.UseVisualStyleBackColor = true;
            buttonBackList.Click += buttonBackPurchaseCheck_Click;
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
            // buttonPurchaseApplication
            // 
            buttonPurchaseApplication.Location = new Point(64, 276);
            buttonPurchaseApplication.Name = "buttonPurchaseApplication";
            buttonPurchaseApplication.Size = new Size(211, 48);
            buttonPurchaseApplication.TabIndex = 19;
            buttonPurchaseApplication.Text = "application";
            buttonPurchaseApplication.UseVisualStyleBackColor = true;
            // 
            // PurchaseCheck
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2165, 450);
            Controls.Add(buttonPurchaseApplication);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBackList);
            Controls.Add(labelTitle);
            Name = "PurchaseCheck";
            Text = "PurchaseCheck";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonBackList;
        private DataGridView dataGridView1;
        private Button buttonPurchaseApplication;
    }
}