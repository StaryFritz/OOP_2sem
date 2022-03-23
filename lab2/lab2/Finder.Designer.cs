
namespace lab2
{
    partial class Finder
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
            this.findingString = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.findingResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // findingString
            // 
            this.findingString.Location = new System.Drawing.Point(143, 107);
            this.findingString.Name = "findingString";
            this.findingString.Size = new System.Drawing.Size(319, 27);
            this.findingString.TabIndex = 0;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(505, 105);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(135, 29);
            this.find.TabIndex = 1;
            this.find.Text = "Начать поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // findingResult
            // 
            this.findingResult.FormattingEnabled = true;
            this.findingResult.ItemHeight = 20;
            this.findingResult.Location = new System.Drawing.Point(143, 173);
            this.findingResult.Name = "findingResult";
            this.findingResult.Size = new System.Drawing.Size(497, 164);
            this.findingResult.TabIndex = 2;
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findingResult);
            this.Controls.Add(this.find);
            this.Controls.Add(this.findingString);
            this.Name = "Finder";
            this.Text = "Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findingString;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.ListBox findingResult;
    }
}