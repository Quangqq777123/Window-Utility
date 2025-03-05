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
            this.btnWindowController = new System.Windows.Forms.Button();
            this.btnCalendarReminders = new System.Windows.Forms.Button();
            this.btnBlockInternetAccess = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnRemoveTemporaryFiles = new System.Windows.Forms.Button();
            this.btnTrackWindowActivity = new System.Windows.Forms.Button();
            this.btnRepeatUserActivity = new System.Windows.Forms.Button();
            this.btnAutoClick = new System.Windows.Forms.Button();
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
            // btnWindowController
            // 
            this.btnWindowController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnWindowController.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowController.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnWindowController.Location = new System.Drawing.Point(55, 89);
            this.btnWindowController.Name = "btnWindowController";
            this.btnWindowController.Size = new System.Drawing.Size(250, 50);
            this.btnWindowController.TabIndex = 1;
            this.btnWindowController.Text = "Window Controller";
            this.btnWindowController.UseVisualStyleBackColor = false;
            this.btnWindowController.Click += new System.EventHandler(this.btnShutdownWindow_Click);
            // 
            // btnCalendarReminders
            // 
            this.btnCalendarReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnCalendarReminders.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnCalendarReminders.Location = new System.Drawing.Point(353, 89);
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
            this.btnBlockInternetAccess.Location = new System.Drawing.Point(55, 159);
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
            this.btnNotes.Location = new System.Drawing.Point(353, 159);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(250, 50);
            this.btnNotes.TabIndex = 4;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = false;
            // 
            // btnRemoveTemporaryFiles
            // 
            this.btnRemoveTemporaryFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnRemoveTemporaryFiles.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTemporaryFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnRemoveTemporaryFiles.Location = new System.Drawing.Point(55, 229);
            this.btnRemoveTemporaryFiles.Name = "btnRemoveTemporaryFiles";
            this.btnRemoveTemporaryFiles.Size = new System.Drawing.Size(250, 50);
            this.btnRemoveTemporaryFiles.TabIndex = 5;
            this.btnRemoveTemporaryFiles.Text = "Remove Temporary Files";
            this.btnRemoveTemporaryFiles.UseVisualStyleBackColor = false;
            // 
            // btnTrackWindowActivity
            // 
            this.btnTrackWindowActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnTrackWindowActivity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackWindowActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnTrackWindowActivity.Location = new System.Drawing.Point(353, 229);
            this.btnTrackWindowActivity.Name = "btnTrackWindowActivity";
            this.btnTrackWindowActivity.Size = new System.Drawing.Size(250, 50);
            this.btnTrackWindowActivity.TabIndex = 6;
            this.btnTrackWindowActivity.Text = "Track Window Activity";
            this.btnTrackWindowActivity.UseVisualStyleBackColor = false;
            // 
            // btnRepeatUserActivity
            // 
            this.btnRepeatUserActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnRepeatUserActivity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeatUserActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnRepeatUserActivity.Location = new System.Drawing.Point(353, 299);
            this.btnRepeatUserActivity.Name = "btnRepeatUserActivity";
            this.btnRepeatUserActivity.Size = new System.Drawing.Size(250, 50);
            this.btnRepeatUserActivity.TabIndex = 8;
            this.btnRepeatUserActivity.Text = "Repeat User Activity";
            this.btnRepeatUserActivity.UseVisualStyleBackColor = false;
            // 
            // btnAutoClick
            // 
            this.btnAutoClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnAutoClick.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(20)))), ((int)(((byte)(249)))));
            this.btnAutoClick.Location = new System.Drawing.Point(55, 299);
            this.btnAutoClick.Name = "btnAutoClick";
            this.btnAutoClick.Size = new System.Drawing.Size(250, 50);
            this.btnAutoClick.TabIndex = 7;
            this.btnAutoClick.Text = "Auto Click";
            this.btnAutoClick.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(658, 372);
            this.Controls.Add(this.btnRepeatUserActivity);
            this.Controls.Add(this.btnAutoClick);
            this.Controls.Add(this.btnTrackWindowActivity);
            this.Controls.Add(this.btnRemoveTemporaryFiles);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnBlockInternetAccess);
            this.Controls.Add(this.btnCalendarReminders);
            this.Controls.Add(this.btnWindowController);
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
        private System.Windows.Forms.Button btnWindowController;
        private System.Windows.Forms.Button btnCalendarReminders;
        private System.Windows.Forms.Button btnBlockInternetAccess;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnRemoveTemporaryFiles;
        private System.Windows.Forms.Button btnTrackWindowActivity;
        private System.Windows.Forms.Button btnRepeatUserActivity;
        private System.Windows.Forms.Button btnAutoClick;
    }
}

