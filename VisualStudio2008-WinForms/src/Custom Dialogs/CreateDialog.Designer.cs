namespace Draw.src.Custom_Dialogs
{
    partial class CreateDialog
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
            this.SelectText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect.Location = new System.Drawing.Point(24, 48);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(328, 25);
            this.labelSelect.TabIndex = 0;
            this.labelSelect.Text = "Напишете името на новата група.";
            // 
            // SelectText
            // 
            this.SelectText.Location = new System.Drawing.Point(29, 94);
            this.SelectText.Name = "SelectText";
            this.SelectText.Size = new System.Drawing.Size(323, 22);
            this.SelectText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Създаване на група";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectText);
            this.Controls.Add(this.labelSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.TextBox SelectText;
        private System.Windows.Forms.Button button1;
    }
}