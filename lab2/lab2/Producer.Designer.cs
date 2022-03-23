
namespace lab2
{
    partial class Producer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Organisation = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Adress = new System.Windows.Forms.RichTextBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Организация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Телефон";
            // 
            // Organisation
            // 
            this.Organisation.Location = new System.Drawing.Point(60, 78);
            this.Organisation.Name = "Organisation";
            this.Organisation.Size = new System.Drawing.Size(125, 27);
            this.Organisation.TabIndex = 4;
            this.Organisation.Validating += new System.ComponentModel.CancelEventHandler(this.Organisation_Validating);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(60, 325);
            this.PhoneNumber.Mask = "(999) 000-0000";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(125, 27);
            this.PhoneNumber.TabIndex = 7;
            this.PhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneNumber_Validating);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(60, 378);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(94, 29);
            this.Send.TabIndex = 8;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(60, 225);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(153, 53);
            this.Adress.TabIndex = 9;
            this.Adress.Text = "";
            this.Adress.Validating += new System.ComponentModel.CancelEventHandler(this.Adress_Validating);
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(60, 152);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(151, 28);
            this.Country.TabIndex = 10;
            this.Country.Validating += new System.ComponentModel.CancelEventHandler(this.Country_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Producer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Organisation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Producer";
            this.Text = "Producer";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Organisation;
        private System.Windows.Forms.MaskedTextBox PhoneNumber;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.RichTextBox Adress;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}