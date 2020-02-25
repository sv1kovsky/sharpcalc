namespace calcsharp
{
    partial class Form2
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
            this.resultip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.ip3 = new System.Windows.Forms.TextBox();
            this.ip4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ip1 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.maskbytes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultip
            // 
            this.resultip.Location = new System.Drawing.Point(31, 39);
            this.resultip.Name = "resultip";
            this.resultip.ReadOnly = true;
            this.resultip.Size = new System.Drawing.Size(343, 22);
            this.resultip.TabIndex = 0;
            this.resultip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(194, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = ".";
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(124, 81);
            this.ip2.MaxLength = 3;
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(64, 22);
            this.ip2.TabIndex = 15;
            // 
            // ip3
            // 
            this.ip3.Location = new System.Drawing.Point(217, 81);
            this.ip3.MaxLength = 3;
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(64, 22);
            this.ip3.TabIndex = 17;
            this.ip3.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ip4
            // 
            this.ip4.Location = new System.Drawing.Point(310, 81);
            this.ip4.MaxLength = 3;
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(64, 22);
            this.ip4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(287, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = ".";
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(31, 81);
            this.ip1.MaxLength = 3;
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(64, 22);
            this.ip1.TabIndex = 23;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(124, 162);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(157, 23);
            this.calculate.TabIndex = 24;
            this.calculate.Text = "Рассчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // maskbytes
            // 
            this.maskbytes.AcceptsTab = true;
            this.maskbytes.Location = new System.Drawing.Point(124, 119);
            this.maskbytes.MaxLength = 2;
            this.maskbytes.Name = "maskbytes";
            this.maskbytes.Size = new System.Drawing.Size(157, 22);
            this.maskbytes.TabIndex = 25;
            this.maskbytes.Text = "Введите кол-во бит";
            this.maskbytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskbytes.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 209);
            this.Controls.Add(this.maskbytes);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ip4);
            this.Controls.Add(this.ip3);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultip);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox ip3;
        private System.Windows.Forms.TextBox ip4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ip1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox maskbytes;
    }
}