namespace Stock.Forms
{
    partial class ClientForm
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
            this.buttonCreateOrd = new System.Windows.Forms.Button();
            this.buttonChangeOrd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreateOrd
            // 
            this.buttonCreateOrd.Location = new System.Drawing.Point(200, 170);
            this.buttonCreateOrd.Name = "buttonCreateOrd";
            this.buttonCreateOrd.Size = new System.Drawing.Size(150, 50);
            this.buttonCreateOrd.TabIndex = 0;
            this.buttonCreateOrd.Text = "Создать отчет";
            this.buttonCreateOrd.UseVisualStyleBackColor = true;
            this.buttonCreateOrd.Click += new System.EventHandler(this.buttonCreateOrd_Click);
            // 
            // buttonChangeOrd
            // 
            this.buttonChangeOrd.Location = new System.Drawing.Point(500, 170);
            this.buttonChangeOrd.Name = "buttonChangeOrd";
            this.buttonChangeOrd.Size = new System.Drawing.Size(150, 50);
            this.buttonChangeOrd.TabIndex = 1;
            this.buttonChangeOrd.Text = "Изменить отчет";
            this.buttonChangeOrd.UseVisualStyleBackColor = true;
            this.buttonChangeOrd.Click += new System.EventHandler(this.buttonChangeOrd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер отчета, который\r\n вы хотите изменить";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 22);
            this.textBox1.TabIndex = 4;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(782, 303);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangeOrd);
            this.Controls.Add(this.buttonCreateOrd);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateOrd;
        private System.Windows.Forms.Button buttonChangeOrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}