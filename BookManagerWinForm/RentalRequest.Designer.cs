namespace BookManagerWinForm
{
    partial class RentalRequest
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
            buttonApplication = new Button();
            dataGridView1 = new DataGridView();
            buttonBackList = new Button();
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
            // buttonApplication
            // 
            buttonApplication.Location = new Point(12, 312);
            buttonApplication.Name = "buttonApplication";
            buttonApplication.Size = new Size(211, 48);
            buttonApplication.TabIndex = 16;
            buttonApplication.Text = "application";
            buttonApplication.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1194, 93);
            dataGridView1.TabIndex = 17;
            // 
            // buttonBackList
            // 
            buttonBackList.Location = new Point(341, 16);
            buttonBackList.Name = "buttonBackList";
            buttonBackList.Size = new Size(302, 60);
            buttonBackList.TabIndex = 18;
            buttonBackList.Text = "back";
            buttonBackList.UseVisualStyleBackColor = true;
            // 
            // RentalRequest
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 450);
            Controls.Add(buttonBackList);
            Controls.Add(dataGridView1);
            Controls.Add(buttonApplication);
            Controls.Add(labelTitle);
            Name = "RentalRequest";
            Text = "RentalRequest";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonApplication;
        private DataGridView dataGridView1;
        private Button buttonBackList;
    }
}