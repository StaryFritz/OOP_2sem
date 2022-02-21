
namespace lab2
{
    partial class Product
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductNum = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductDate = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProcuctCount = new System.Windows.Forms.TextBox();
            this.ProductCost = new System.Windows.Forms.TextBox();
            this.AddProducer = new System.Windows.Forms.Button();
            this.ProducerInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(53, 74);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(125, 27);
            this.ProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Инвентарный номер";
            // 
            // ProductNum
            // 
            this.ProductNum.Location = new System.Drawing.Point(53, 136);
            this.ProductNum.Name = "ProductNum";
            this.ProductNum.Size = new System.Drawing.Size(125, 27);
            this.ProductNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Размер";
            // 
            // ProductSize
            // 
            this.ProductSize.Location = new System.Drawing.Point(53, 202);
            this.ProductSize.Name = "ProductSize";
            this.ProductSize.Size = new System.Drawing.Size(125, 27);
            this.ProductSize.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вес";
            // 
            // ProductWeight
            // 
            this.ProductWeight.Location = new System.Drawing.Point(53, 270);
            this.ProductWeight.Name = "ProductWeight";
            this.ProductWeight.Size = new System.Drawing.Size(125, 27);
            this.ProductWeight.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип";
            // 
            // ProductType
            // 
            this.ProductType.Location = new System.Drawing.Point(53, 337);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(125, 27);
            this.ProductType.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата поступления";
            // 
            // ProductDate
            // 
            this.ProductDate.Location = new System.Drawing.Point(53, 408);
            this.ProductDate.Name = "ProductDate";
            this.ProductDate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 701);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Цена";
            // 
            // ProcuctCount
            // 
            this.ProcuctCount.Location = new System.Drawing.Point(53, 656);
            this.ProcuctCount.Name = "ProcuctCount";
            this.ProcuctCount.Size = new System.Drawing.Size(125, 27);
            this.ProcuctCount.TabIndex = 14;
            // 
            // ProductCost
            // 
            this.ProductCost.Location = new System.Drawing.Point(53, 724);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(125, 27);
            this.ProductCost.TabIndex = 15;
            // 
            // AddProducer
            // 
            this.AddProducer.Location = new System.Drawing.Point(53, 777);
            this.AddProducer.Name = "AddProducer";
            this.AddProducer.Size = new System.Drawing.Size(138, 29);
            this.AddProducer.TabIndex = 16;
            this.AddProducer.Text = "Производитель";
            this.AddProducer.UseVisualStyleBackColor = true;
            this.AddProducer.Click += new System.EventHandler(this.AddProducer_Click);
            // 
            // ProducerInfo
            // 
            this.ProducerInfo.AutoSize = true;
            this.ProducerInfo.Location = new System.Drawing.Point(53, 825);
            this.ProducerInfo.Name = "ProducerInfo";
            this.ProducerInfo.Size = new System.Drawing.Size(94, 20);
            this.ProducerInfo.TabIndex = 17;
            this.ProducerInfo.Text = "ProducerInfo";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 982);
            this.Controls.Add(this.ProducerInfo);
            this.Controls.Add(this.AddProducer);
            this.Controls.Add(this.ProductCost);
            this.Controls.Add(this.ProcuctCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.Text = "Товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ProductNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar ProductDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProcuctCount;
        private System.Windows.Forms.TextBox ProductCost;
        private System.Windows.Forms.Button AddProducer;
        public System.Windows.Forms.Label ProducerInfo;
    }
}

