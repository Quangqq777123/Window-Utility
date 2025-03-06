namespace WindowUtility
{
    partial class WindowController
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
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.rBtnSleep = new System.Windows.Forms.RadioButton();
            this.rBtnLogOut = new System.Windows.Forms.RadioButton();
            this.rBtnRestart = new System.Windows.Forms.RadioButton();
            this.rBtnShutdown = new System.Windows.Forms.RadioButton();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(117, 373);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(138, 47);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.rBtnSleep);
            this.groupBoxMode.Controls.Add(this.rBtnLogOut);
            this.groupBoxMode.Controls.Add(this.rBtnRestart);
            this.groupBoxMode.Controls.Add(this.rBtnShutdown);
            this.groupBoxMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(149)))));
            this.groupBoxMode.Location = new System.Drawing.Point(28, 35);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(634, 90);
            this.groupBoxMode.TabIndex = 2;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // rBtnSleep
            // 
            this.rBtnSleep.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSleep.ForeColor = System.Drawing.Color.Navy;
            this.rBtnSleep.Location = new System.Drawing.Point(485, 43);
            this.rBtnSleep.Name = "rBtnSleep";
            this.rBtnSleep.Size = new System.Drawing.Size(120, 30);
            this.rBtnSleep.TabIndex = 3;
            this.rBtnSleep.Text = "Sleep";
            this.rBtnSleep.UseVisualStyleBackColor = true;
            // 
            // rBtnLogOut
            // 
            this.rBtnLogOut.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnLogOut.ForeColor = System.Drawing.Color.Navy;
            this.rBtnLogOut.Location = new System.Drawing.Point(333, 43);
            this.rBtnLogOut.Name = "rBtnLogOut";
            this.rBtnLogOut.Size = new System.Drawing.Size(120, 30);
            this.rBtnLogOut.TabIndex = 2;
            this.rBtnLogOut.Text = "Log out";
            this.rBtnLogOut.UseVisualStyleBackColor = true;
            // 
            // rBtnRestart
            // 
            this.rBtnRestart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnRestart.ForeColor = System.Drawing.Color.Navy;
            this.rBtnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBtnRestart.Location = new System.Drawing.Point(181, 43);
            this.rBtnRestart.Name = "rBtnRestart";
            this.rBtnRestart.Size = new System.Drawing.Size(120, 30);
            this.rBtnRestart.TabIndex = 1;
            this.rBtnRestart.Text = "Restart";
            this.rBtnRestart.UseVisualStyleBackColor = true;
            // 
            // rBtnShutdown
            // 
            this.rBtnShutdown.Checked = true;
            this.rBtnShutdown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnShutdown.ForeColor = System.Drawing.Color.Navy;
            this.rBtnShutdown.Location = new System.Drawing.Point(29, 43);
            this.rBtnShutdown.Name = "rBtnShutdown";
            this.rBtnShutdown.Size = new System.Drawing.Size(120, 30);
            this.rBtnShutdown.TabIndex = 0;
            this.rBtnShutdown.TabStop = true;
            this.rBtnShutdown.Text = "Shutdown";
            this.rBtnShutdown.UseVisualStyleBackColor = true;
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Controls.Add(this.button1);
            this.groupBoxSetting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(149)))));
            this.groupBoxSetting.Location = new System.Drawing.Point(28, 153);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(634, 202);
            this.groupBoxSetting.TabIndex = 3;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Settings";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(29, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Now";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WindowController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(691, 446);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.btnHome);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "WindowController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Controller";
            this.Load += new System.EventHandler(this.WindowController_Load);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton rBtnShutdown;
        private System.Windows.Forms.RadioButton rBtnLogOut;
        private System.Windows.Forms.RadioButton rBtnRestart;
        private System.Windows.Forms.RadioButton rBtnSleep;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.Button button1;
    }
}