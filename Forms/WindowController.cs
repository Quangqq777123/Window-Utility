using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowUtility
{
    public partial class WindowController : System.Windows.Forms.Form
    {
        PowerControl powerControl;
        public WindowController()
        {
            InitializeComponent();
            powerControl = new PowerControl();
        }


        private void WindowController_Load(object sender, EventArgs e)
        {
            labelNote.Text = changeNote();
            textBoxHr.Enabled = false;
            textBoxMin.Enabled = false;
            textBoxSec.Enabled = false;
        }

        private string changeNote()
        {   
            
            string note = "**System will automatically ";
            if(rBtnShutdown.Checked)
            {
                note += "shutdown ";
            }
            else if(rBtnRestart.Checked)
            {
                note += "reset ";
            }
            else if(rBtnLogOut.Checked)
            {
                note += "logout ";
            }
            else if (rBtnSleep.Checked)
            {
                note += "sleep ";
            }
            else
            {
                note += "hibernate ";
            }

            if (rBtnStartNow.Checked)
            {
                note += "now!!!";
            }
            else if (rBtnStartAt.Checked)
            {
                note += "after the predefined time!!!";
            }
            else
            {
                note += "after a specified period!!!";
            }
            return note;
        }

        private void rBtnStartNow_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnStartNow.Checked)
            {
                labelNote.Text = changeNote();
                textBoxHr.Enabled = false;
                textBoxMin.Enabled = false;
                textBoxSec.Enabled = false;

            }
        }

        private void rBtnStartAt_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnStartAt.Checked)
            {
                labelNote.Text = changeNote();
                textBoxHr.Enabled = true;
                textBoxMin.Enabled = true;
                textBoxSec.Enabled = true;
            }
        }

        private void rBtnStartAfter_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnStartAfter.Checked)
            {
                labelNote.Text = changeNote();
                textBoxHr.Enabled = true;
                textBoxMin.Enabled = true;
                textBoxSec.Enabled = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rBtnShutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnShutdown.Checked)
            {
                labelNote.Text = changeNote();
            }
        }

        private void rBtnRestart_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRestart.Checked)
            {
                labelNote.Text = changeNote();
            }
        }

        private void rBtnLogOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLogOut.Checked)
            {
                labelNote.Text = changeNote();
            }
        }

        private void rBtnSleep_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnSleep.Checked)
            {
                labelNote.Text = changeNote();
            }
        }

        private void rBtnHibernate_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHibernate.Checked)
            {
                labelNote.Text = changeNote();
            }
        }

        private void textBoxHr_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBoxHr.Text;
            if (!currentText.All(char.IsDigit) || currentText.Length >2)
            {
                textBoxHr.Clear();
                return;
            }


            int value = string.IsNullOrEmpty(currentText) ? 0 : int.Parse(currentText);

            string newValue = currentText;
            if (rBtnStartAfter.Checked && value > 99)
                newValue = "99";
            else if (rBtnStartAt.Checked && value > 23)
                newValue = "23";


            if (currentText != newValue)
                textBoxHr.Text = newValue;
        }

        private void btnIncreaseHr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHr.Text)) textBoxHr.Text = "00";
            int temp = int.Parse(textBoxHr.Text) + 1;

            if (rBtnStartAfter.Checked)
            {
                if (temp > 99) temp = 99;
            }
            else if (rBtnStartAt.Checked)
            {
                if (temp > 23) temp = 23;
            }
            else
            {
                temp = 0;
            }

            textBoxHr.Text = temp.ToString("D2");
        }

        private void btnDecreaseHr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHr.Text)) textBoxHr.Text = "00";
            int temp = int.Parse(textBoxHr.Text) - 1;

            if (rBtnStartAfter.Checked|| rBtnStartAt.Checked)
            {
                if (temp <0) temp = 0;
            }
            else
            {
                temp = 0;
            }

            textBoxHr.Text = temp.ToString("D2");
        }

        private void textBoxHr_Click(object sender, EventArgs e)
        {
            textBoxHr.Clear();
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBoxMin.Text;
            if (!currentText.All(char.IsDigit) || currentText.Length > 2)
            {
                textBoxMin.Clear();
                return;
            }


            int value = string.IsNullOrEmpty(currentText) ? 0 : int.Parse(currentText);

            string newValue = currentText;
            if ((rBtnStartAfter.Checked || rBtnStartAt.Checked)&& value > 59)
                newValue = "59";



            if (currentText != newValue)
                textBoxMin.Text = newValue;
        }

        private void textBoxMin_Click(object sender, EventArgs e)
        {
            textBoxMin.Clear();
        }

        private void btnIncreaseMin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMin.Text)) textBoxMin.Text = "00";
            int temp = int.Parse(textBoxMin.Text) + 1;

            if (rBtnStartAfter.Checked|| rBtnStartAt.Checked)
            {
                if (temp > 59) temp = 59;
            }

            else
            {
                temp = 0;
            }

            textBoxMin.Text = temp.ToString("D2");
        }

        private void btnDecreaseMin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMin.Text)) textBoxMin.Text = "00";
            int temp = int.Parse(textBoxMin.Text) - 1;

            if (rBtnStartAfter.Checked || rBtnStartAt.Checked)
            {
                if (temp < 0) temp = 0;
            }
            else
            {
                temp = 0;
            }

            textBoxMin.Text = temp.ToString("D2");
        }

        private void textBoxSec_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBoxSec.Text;
            if (!currentText.All(char.IsDigit) || currentText.Length > 2)
            {
                textBoxSec.Clear();
                return;
            }


            int value = string.IsNullOrEmpty(currentText) ? 0 : int.Parse(currentText);

            string newValue = currentText;
            if ((rBtnStartAfter.Checked || rBtnStartAt.Checked) && value > 59)
                newValue = "59";



            if (currentText != newValue)
                textBoxSec.Text = newValue;
        }

        private void textBoxSec_Click(object sender, EventArgs e)
        {
            textBoxSec.Clear();
        }

        private void btnIncreaseSec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMin.Text)) textBoxSec.Text = "00";
            int temp = int.Parse(textBoxSec.Text) + 1;

            if (rBtnStartAfter.Checked || rBtnStartAt.Checked)
            {
                if (temp > 59) temp = 59;
            }

            else
            {
                temp = 0;
            }

            textBoxSec.Text = temp.ToString("D2");
        }

        private void btnDecreaseSec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSec.Text)) textBoxSec.Text = "00";
            int temp = int.Parse(textBoxMin.Text) - 1;

            if (rBtnStartAfter.Checked || rBtnStartAt.Checked)
            {
                if (temp < 0) temp = 0;
            }
            else
            {
                temp = 0;
            }

            textBoxSec.Text = temp.ToString("D2");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHr.Text))
                textBoxHr.Text = "00";
            if (string.IsNullOrWhiteSpace(textBoxMin.Text))
                textBoxMin.Text = "00";
            if (string.IsNullOrWhiteSpace(textBoxSec.Text))
                textBoxSec.Text = "00";

            DialogResult result = MessageBox.Show("Do you confirm your action?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                CustomTime nowTime = new CustomTime();
                double secondGap;
                if (rBtnStartNow.Checked)
                {
                    secondGap = 0;
                }
                else if (rBtnStartAt.Checked)
                {
                    
                    CustomTime settingsTime = new CustomTime(int.Parse(textBoxHr.Text), int.Parse(textBoxMin.Text), int.Parse(textBoxSec.Text));
                    secondGap = settingsTime.getDifferenceSeconds(nowTime);
                    while(secondGap < 0) {
                        settingsTime.addDay(1);
                        secondGap = settingsTime.getDifferenceSeconds(nowTime);
                    }
                }
                else
                {
                    secondGap= int.Parse(textBoxHr.Text)*3600 + int.Parse(textBoxMin.Text)*60 + int.Parse(textBoxSec.Text);
                }

                

                if(rBtnShutdown.Checked)
                {
                    powerControl.shutdown((int)secondGap);
                }
                else if(rBtnSleep.Checked)
                {
                    powerControl.sleep((int)secondGap);
                }
                else if (rBtnLogOut.Checked)
                {
                    powerControl.logout((int)secondGap);
                }
                else if (rBtnRestart.Checked)
                {
                    powerControl.restart((int)secondGap);
                }
                else
                { 
                    powerControl.hibernate((int)secondGap);
                }
            }
            else return;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (powerControl != null)
            {
                powerControl.cancelAllActions();
            }
            else return;
        }
    }
}
