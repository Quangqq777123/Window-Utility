namespace HeThongQuanLy
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnShutdownWindow = new System.Windows.Forms.Button();
            this.btnCalendarReminders = new System.Windows.Forms.Button();
            this.btnBlockInternetAccess = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(149)))));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(658, 70);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Window Utility";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShutdownWindow
            // 
            this.btnShutdownWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnShutdownWindow.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdownWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnShutdownWindow.Location = new System.Drawing.Point(43, 94);
            this.btnShutdownWindow.Name = "btnShutdownWindow";
            this.btnShutdownWindow.Size = new System.Drawing.Size(250, 50);
            this.btnShutdownWindow.TabIndex = 1;
            this.btnShutdownWindow.Text = "Window Controller";
            this.btnShutdownWindow.UseVisualStyleBackColor = false;
            this.btnShutdownWindow.Click += new System.EventHandler(this.btnShutdownWindow_Click);
            // 
            // btnCalendarReminders
            // 
            this.btnCalendarReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnCalendarReminders.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnCalendarReminders.Location = new System.Drawing.Point(365, 94);
            this.btnCalendarReminders.Name = "btnCalendarReminders";
            this.btnCalendarReminders.Size = new System.Drawing.Size(250, 50);
            this.btnCalendarReminders.TabIndex = 2;
            this.btnCalendarReminders.Text = "Calendar Reminders";
            this.btnCalendarReminders.UseVisualStyleBackColor = false;
            // 
            // btnBlockInternetAccess
            // 
            this.btnBlockInternetAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnBlockInternetAccess.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockInternetAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnBlockInternetAccess.Location = new System.Drawing.Point(43, 175);
            this.btnBlockInternetAccess.Name = "btnBlockInternetAccess";
            this.btnBlockInternetAccess.Size = new System.Drawing.Size(250, 50);
            this.btnBlockInternetAccess.TabIndex = 3;
            this.btnBlockInternetAccess.Text = "Block Internet Access";
            this.btnBlockInternetAccess.UseVisualStyleBackColor = false;
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnNotes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnNotes.Location = new System.Drawing.Point(365, 175);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(250, 50);
            this.btnNotes.TabIndex = 4;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(43, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remove Temporary Files";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(365, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Track Window Activity";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(658, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnBlockInternetAccess);
            this.Controls.Add(this.btnCalendarReminders);
            this.Controls.Add(this.btnShutdownWindow);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Utility";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnShutdownWindow;
        private System.Windows.Forms.Button btnCalendarReminders;
        private System.Windows.Forms.Button btnBlockInternetAccess;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

