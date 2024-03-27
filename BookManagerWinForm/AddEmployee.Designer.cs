namespace BookManagerWinForm
{
    partial class AddEmployee
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
            textBoxEmployeeNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxEmployeePassword = new TextBox();
            label4 = new Label();
            textBoxFirstName = new TextBox();
            checkBoxEditor = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 59);
            label1.TabIndex = 10;
            label1.Text = "Book Manager";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(486, 16);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(302, 60);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(26, 321);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(294, 51);
            buttonAddEmployee.TabIndex = 12;
            buttonAddEmployee.Text = "addEmployee";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // textBoxEmployeeNumber
            // 
            textBoxEmployeeNumber.Location = new Point(26, 140);
            textBoxEmployeeNumber.Name = "textBoxEmployeeNumber";
            textBoxEmployeeNumber.Size = new Size(245, 39);
            textBoxEmployeeNumber.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 105);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 14;
            label2.Text = "employee number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 105);
            label3.Name = "label3";
            label3.Size = new Size(226, 32);
            label3.TabIndex = 15;
            label3.Text = "employee password";
            // 
            // textBoxEmployeePassword
            // 
            textBoxEmployeePassword.Location = new Point(303, 140);
            textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            textBoxEmployeePassword.Size = new Size(245, 39);
            textBoxEmployeePassword.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 207);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 17;
            label4.Text = "first name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(26, 242);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(245, 39);
            textBoxFirstName.TabIndex = 18;
            // 
            // checkBoxEditor
            // 
            checkBoxEditor.AutoSize = true;
            checkBoxEditor.Location = new Point(328, 244);
            checkBoxEditor.Name = "checkBoxEditor";
            checkBoxEditor.Size = new Size(108, 36);
            checkBoxEditor.TabIndex = 20;
            checkBoxEditor.Text = "Editor";
            checkBoxEditor.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 401);
            Controls.Add(checkBoxEditor);
            Controls.Add(textBoxFirstName);
            Controls.Add(label4);
            Controls.Add(textBoxEmployeePassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxEmployeeNumber);
            Controls.Add(buttonAddEmployee);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "AddEmployee";
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private Button buttonAddEmployee;
        private TextBox textBoxEmployeeNumber;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmployeePassword;
        private Label label4;
        private TextBox textBoxFirstName;
        private CheckBox checkBoxEditor;
    }
}