﻿
namespace Lab8Prog
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fPath = new System.Windows.Forms.TextBox();
            this.sPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            

            this.button1.Location = new System.Drawing.Point(65, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Файл изменен";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
          

            this.button2.Location = new System.Drawing.Point(332, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Файл удален";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
           

            this.button3.Location = new System.Drawing.Point(598, 244);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Файл создан";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            
            
            this.fPath.Location = new System.Drawing.Point(203, 44);
            this.fPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fPath.Name = "fPath";
            this.fPath.Size = new System.Drawing.Size(562, 23);
            this.fPath.TabIndex = 3;
            
            
            this.sPath.Location = new System.Drawing.Point(203, 94);
            this.sPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sPath.Name = "sPath";
            this.sPath.Size = new System.Drawing.Size(561, 23);
            this.sPath.TabIndex = 4;
            
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь к первому устройству";
           

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь ко второму устройству";
            
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текст";
           
            
            this.newText.Location = new System.Drawing.Point(203, 138);
            this.newText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newText.Name = "newText";
            this.newText.Size = new System.Drawing.Size(561, 23);
            this.newText.TabIndex = 8;
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 395);
            this.Controls.Add(this.newText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sPath);
            this.Controls.Add(this.fPath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox fPath;
        private System.Windows.Forms.TextBox sPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newText;
    }
}

