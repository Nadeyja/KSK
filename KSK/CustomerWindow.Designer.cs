﻿namespace KSK
{
    partial class CustomerWindow
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 136);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Grupa Krwi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 136);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(50, 326);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Wyniki";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 178);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 3;
            label3.Text = "Ulga:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 180);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // button2
            // 
            button2.Location = new Point(50, 253);
            button2.Name = "button2";
            button2.Size = new Size(144, 36);
            button2.TabIndex = 5;
            button2.Text = "Umów wizytę";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 43);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 6;
            label5.Text = "Imię";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 86);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 7;
            label6.Text = "Nazwisko";
            // 
            // button3
            // 
            button3.Location = new Point(63, 384);
            button3.Name = "button3";
            button3.Size = new Size(131, 38);
            button3.TabIndex = 8;
            button3.Text = "Wyloguj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CustomerWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 450);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerWindow";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Button button3;
    }
}