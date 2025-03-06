using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowUtility
{
    
    public partial class Form1 : Form
    {
        private MainForm mainForm;
        public Form1()
        {
            InitializeComponent();
            this.mainForm = new MainForm();
        }

        private void btnWindowController_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                this.Hide();
                mainForm.Text = "Window Controller";  
                mainForm.loadScreen(new WindowController());
                mainForm.ShowDialog();
                this.Show();
            }
            else return;
        }
    }
}
