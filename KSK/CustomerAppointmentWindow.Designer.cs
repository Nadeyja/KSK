namespace KSK
{
    partial class Form1
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
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(92, 67);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 0;
            button1.Text = "Umów wizytę";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(67, 38);
            dateTimePicker1.MinDate = new DateTime(2023, 6, 14, 2, 48, 8, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2023, 6, 14, 2, 48, 8, 0);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 131);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(279, 154);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(92, 96);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 3;
            button2.Text = "Usuń zaznaczoną wizytę";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 303);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private Button button2;
    }
}