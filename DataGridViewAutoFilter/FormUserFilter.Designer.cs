namespace DataGridViewAutoFilter
{
    partial class FormUserFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelect1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSelect2 = new System.Windows.Forms.ComboBox();
            this.comboBoxFilter1 = new System.Windows.Forms.ComboBox();
            this.comboBoxFilter2 = new System.Windows.Forms.ComboBox();
            this.radioButtonAnd = new System.Windows.Forms.RadioButton();
            this.radioButtonOr = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specifying user conditions";
            // 
            // comboBoxSelect1
            // 
            this.comboBoxSelect1.FormattingEnabled = true;
            this.comboBoxSelect1.Location = new System.Drawing.Point(27, 52);
            this.comboBoxSelect1.Name = "comboBoxSelect1";
            this.comboBoxSelect1.Size = new System.Drawing.Size(559, 32);
            this.comboBoxSelect1.TabIndex = 1;
            // 
            // comboBoxSelect2
            // 
            this.comboBoxSelect2.FormattingEnabled = true;
            this.comboBoxSelect2.Location = new System.Drawing.Point(27, 157);
            this.comboBoxSelect2.Name = "comboBoxSelect2";
            this.comboBoxSelect2.Size = new System.Drawing.Size(559, 32);
            this.comboBoxSelect2.TabIndex = 2;
            // 
            // comboBoxFilter1
            // 
            this.comboBoxFilter1.FormattingEnabled = true;
            this.comboBoxFilter1.Location = new System.Drawing.Point(602, 52);
            this.comboBoxFilter1.Name = "comboBoxFilter1";
            this.comboBoxFilter1.Size = new System.Drawing.Size(181, 32);
            this.comboBoxFilter1.TabIndex = 3;
            // 
            // comboBoxFilter2
            // 
            this.comboBoxFilter2.FormattingEnabled = true;
            this.comboBoxFilter2.Location = new System.Drawing.Point(602, 157);
            this.comboBoxFilter2.Name = "comboBoxFilter2";
            this.comboBoxFilter2.Size = new System.Drawing.Size(181, 32);
            this.comboBoxFilter2.TabIndex = 4;
            // 
            // radioButtonAnd
            // 
            this.radioButtonAnd.AutoSize = true;
            this.radioButtonAnd.Location = new System.Drawing.Point(27, 106);
            this.radioButtonAnd.Name = "radioButtonAnd";
            this.radioButtonAnd.Size = new System.Drawing.Size(87, 31);
            this.radioButtonAnd.TabIndex = 5;
            this.radioButtonAnd.TabStop = true;
            this.radioButtonAnd.Text = "AND";
            this.radioButtonAnd.UseCompatibleTextRendering = true;
            this.radioButtonAnd.UseVisualStyleBackColor = true;
            // 
            // radioButtonOr
            // 
            this.radioButtonOr.AutoSize = true;
            this.radioButtonOr.Location = new System.Drawing.Point(179, 106);
            this.radioButtonOr.Name = "radioButtonOr";
            this.radioButtonOr.Size = new System.Drawing.Size(72, 31);
            this.radioButtonOr.TabIndex = 6;
            this.radioButtonOr.TabStop = true;
            this.radioButtonOr.Text = "OR";
            this.radioButtonOr.UseCompatibleTextRendering = true;
            this.radioButtonOr.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(405, 220);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(181, 42);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(602, 220);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(181, 42);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormUserFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 304);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.radioButtonOr);
            this.Controls.Add(this.radioButtonAnd);
            this.Controls.Add(this.comboBoxFilter2);
            this.Controls.Add(this.comboBoxFilter1);
            this.Controls.Add(this.comboBoxSelect2);
            this.Controls.Add(this.comboBoxSelect1);
            this.Controls.Add(this.label1);
            this.Name = "FormUserFilter";
            this.Text = "FormUserFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelect1;
        private System.Windows.Forms.ComboBox comboBoxSelect2;
        private System.Windows.Forms.ComboBox comboBoxFilter1;
        private System.Windows.Forms.ComboBox comboBoxFilter2;
        private System.Windows.Forms.RadioButton radioButtonAnd;
        private System.Windows.Forms.RadioButton radioButtonOr;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}