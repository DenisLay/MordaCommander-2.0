﻿namespace MordaCommander_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.path1 = new System.Windows.Forms.Button();
            this.path2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ftpConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(568, 436);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(605, 116);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(563, 436);
            this.listBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(605, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(482, 22);
            this.textBox2.TabIndex = 3;
            // 
            // path1
            // 
            this.path1.Location = new System.Drawing.Point(505, 79);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(75, 23);
            this.path1.TabIndex = 4;
            this.path1.Text = "button1";
            this.path1.UseVisualStyleBackColor = true;
            // 
            // path2
            // 
            this.path2.Location = new System.Drawing.Point(1093, 79);
            this.path2.Name = "path2";
            this.path2.Size = new System.Drawing.Size(75, 23);
            this.path2.TabIndex = 5;
            this.path2.Text = "button2";
            this.path2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ftpConnect
            // 
            this.ftpConnect.Location = new System.Drawing.Point(143, 12);
            this.ftpConnect.Name = "ftpConnect";
            this.ftpConnect.Size = new System.Drawing.Size(75, 23);
            this.ftpConnect.TabIndex = 7;
            this.ftpConnect.Text = "FTP";
            this.ftpConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 561);
            this.Controls.Add(this.ftpConnect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.path2);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button path1;
        private System.Windows.Forms.Button path2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ftpConnect;
    }
}

