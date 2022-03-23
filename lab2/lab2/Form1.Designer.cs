
namespace lab2
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
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
            this.ProductCount = new System.Windows.Forms.TextBox();
            this.ProductCost = new System.Windows.Forms.TextBox();
            this.AddProducer = new System.Windows.Forms.Button();
            this.Producer = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.ListBox();
            this.WriteJSON = new System.Windows.Forms.Button();
            this.ReadJSON = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТипуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диапазонуЦеныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сорхранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.ProductName.Validating += new System.ComponentModel.CancelEventHandler(this.Length_Validating);
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
            this.ProductSize.Validating += new System.ComponentModel.CancelEventHandler(this.Char_Validating);
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
            this.ProductWeight.Validating += new System.ComponentModel.CancelEventHandler(this.Char_Validating);
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
            this.ProductType.Validating += new System.ComponentModel.CancelEventHandler(this.Length_Validating);
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
            // ProductCount
            // 
            this.ProductCount.Location = new System.Drawing.Point(53, 656);
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Size = new System.Drawing.Size(125, 27);
            this.ProductCount.TabIndex = 14;
            this.ProductCount.Validating += new System.ComponentModel.CancelEventHandler(this.Char_Validating);
            // 
            // ProductCost
            // 
            this.ProductCost.Location = new System.Drawing.Point(53, 724);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(125, 27);
            this.ProductCost.TabIndex = 15;
            this.ProductCost.Validating += new System.ComponentModel.CancelEventHandler(this.Char_Validating);
            // 
            // AddProducer
            // 
            this.AddProducer.Location = new System.Drawing.Point(53, 777);
            this.AddProducer.Name = "AddProducer";
            this.AddProducer.Size = new System.Drawing.Size(214, 29);
            this.AddProducer.TabIndex = 16;
            this.AddProducer.Text = "Добавить производителя";
            this.AddProducer.UseVisualStyleBackColor = true;
            this.AddProducer.Click += new System.EventHandler(this.AddProducer_Click);
            // 
            // Producer
            // 
            this.Producer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Producer.Location = new System.Drawing.Point(53, 818);
            this.Producer.Name = "Producer";
            this.Producer.Size = new System.Drawing.Size(140, 25);
            this.Producer.TabIndex = 17;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(53, 864);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(214, 93);
            this.Add.TabIndex = 18;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.ItemHeight = 20;
            this.Products.Location = new System.Drawing.Point(355, 51);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(337, 424);
            this.Products.TabIndex = 19;
            // 
            // WriteJSON
            // 
            this.WriteJSON.Location = new System.Drawing.Point(355, 505);
            this.WriteJSON.Name = "WriteJSON";
            this.WriteJSON.Size = new System.Drawing.Size(174, 29);
            this.WriteJSON.TabIndex = 20;
            this.WriteJSON.Text = "Запись в JSON";
            this.WriteJSON.UseVisualStyleBackColor = true;
            this.WriteJSON.Click += new System.EventHandler(this.WriteJSON_Click);
            // 
            // ReadJSON
            // 
            this.ReadJSON.Location = new System.Drawing.Point(535, 505);
            this.ReadJSON.Name = "ReadJSON";
            this.ReadJSON.Size = new System.Drawing.Size(157, 29);
            this.ReadJSON.TabIndex = 21;
            this.ReadJSON.Text = "Прочесть JSON";
            this.ReadJSON.UseVisualStyleBackColor = true;
            this.ReadJSON.Click += new System.EventHandler(this.ReadJSON_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.сорхранитьToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюToolStripMenuItem,
            this.поТипуToolStripMenuItem,
            this.диапазонуЦеныToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.поискToolStripMenuItem.Text = "Поиск по";
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поНазваниюToolStripMenuItem.Text = "названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // поТипуToolStripMenuItem
            // 
            this.поТипуToolStripMenuItem.Name = "поТипуToolStripMenuItem";
            this.поТипуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поТипуToolStripMenuItem.Text = "типу";
            this.поТипуToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // диапазонуЦеныToolStripMenuItem
            // 
            this.диапазонуЦеныToolStripMenuItem.Name = "диапазонуЦеныToolStripMenuItem";
            this.диапазонуЦеныToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.диапазонуЦеныToolStripMenuItem.Text = "диапазону цены";
            this.диапазонуЦеныToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.годуToolStripMenuItem,
            this.фамилииToolStripMenuItem,
            this.специальностиToolStripMenuItem});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            // 
            // годуToolStripMenuItem
            // 
            this.годуToolStripMenuItem.Name = "годуToolStripMenuItem";
            this.годуToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.годуToolStripMenuItem.Text = "году";
            // 
            // фамилииToolStripMenuItem
            // 
            this.фамилииToolStripMenuItem.Name = "фамилииToolStripMenuItem";
            this.фамилииToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.фамилииToolStripMenuItem.Text = "фамилии";
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.специальностиToolStripMenuItem.Text = "специальности";
            // 
            // сорхранитьToolStripMenuItem
            // 
            this.сорхранитьToolStripMenuItem.Name = "сорхранитьToolStripMenuItem";
            this.сорхранитьToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.сорхранитьToolStripMenuItem.Text = "Сорхранить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 24);
            this.toolStripMenuItem1.Text = "О программе";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 982);
            this.Controls.Add(this.ReadJSON);
            this.Controls.Add(this.WriteJSON);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Producer);
            this.Controls.Add(this.AddProducer);
            this.Controls.Add(this.ProductCost);
            this.Controls.Add(this.ProductCount);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductForm";
            this.Text = "Товар";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox ProductCount;
        private System.Windows.Forms.TextBox ProductCost;
        private System.Windows.Forms.Button AddProducer;
        public System.Windows.Forms.Label Producer;
        private System.Windows.Forms.Button Add;
        public System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.Button WriteJSON;
        private System.Windows.Forms.Button ReadJSON;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сорхранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТипуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диапазонуЦеныToolStripMenuItem;
    }
}

