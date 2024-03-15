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
            buttonRentalRequest = new Button();
            dataGridView1 = new DataGridView();
            buttonBackList = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
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
            // buttonRentalRequest
            // 
            buttonRentalRequest.Location = new Point(12, 312);
            buttonRentalRequest.Name = "buttonRentalRequest";
            buttonRentalRequest.Size = new Size(211, 48);
            buttonRentalRequest.TabIndex = 16;
            buttonRentalRequest.Text = "request";
            buttonRentalRequest.UseVisualStyleBackColor = true;
            buttonRentalRequest.Click += ButtonRentalRequest_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(650, 93);
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
            buttonBackList.Click += ButtonBackList_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker1.Location = new Point(695, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 50);
            dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker2.Location = new Point(987, 201);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(266, 50);
            dateTimePicker2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(695, 158);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 22;
            label1.Text = "rental date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(987, 158);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 23;
            label2.Text = "return date";
            // 
            // RentalRequest
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonBackList);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRentalRequest);
            Controls.Add(labelTitle);
            Name = "RentalRequest";
            Text = "RentalRequest";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonRentalRequest;
        private DataGridView dataGridView1;
        private Button buttonBackList;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
    }
}