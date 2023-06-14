namespace KSK
{
    partial class EmployeeWindow
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
            label6 = new Label();
            label5 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 54);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 9;
            label6.Text = "Nazwisko";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 30);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Imię";
            // 
            // button3
            // 
            button3.Location = new Point(65, 163);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 10;
            button3.Text = "Wyloguj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EmployeeWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 291);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "EmployeeWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button3;
    }
}