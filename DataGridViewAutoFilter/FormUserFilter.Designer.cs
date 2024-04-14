namespace DataGridViewAutoFilter
{
    partial class formUserFilter
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbSelect1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelect2 = new System.Windows.Forms.ComboBox();
            this.cmbFilter1 = new System.Windows.Forms.ComboBox();
            this.cmbFilter2 = new System.Windows.Forms.ComboBox();
            this.radAnd = new System.Windows.Forms.RadioButton();
            this.radOr = new System.Windows.Forms.RadioButton();
            this.formUserFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formUserFilterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(319, 228);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(178, 36);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(537, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbSelect1
            // 
            this.cmbSelect1.FormattingEnabled = true;
            this.cmbSelect1.Location = new System.Drawing.Point(12, 48);
            this.cmbSelect1.Name = "cmbSelect1";
            this.cmbSelect1.Size = new System.Drawing.Size(500, 32);
            this.cmbSelect1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "抽出条件の指定：";
            // 
            // cmbSelect2
            // 
            this.cmbSelect2.FormattingEnabled = true;
            this.cmbSelect2.Location = new System.Drawing.Point(16, 157);
            this.cmbSelect2.Name = "cmbSelect2";
            this.cmbSelect2.Size = new System.Drawing.Size(500, 32);
            this.cmbSelect2.TabIndex = 4;
            // 
            // cmbFilter1
            // 
            this.cmbFilter1.FormattingEnabled = true;
            this.cmbFilter1.Location = new System.Drawing.Point(571, 48);
            this.cmbFilter1.Name = "cmbFilter1";
            this.cmbFilter1.Size = new System.Drawing.Size(144, 32);
            this.cmbFilter1.TabIndex = 5;
            // 
            // cmbFilter2
            // 
            this.cmbFilter2.FormattingEnabled = true;
            this.cmbFilter2.Location = new System.Drawing.Point(571, 157);
            this.cmbFilter2.Name = "cmbFilter2";
            this.cmbFilter2.Size = new System.Drawing.Size(144, 32);
            this.cmbFilter2.TabIndex = 6;
            // 
            // radAnd
            // 
            this.radAnd.AutoSize = true;
            this.radAnd.Location = new System.Drawing.Point(44, 102);
            this.radAnd.Name = "radAnd";
            this.radAnd.Size = new System.Drawing.Size(87, 28);
            this.radAnd.TabIndex = 7;
            this.radAnd.Text = "AND";
            this.radAnd.UseVisualStyleBackColor = true;
            // 
            // radOr
            // 
            this.radOr.AutoSize = true;
            this.radOr.Location = new System.Drawing.Point(200, 102);
            this.radOr.Name = "radOr";
            this.radOr.Size = new System.Drawing.Size(73, 28);
            this.radOr.TabIndex = 8;
            this.radOr.Text = "OR";
            this.radOr.UseVisualStyleBackColor = true;
            // 
            // formUserFilterBindingSource
            // 
            this.formUserFilterBindingSource.DataSource = typeof(DataGridViewAutoFilter.formUserFilter);
            // 
            // searchInfoBindingSource
            // 
            this.searchInfoBindingSource.DataSource = typeof(DataGridViewAutoFilter.SearchInfo);
            // 
            // formUserFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 298);
            this.Controls.Add(this.radOr);
            this.Controls.Add(this.radAnd);
            this.Controls.Add(this.cmbFilter2);
            this.Controls.Add(this.cmbFilter1);
            this.Controls.Add(this.cmbSelect2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelect1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "formUserFilter";
            this.Text = "ユーザー設定フィルタ";
            this.Load += new System.EventHandler(this.formUserFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formUserFilterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbSelect1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelect2;
        private System.Windows.Forms.ComboBox cmbFilter1;
        private System.Windows.Forms.ComboBox cmbFilter2;
        private System.Windows.Forms.RadioButton radAnd;
        private System.Windows.Forms.RadioButton radOr;
        private System.Windows.Forms.BindingSource searchInfoBindingSource;
        private System.Windows.Forms.BindingSource formUserFilterBindingSource;
    }
}