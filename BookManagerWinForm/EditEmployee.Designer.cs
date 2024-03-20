namespace BookManagerWinForm
{
    partial class EditEmployee
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
            buttonEditEmployee = new Button();
            textBoxEmployeeNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxEmployeePassword = new TextBox();
            label4 = new Label();
            textBoxFirstName = new TextBox();
            checkBoxEditor = new CheckBox();
            label5 = new Label();
            textBoxTargetEmployeeNumber = new TextBox();
            buttonTargetDisplay = new Button();
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
            // buttonEditEmployee
            // 
            buttonEditEmployee.Location = new Point(12, 499);
            buttonEditEmployee.Name = "buttonEditEmployee";
            buttonEditEmployee.Size = new Size(294, 51);
            buttonEditEmployee.TabIndex = 12;
            buttonEditEmployee.Text = "EditEmployee";
            buttonEditEmployee.UseVisualStyleBackColor = true;
            buttonEditEmployee.Click += buttonEdditEmployee_Click;
            // 
            // textBoxEmployeeNumber
            // 
            textBoxEmployeeNumber.Location = new Point(12, 318);
            textBoxEmployeeNumber.Name = "textBoxEmployeeNumber";
            textBoxEmployeeNumber.Size = new Size(245, 39);
            textBoxEmployeeNumber.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 283);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 14;
            label2.Text = "employee number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 283);
            label3.Name = "label3";
            label3.Size = new Size(226, 32);
            label3.TabIndex = 15;
            label3.Text = "employee password";
            // 
            // textBoxEmployeePassword
            // 
            textBoxEmployeePassword.Location = new Point(289, 318);
            textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            textBoxEmployeePassword.Size = new Size(245, 39);
            textBoxEmployeePassword.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 385);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 17;
            label4.Text = "first name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 420);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(245, 39);
            textBoxFirstName.TabIndex = 18;
            // 
            // checkBoxEditor
            // 
            checkBoxEditor.AutoSize = true;
            checkBoxEditor.Location = new Point(314, 422);
            checkBoxEditor.Name = "checkBoxEditor";
            checkBoxEditor.Size = new Size(108, 36);
            checkBoxEditor.TabIndex = 20;
            checkBoxEditor.Text = "Editor";
            checkBoxEditor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 118);
            label5.Name = "label5";
            label5.Size = new Size(281, 32);
            label5.TabIndex = 22;
            label5.Text = "target employee number";
            // 
            // textBoxTargetEmployeeNumber
            // 
            textBoxTargetEmployeeNumber.Location = new Point(12, 153);
            textBoxTargetEmployeeNumber.Name = "textBoxTargetEmployeeNumber";
            textBoxTargetEmployeeNumber.Size = new Size(245, 39);
            textBoxTargetEmployeeNumber.TabIndex = 21;
            // 
            // buttonTargetDisplay
            // 
            buttonTargetDisplay.Location = new Point(299, 141);
            buttonTargetDisplay.Name = "buttonTargetDisplay";
            buttonTargetDisplay.Size = new Size(294, 51);
            buttonTargetDisplay.TabIndex = 23;
            buttonTargetDisplay.Text = "Target Display";
            buttonTargetDisplay.UseVisualStyleBackColor = true;
            buttonTargetDisplay.Click += buttonTargetDisplay_Click;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(buttonTargetDisplay);
            Controls.Add(label5);
            Controls.Add(textBoxTargetEmployeeNumber);
            Controls.Add(checkBoxEditor);
            Controls.Add(textBoxFirstName);
            Controls.Add(label4);
            Controls.Add(textBoxEmployeePassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxEmployeeNumber);
            Controls.Add(buttonEditEmployee);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "EditEmployee";
            Text = "EditEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private Button buttonEditEmployee;
        private TextBox textBoxEmployeeNumber;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmployeePassword;
        private Label label4;
        private TextBox textBoxFirstName;
        private CheckBox checkBoxEditor;
        private Label label5;
        private TextBox textBoxTargetEmployeeNumber;
        private Button buttonTargetDisplay;
    }
}