namespace KSK
{
    partial class EmployeeAppointmentWindow
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
            button2 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(166, 78);
            button2.Name = "button2";
            button2.Size = new Size(119, 43);
            button2.TabIndex = 7;
            button2.Text = "Usuń zaznaczoną wizytę";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(404, 169);
            listBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(166, 31);
            button1.Name = "button1";
            button1.Size = new Size(119, 41);
            button1.TabIndex = 4;
            button1.Text = "Zaakceptuj zaznaczoną wizytę";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EmployeeAppointmentWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 322);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeeAppointmentWindow";
            Text = "EmployeeAppointmentWindow";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private ListBox listBox1;
        private Button button1;
    }
}