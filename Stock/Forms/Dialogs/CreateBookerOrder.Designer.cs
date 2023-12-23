namespace Stock.Forms.Dialogs
{
    partial class CreateBookerOrder
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
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.AllName = new System.Windows.Forms.TextBox();
            this.OrderName = new System.Windows.Forms.TextBox();
            this.SumOfOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusOfPay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.NDS = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneNum
            // 
            this.PhoneNum.Location = new System.Drawing.Point(200, 46);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(374, 22);
            this.PhoneNum.TabIndex = 0;
            // 
            // AllName
            // 
            this.AllName.Location = new System.Drawing.Point(200, 96);
            this.AllName.Name = "AllName";
            this.AllName.Size = new System.Drawing.Size(374, 22);
            this.AllName.TabIndex = 1;
            // 
            // OrderName
            // 
            this.OrderName.Location = new System.Drawing.Point(200, 146);
            this.OrderName.Name = "OrderName";
            this.OrderName.Size = new System.Drawing.Size(374, 22);
            this.OrderName.TabIndex = 2;
            // 
            // SumOfOrder
            // 
            this.SumOfOrder.Location = new System.Drawing.Point(200, 196);
            this.SumOfOrder.Name = "SumOfOrder";
            this.SumOfOrder.Size = new System.Drawing.Size(374, 22);
            this.SumOfOrder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Мобильный телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Полное имя клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Содержание заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сумма заказа";
            // 
            // StatusOfPay
            // 
            this.StatusOfPay.FormattingEnabled = true;
            this.StatusOfPay.Items.AddRange(new object[] {
            "Оплачено",
            "Не оплачено"});
            this.StatusOfPay.Location = new System.Drawing.Point(200, 246);
            this.StatusOfPay.Name = "StatusOfPay";
            this.StatusOfPay.Size = new System.Drawing.Size(374, 24);
            this.StatusOfPay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Статус оплаты";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(200, 449);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 50);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(424, 449);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(150, 50);
            this.CancelBut.TabIndex = 11;
            this.CancelBut.Text = "Отмена";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // NDS
            // 
            this.NDS.Location = new System.Drawing.Point(200, 296);
            this.NDS.Name = "NDS";
            this.NDS.Size = new System.Drawing.Size(374, 22);
            this.NDS.TabIndex = 13;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(200, 346);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(374, 22);
            this.Total.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "НДС";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Итог";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(200, 396);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(374, 22);
            this.Id.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Номер заказа";
            // 
            // CreateBookerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(987, 525);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.NDS);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusOfPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumOfOrder);
            this.Controls.Add(this.OrderName);
            this.Controls.Add(this.AllName);
            this.Controls.Add(this.PhoneNum);
            this.Name = "CreateBookerOrder";
            this.Text = "CreateBookerOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.TextBox AllName;
        private System.Windows.Forms.TextBox OrderName;
        private System.Windows.Forms.TextBox SumOfOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StatusOfPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.TextBox NDS;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label8;
    }
}