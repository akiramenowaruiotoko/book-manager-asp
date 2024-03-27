namespace BookManagerWinForm
{
    partial class RentalManagement
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
            buttonUnavailableRental = new Button();
            buttonRentalApproval = new Button();
            buttonReturned = new Button();
            buttonCurrentlyRental = new Button();
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
            // buttonUnavailableRental
            // 
            buttonUnavailableRental.Location = new Point(467, 222);
            buttonUnavailableRental.Name = "buttonUnavailableRental";
            buttonUnavailableRental.Size = new Size(359, 48);
            buttonUnavailableRental.TabIndex = 19;
            buttonUnavailableRental.Text = "Unavailable　Rental";
            buttonUnavailableRental.UseVisualStyleBackColor = true;
            buttonUnavailableRental.Click += buttonUnavailableRental_Click;
            // 
            // buttonRentalApproval
            // 
            buttonRentalApproval.Location = new Point(64, 222);
            buttonRentalApproval.Name = "buttonRentalApproval";
            buttonRentalApproval.Size = new Size(359, 48);
            buttonRentalApproval.TabIndex = 20;
            buttonRentalApproval.Text = "Rental Approval";
            buttonRentalApproval.UseVisualStyleBackColor = true;
            buttonRentalApproval.Click += ButtonRentalApproval_Click;
            // 
            // buttonReturned
            // 
            buttonReturned.Location = new Point(1297, 222);
            buttonReturned.Name = "buttonReturned";
            buttonReturned.Size = new Size(359, 48);
            buttonReturned.TabIndex = 21;
            buttonReturned.Text = "Returned or Available Rental";
            buttonReturned.UseVisualStyleBackColor = true;
            buttonReturned.Click += buttonReturned_Click;
            // 
            // buttonCurrentlyRental
            // 
            buttonCurrentlyRental.Location = new Point(860, 222);
            buttonCurrentlyRental.Name = "buttonCurrentlyRental";
            buttonCurrentlyRental.Size = new Size(359, 48);
            buttonCurrentlyRental.TabIndex = 22;
            buttonCurrentlyRental.Text = "Currently Rental";
            buttonCurrentlyRental.UseVisualStyleBackColor = true;
            buttonCurrentlyRental.Click += buttonCurrentlyRental_Click;
            // 
            // RentalManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2165, 315);
            Controls.Add(buttonCurrentlyRental);
            Controls.Add(buttonReturned);
            Controls.Add(buttonRentalApproval);
            Controls.Add(buttonUnavailableRental);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBack);
            Controls.Add(labelTitle);
            Name = "RentalManagement";
            Text = "RentalManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonBackRentalComplete;
        private DataGridView dataGridView1;
        private Button buttonUnavailableRental;
        private Button buttonReturned;
        private Button buttonBack;
        private Button buttonRentalApproval;
        private Button buttonCurrentlyRental;
    }
}