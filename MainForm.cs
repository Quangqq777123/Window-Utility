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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Size newFormSize(int width, int height)
        {
            return new Size(width+20, height+50);
        }
        public void loadScreen(UserControl screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.None;
            mainPanel.Controls.Add(screen);
            this.Size = this.newFormSize(screen.Width, screen.Height);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
