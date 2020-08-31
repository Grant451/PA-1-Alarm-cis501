namespace WindowsFormsApp1
{
    partial class InputTime
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
            this.DTPInput = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSet = new System.Windows.Forms.Button();
            this.BtnOn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // DTPInput
            // 
            this.DTPInput.Location = new System.Drawing.Point(58, 86);
            this.DTPInput.Name = "DTPInput";
            this.DTPInput.Size = new System.Drawing.Size(456, 38);
            this.DTPInput.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(58, 294);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(200, 106);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(392, 294);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(200, 106);
            this.BtnSet.TabIndex = 2;
            this.BtnSet.Text = "Set";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // BtnOn
            // 
            this.BtnOn.AutoSize = true;
            this.BtnOn.Checked = true;
            this.BtnOn.Location = new System.Drawing.Point(528, 86);
            this.BtnOn.Name = "BtnOn";
            this.BtnOn.Size = new System.Drawing.Size(90, 36);
            this.BtnOn.TabIndex = 3;
            this.BtnOn.TabStop = true;
            this.BtnOn.Text = "On";
            this.BtnOn.UseVisualStyleBackColor = true;
            // 
            // InputTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOn);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.DTPInput);
            this.Name = "InputTime";
            this.Text = "InputTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPInput;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.RadioButton BtnOn;
    }
}