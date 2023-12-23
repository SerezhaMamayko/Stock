namespace Stock.Forms
{
    partial class StoreKeeperForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.StatusBuy = new System.Windows.Forms.ComboBox();
            this.StatusStock = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Статус упаковывающегося\r\nзаказа на складе\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статус товара \r\nпоступившего на склад\r\n";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(231, 43);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(398, 22);
            this.Id.TabIndex = 3;
            this.Id.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(231, 96);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(150, 50);
            this.Check.TabIndex = 6;
            this.Check.Text = "Просмотреть";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(231, 339);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(150, 50);
            this.Create.TabIndex = 7;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(479, 339);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(150, 50);
            this.Change.TabIndex = 8;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // StatusBuy
            // 
            this.StatusBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBuy.Items.AddRange(new object[] {
            "Get product",
            "Have some problems"});
            this.StatusBuy.Location = new System.Drawing.Point(231, 287);
            this.StatusBuy.Name = "StatusBuy";
            this.StatusBuy.Size = new System.Drawing.Size(398, 24);
            this.StatusBuy.TabIndex = 9;
            // 
            // StatusStock
            // 
            this.StatusStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusStock.Items.AddRange(new object[] {
            "Product was packing for delivering",
            "Have some problems"});
            this.StatusStock.Location = new System.Drawing.Point(231, 224);
            this.StatusStock.Name = "StatusStock";
            this.StatusStock.Size = new System.Drawing.Size(398, 24);
            this.StatusStock.TabIndex = 10;
            // 
            // StoreKeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusStock);
            this.Controls.Add(this.StatusBuy);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StoreKeeperForm";
            this.Text = "StoreKeeperForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.ComboBox StatusBuy;
        private System.Windows.Forms.ComboBox StatusStock;
    }
}