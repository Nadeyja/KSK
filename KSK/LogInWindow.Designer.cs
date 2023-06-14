namespace KSK
{
    partial class LogInWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(89, 90);
            login.Name = "login";
            login.Size = new Size(100, 23);
            login.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(89, 148);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(100, 23);
            password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 72);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 130);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Hasło";
            // 
            // button1
            // 
            button1.Location = new Point(110, 248);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 30);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 7;
            label3.Text = "Krajowa Stacja Krwiodastwa";
            // 
            // LogInWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 311);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LogInWindow";
            Text = "Krajowa Stacja Krwiodastwa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}