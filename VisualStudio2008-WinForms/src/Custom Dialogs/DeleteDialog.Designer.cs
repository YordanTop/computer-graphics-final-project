namespace Draw.src.Custom_Dialogs
{
    partial class DeleteDialog
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
            this.labelSelect = new System.Windows.Forms.Label();
            this.SelectCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect.Location = new System.Drawing.Point(54, 49);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(273, 25);
            this.labelSelect.TabIndex = 1;
            this.labelSelect.Text = "Изберете група от менюто.";
            // 
            // SelectCombo
            // 
            this.SelectCombo.FormattingEnabled = true;
            this.SelectCombo.Location = new System.Drawing.Point(59, 93);
            this.SelectCombo.Name = "SelectCombo";
            this.SelectCombo.Size = new System.Drawing.Size(268, 24);
            this.SelectCombo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Изтриване на група";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectCombo);
            this.Controls.Add(this.labelSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.ComboBox SelectCombo;
        private System.Windows.Forms.Button button1;
    }
}