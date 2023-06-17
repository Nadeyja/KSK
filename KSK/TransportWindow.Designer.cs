namespace KSK
{
    partial class TransportWindow
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
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(93, 117);
            button2.Name = "button2";
            button2.Size = new Size(119, 47);
            button2.TabIndex = 7;
            button2.Text = "Usuń zaznaczony transport";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 183);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(279, 154);
            listBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(69, 12);
            dateTimePicker1.MinDate = new DateTime(2023, 6, 14, 2, 48, 8, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2023, 6, 14, 2, 48, 8, 0);
            // 
            // button1
            // 
            button1.Location = new Point(93, 88);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 4;
            button1.Text = "Umów transport";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 41);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 9;
            label1.Text = "Trasa w formacie \"Początek-Koniec\"";
            // 
            // TransportWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 360);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TransportWindow";
            Text = "TransportWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}