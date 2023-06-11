using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSK
{
    public partial class CustomerWindow : Form
    {
        public CustomerWindow()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            this.Close();
            logInWindow.Show();
            
        }
        private void CustomerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        }
}
