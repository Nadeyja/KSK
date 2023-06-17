namespace KSK
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
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Grupa Krwi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(32, 153);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(109, 22);
            button1.TabIndex = 2;
            button1.Text = "Wyniki";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Ulga:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 97);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // button2
            // 
            button2.Location = new Point(32, 127);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(109, 22);
            button2.TabIndex = 5;
            button2.Text = "Twoje wizyty";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 18);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 6;
            label5.Text = "Imię";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 42);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "Nazwisko";
            // 
            // button3
            // 
            button3.Location = new Point(32, 179);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 8;
            button3.Text = "Wyloguj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(117, 207);
            button4.Name = "button4";
            button4.Size = new Size(47, 42);
            button4.TabIndex = 9;
            button4.Text = "Usuń konto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CustomerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(176, 261);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
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
        private Button button4;
    }
}