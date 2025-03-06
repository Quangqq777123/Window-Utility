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

        public Form1()
        {
            InitializeComponent();

        }

        private void btnWindowController_Click(object sender, EventArgs e)
        {
            Form windowControllerForm = new WindowController();
            this.Hide();
            windowControllerForm.ShowDialog();
            this.Show();
        }
    }
}
