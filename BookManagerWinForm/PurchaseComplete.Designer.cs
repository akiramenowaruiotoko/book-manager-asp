namespace BookManagerWinForm
{
    partial class PurchaseComplete
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
            buttonBackPurchaseComplete = new Button();
            dataGridView1 = new DataGridView();
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
            // buttonBackPurchaseComplete
            // 
            buttonBackPurchaseComplete.Location = new Point(371, 16);
            buttonBackPurchaseComplete.Name = "buttonBackPurchaseComplete";
            buttonBackPurchaseComplete.Size = new Size(302, 60);
            buttonBackPurchaseComplete.TabIndex = 4;
            buttonBackPurchaseComplete.Text = "back";
            buttonBackPurchaseComplete.UseVisualStyleBackColor = true;
            buttonBackPurchaseComplete.Click += ButtonBackPurchaseComplete_Click;
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
            // buttonPurchaseComplete
            // 
            buttonPurchaseComplete.Location = new Point(64, 276);
            buttonPurchaseComplete.Name = "buttonPurchaseComplete";
            buttonPurchaseComplete.Size = new Size(359, 48);
            buttonPurchaseComplete.TabIndex = 19;
            buttonPurchaseComplete.Text = "purchase complete";
            buttonPurchaseComplete.UseVisualStyleBackColor = true;
            buttonPurchaseComplete.Click += buttonPurchaseComplete_Click;
            // 
            // PurchaseComplete
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2165, 450);
            Controls.Add(buttonPurchaseComplete);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBackPurchaseComplete);
            Controls.Add(labelTitle);
            Name = "PurchaseComplete";
            Text = "PurchaseCheck";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonBackPurchaseComplete;
        private DataGridView dataGridView1;
        private Button buttonPurchaseComplete;
    }
}