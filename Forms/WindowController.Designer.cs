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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowController));
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.rBtnHibernate = new System.Windows.Forms.RadioButton();
            this.rBtnSleep = new System.Windows.Forms.RadioButton();
            this.rBtnLogOut = new System.Windows.Forms.RadioButton();
            this.rBtnRestart = new System.Windows.Forms.RadioButton();
            this.rBtnShutdown = new System.Windows.Forms.RadioButton();
            this.groupBoxSettingTime = new System.Windows.Forms.GroupBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.textBoxHr = new System.Windows.Forms.TextBox();
            this.rBtnStartAfter = new System.Windows.Forms.RadioButton();
            this.rBtnStartAt = new System.Windows.Forms.RadioButton();
            this.rBtnStartNow = new System.Windows.Forms.RadioButton();
            this.btnDecreaseHr = new System.Windows.Forms.Button();
            this.btnIncreaseHr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIncreaseMin = new System.Windows.Forms.Button();
            this.btnDecreaseMin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIncreaseSec = new System.Windows.Forms.Button();
            this.btnDecreaseSec = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxSettingTime.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(104, 334);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(138, 47);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.rBtnHibernate);
            this.groupBoxMode.Controls.Add(this.rBtnSleep);
            this.groupBoxMode.Controls.Add(this.rBtnLogOut);
            this.groupBoxMode.Controls.Add(this.rBtnRestart);
            this.groupBoxMode.Controls.Add(this.rBtnShutdown);
            this.groupBoxMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(149)))));
            this.groupBoxMode.Location = new System.Drawing.Point(19, 25);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(732, 85);
            this.groupBoxMode.TabIndex = 2;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // rBtnHibernate
            // 
            this.rBtnHibernate.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnHibernate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnHibernate.ForeColor = System.Drawing.Color.Navy;
            this.rBtnHibernate.Location = new System.Drawing.Point(595, 34);
            this.rBtnHibernate.Name = "rBtnHibernate";
            this.rBtnHibernate.Size = new System.Drawing.Size(120, 30);
            this.rBtnHibernate.TabIndex = 4;
            this.rBtnHibernate.Text = "Hibernate";
            this.rBtnHibernate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnHibernate.UseVisualStyleBackColor = true;
            // 
            // rBtnSleep
            // 
            this.rBtnSleep.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnSleep.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSleep.ForeColor = System.Drawing.Color.Navy;
            this.rBtnSleep.Location = new System.Drawing.Point(450, 34);
            this.rBtnSleep.Name = "rBtnSleep";
            this.rBtnSleep.Size = new System.Drawing.Size(120, 30);
            this.rBtnSleep.TabIndex = 3;
            this.rBtnSleep.Text = "Sleep";
            this.rBtnSleep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnSleep.UseVisualStyleBackColor = true;
            // 
            // rBtnLogOut
            // 
            this.rBtnLogOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnLogOut.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnLogOut.ForeColor = System.Drawing.Color.Navy;
            this.rBtnLogOut.Location = new System.Drawing.Point(305, 34);
            this.rBtnLogOut.Name = "rBtnLogOut";
            this.rBtnLogOut.Size = new System.Drawing.Size(120, 30);
            this.rBtnLogOut.TabIndex = 2;
            this.rBtnLogOut.Text = "Log out";
            this.rBtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnLogOut.UseVisualStyleBackColor = true;
            // 
            // rBtnRestart
            // 
            this.rBtnRestart.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnRestart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnRestart.ForeColor = System.Drawing.Color.Navy;
            this.rBtnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBtnRestart.Location = new System.Drawing.Point(160, 34);
            this.rBtnRestart.Name = "rBtnRestart";
            this.rBtnRestart.Size = new System.Drawing.Size(120, 30);
            this.rBtnRestart.TabIndex = 1;
            this.rBtnRestart.Text = "Restart";
            this.rBtnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnRestart.UseVisualStyleBackColor = true;
            // 
            // rBtnShutdown
            // 
            this.rBtnShutdown.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnShutdown.Checked = true;
            this.rBtnShutdown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnShutdown.ForeColor = System.Drawing.Color.Navy;
            this.rBtnShutdown.Location = new System.Drawing.Point(15, 34);
            this.rBtnShutdown.Name = "rBtnShutdown";
            this.rBtnShutdown.Size = new System.Drawing.Size(120, 30);
            this.rBtnShutdown.TabIndex = 0;
            this.rBtnShutdown.TabStop = true;
            this.rBtnShutdown.Text = "Shutdown";
            this.rBtnShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnShutdown.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettingTime
            // 
            this.groupBoxSettingTime.Controls.Add(this.labelNote);
            this.groupBoxSettingTime.Controls.Add(this.groupBoxTime);
            this.groupBoxSettingTime.Controls.Add(this.rBtnStartAfter);
            this.groupBoxSettingTime.Controls.Add(this.rBtnStartAt);
            this.groupBoxSettingTime.Controls.Add(this.rBtnStartNow);
            this.groupBoxSettingTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSettingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(149)))));
            this.groupBoxSettingTime.Location = new System.Drawing.Point(19, 126);
            this.groupBoxSettingTime.Name = "groupBoxSettingTime";
            this.groupBoxSettingTime.Size = new System.Drawing.Size(732, 191);
            this.groupBoxSettingTime.TabIndex = 3;
            this.groupBoxSettingTime.TabStop = false;
            this.groupBoxSettingTime.Text = "Setting Time";
            // 
            // labelNote
            // 
            this.labelNote.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(224, 134);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(468, 30);
            this.labelNote.TabIndex = 5;
            this.labelNote.Text = "label1";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.label3);
            this.groupBoxTime.Controls.Add(this.btnIncreaseSec);
            this.groupBoxTime.Controls.Add(this.btnDecreaseSec);
            this.groupBoxTime.Controls.Add(this.textBox3);
            this.groupBoxTime.Controls.Add(this.label2);
            this.groupBoxTime.Controls.Add(this.btnIncreaseMin);
            this.groupBoxTime.Controls.Add(this.btnDecreaseMin);
            this.groupBoxTime.Controls.Add(this.textBox2);
            this.groupBoxTime.Controls.Add(this.label1);
            this.groupBoxTime.Controls.Add(this.btnIncreaseHr);
            this.groupBoxTime.Controls.Add(this.btnDecreaseHr);
            this.groupBoxTime.Controls.Add(this.textBoxHr);
            this.groupBoxTime.Location = new System.Drawing.Point(224, 25);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(468, 91);
            this.groupBoxTime.TabIndex = 4;
            this.groupBoxTime.TabStop = false;
            // 
            // textBoxHr
            // 
            this.textBoxHr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHr.Location = new System.Drawing.Point(45, 29);
            this.textBoxHr.Multiline = true;
            this.textBoxHr.Name = "textBoxHr";
            this.textBoxHr.Size = new System.Drawing.Size(53, 30);
            this.textBoxHr.TabIndex = 0;
            // 
            // rBtnStartAfter
            // 
            this.rBtnStartAfter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnStartAfter.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnStartAfter.Location = new System.Drawing.Point(42, 134);
            this.rBtnStartAfter.Name = "rBtnStartAfter";
            this.rBtnStartAfter.Size = new System.Drawing.Size(120, 30);
            this.rBtnStartAfter.TabIndex = 2;
            this.rBtnStartAfter.Text = "Start After";
            this.rBtnStartAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnStartAfter.UseVisualStyleBackColor = true;
            this.rBtnStartAfter.CheckedChanged += new System.EventHandler(this.rBtnStartAfter_CheckedChanged);
            // 
            // rBtnStartAt
            // 
            this.rBtnStartAt.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnStartAt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnStartAt.Location = new System.Drawing.Point(42, 86);
            this.rBtnStartAt.Name = "rBtnStartAt";
            this.rBtnStartAt.Size = new System.Drawing.Size(120, 30);
            this.rBtnStartAt.TabIndex = 1;
            this.rBtnStartAt.Text = "Start At";
            this.rBtnStartAt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnStartAt.UseVisualStyleBackColor = true;
            this.rBtnStartAt.CheckedChanged += new System.EventHandler(this.rBtnStartAt_CheckedChanged);
            // 
            // rBtnStartNow
            // 
            this.rBtnStartNow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnStartNow.Checked = true;
            this.rBtnStartNow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnStartNow.Location = new System.Drawing.Point(42, 38);
            this.rBtnStartNow.Name = "rBtnStartNow";
            this.rBtnStartNow.Size = new System.Drawing.Size(120, 30);
            this.rBtnStartNow.TabIndex = 0;
            this.rBtnStartNow.TabStop = true;
            this.rBtnStartNow.Text = "Start Now";
            this.rBtnStartNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnStartNow.UseVisualStyleBackColor = true;
            this.rBtnStartNow.CheckedChanged += new System.EventHandler(this.rBtnStartNow_CheckedChanged);
            // 
            // btnDecreaseHr
            // 
            this.btnDecreaseHr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseHr.BackgroundImage")));
            this.btnDecreaseHr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecreaseHr.Location = new System.Drawing.Point(98, 44);
            this.btnDecreaseHr.Name = "btnDecreaseHr";
            this.btnDecreaseHr.Size = new System.Drawing.Size(20, 15);
            this.btnDecreaseHr.TabIndex = 2;
            this.btnDecreaseHr.UseVisualStyleBackColor = true;
            // 
            // btnIncreaseHr
            // 
            this.btnIncreaseHr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncreaseHr.BackgroundImage")));
            this.btnIncreaseHr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncreaseHr.Location = new System.Drawing.Point(98, 29);
            this.btnIncreaseHr.Name = "btnIncreaseHr";
            this.btnIncreaseHr.Size = new System.Drawing.Size(20, 15);
            this.btnIncreaseHr.TabIndex = 1;
            this.btnIncreaseHr.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(117, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "hr";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(245, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIncreaseMin
            // 
            this.btnIncreaseMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncreaseMin.BackgroundImage")));
            this.btnIncreaseMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncreaseMin.Location = new System.Drawing.Point(226, 29);
            this.btnIncreaseMin.Name = "btnIncreaseMin";
            this.btnIncreaseMin.Size = new System.Drawing.Size(20, 15);
            this.btnIncreaseMin.TabIndex = 4;
            this.btnIncreaseMin.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseMin
            // 
            this.btnDecreaseMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseMin.BackgroundImage")));
            this.btnDecreaseMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecreaseMin.Location = new System.Drawing.Point(226, 44);
            this.btnDecreaseMin.Name = "btnDecreaseMin";
            this.btnDecreaseMin.Size = new System.Drawing.Size(20, 15);
            this.btnDecreaseMin.TabIndex = 5;
            this.btnDecreaseMin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(173, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 30);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(374, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "sec";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIncreaseSec
            // 
            this.btnIncreaseSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncreaseSec.BackgroundImage")));
            this.btnIncreaseSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncreaseSec.Location = new System.Drawing.Point(355, 29);
            this.btnIncreaseSec.Name = "btnIncreaseSec";
            this.btnIncreaseSec.Size = new System.Drawing.Size(20, 15);
            this.btnIncreaseSec.TabIndex = 7;
            this.btnIncreaseSec.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseSec
            // 
            this.btnDecreaseSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseSec.BackgroundImage")));
            this.btnDecreaseSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecreaseSec.Location = new System.Drawing.Point(355, 44);
            this.btnDecreaseSec.Name = "btnDecreaseSec";
            this.btnDecreaseSec.Size = new System.Drawing.Size(20, 15);
            this.btnDecreaseSec.TabIndex = 8;
            this.btnDecreaseSec.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(302, 29);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 30);
            this.textBox3.TabIndex = 6;
            // 
            // WindowController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(771, 402);
            this.Controls.Add(this.groupBoxSettingTime);
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
            this.groupBoxSettingTime.ResumeLayout(false);
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton rBtnShutdown;
        private System.Windows.Forms.RadioButton rBtnLogOut;
        private System.Windows.Forms.RadioButton rBtnRestart;
        private System.Windows.Forms.RadioButton rBtnSleep;
        private System.Windows.Forms.GroupBox groupBoxSettingTime;
        private System.Windows.Forms.RadioButton rBtnHibernate;
        private System.Windows.Forms.RadioButton rBtnStartAt;
        private System.Windows.Forms.RadioButton rBtnStartNow;
        private System.Windows.Forms.RadioButton rBtnStartAfter;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxHr;
        private System.Windows.Forms.Button btnIncreaseHr;
        private System.Windows.Forms.Button btnDecreaseHr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIncreaseSec;
        private System.Windows.Forms.Button btnDecreaseSec;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIncreaseMin;
        private System.Windows.Forms.Button btnDecreaseMin;
        private System.Windows.Forms.TextBox textBox2;
    }
}