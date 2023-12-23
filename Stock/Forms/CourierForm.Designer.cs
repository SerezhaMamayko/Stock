namespace Stock.Forms
{
    partial class CourierForm
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
            this.Check = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(169, 108);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(150, 50);
            this.Check.TabIndex = 0;
            this.Check.Text = "Просмотреть";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(169, 275);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(150, 50);
            this.Create.TabIndex = 1;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button2_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(404, 275);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(150, 50);
            this.Change.TabIndex = 2;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер заказа";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(169, 46);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(385, 22);
            this.Id.TabIndex = 4;
            this.Id.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Статус заказа\r\nна складе\r\n";
            // 
            // Status
            // 
            this.Status.AllowDrop = true;
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.Items.AddRange(new object[] {
            "Dekiver",
            "Have some problems",
            "Get order"});
            this.Status.Location = new System.Drawing.Point(169, 226);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(385, 24);
            this.Status.TabIndex = 7;
            // 
            // CourierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(767, 349);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Check);
            this.Name = "CourierForm";
            this.Text = "CourierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Status;
    }
}