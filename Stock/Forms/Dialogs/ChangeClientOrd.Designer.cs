namespace Stock.Forms.Dialogs
{
    partial class ChangeClientOrd
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
            this.Sum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
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
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(200, 196);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(374, 22);
            this.Sum.TabIndex = 3;
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
            this.label3.Location = new System.Drawing.Point(34, 143);
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
            // PayStatus
            // 
            this.PayStatus.FormattingEnabled = true;
            this.PayStatus.Items.AddRange(new object[] {
            "Оплачено",
            "Не оплачено"});
            this.PayStatus.Location = new System.Drawing.Point(200, 246);
            this.PayStatus.Name = "PayStatus";
            this.PayStatus.Size = new System.Drawing.Size(374, 24);
            this.PayStatus.TabIndex = 8;
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
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(424, 310);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 50);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(200, 310);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(150, 50);
            this.Create.TabIndex = 12;
            this.Create.Text = "Изменить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // ChangeClientOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PayStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.OrderName);
            this.Controls.Add(this.AllName);
            this.Controls.Add(this.PhoneNum);
            this.Name = "ChangeClientOrd";
            this.Text = "CreateClientOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.TextBox AllName;
        private System.Windows.Forms.TextBox OrderName;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PayStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Create;
    }
}