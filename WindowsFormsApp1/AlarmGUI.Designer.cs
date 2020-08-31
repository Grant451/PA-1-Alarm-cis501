namespace WindowsFormsApp1
{
    partial class Alarm501
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.ListBox();
            this.BtnSnoose = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(53, 31);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(136, 87);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(262, 31);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(136, 87);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Display
            // 
            this.Display.FormattingEnabled = true;
            this.Display.ItemHeight = 31;
            this.Display.Location = new System.Drawing.Point(53, 167);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(345, 283);
            this.Display.TabIndex = 2;
            // 
            // BtnSnoose
            // 
            this.BtnSnoose.Location = new System.Drawing.Point(53, 522);
            this.BtnSnoose.Name = "BtnSnoose";
            this.BtnSnoose.Size = new System.Drawing.Size(136, 85);
            this.BtnSnoose.TabIndex = 3;
            this.BtnSnoose.Text = "Snooze";
            this.BtnSnoose.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(262, 522);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(136, 85);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 619);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.BtnSnoose);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEdit);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox Display;
        private System.Windows.Forms.Button BtnSnoose;
        private System.Windows.Forms.Button Stop;
    }
}

