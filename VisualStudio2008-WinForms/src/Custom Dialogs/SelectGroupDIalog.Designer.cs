namespace Draw.src.Custom_Dialogs
{
    partial class SelectGroupDIalog
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
            this.selectButton = new System.Windows.Forms.Button();
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
            this.labelSelect.Text = "Изберете група от менюто,";
            // 
            // SelectCombo
            // 
            this.SelectCombo.FormattingEnabled = true;
            this.SelectCombo.Location = new System.Drawing.Point(59, 93);
            this.SelectCombo.Name = "SelectCombo";
            this.SelectCombo.Size = new System.Drawing.Size(268, 24);
            this.SelectCombo.TabIndex = 3;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(105, 141);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(169, 27);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Избиране на група";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // SelectGroupDIalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 193);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.SelectCombo);
            this.Controls.Add(this.labelSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectGroupDIalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectGroupDIalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.ComboBox SelectCombo;
        private System.Windows.Forms.Button selectButton;
    }
}