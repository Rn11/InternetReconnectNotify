namespace InternetReconnectNotify
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCheckStatus = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTryingForDesc = new System.Windows.Forms.Label();
            this.lblTryCount = new System.Windows.Forms.Label();
            this.lblTryDscr = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblYouAre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 126);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start check";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(151, 126);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 29);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop check";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(105, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCheckStatus);
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Controls.Add(this.lblTryingForDesc);
            this.groupBox1.Controls.Add(this.lblTryCount);
            this.groupBox1.Controls.Add(this.lblTryDscr);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblYouAre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lblCheckStatus
            // 
            this.lblCheckStatus.AutoSize = true;
            this.lblCheckStatus.Location = new System.Drawing.Point(9, 80);
            this.lblCheckStatus.Name = "lblCheckStatus";
            this.lblCheckStatus.Size = new System.Drawing.Size(79, 13);
            this.lblCheckStatus.TabIndex = 6;
            this.lblCheckStatus.Text = "Check stopped";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(66, 58);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 5;
            // 
            // lblTryingForDesc
            // 
            this.lblTryingForDesc.AutoSize = true;
            this.lblTryingForDesc.Location = new System.Drawing.Point(9, 58);
            this.lblTryingForDesc.Name = "lblTryingForDesc";
            this.lblTryingForDesc.Size = new System.Drawing.Size(51, 13);
            this.lblTryingForDesc.TabIndex = 4;
            this.lblTryingForDesc.Text = "Trying for";
            // 
            // lblTryCount
            // 
            this.lblTryCount.AutoSize = true;
            this.lblTryCount.Location = new System.Drawing.Point(50, 38);
            this.lblTryCount.Name = "lblTryCount";
            this.lblTryCount.Size = new System.Drawing.Size(13, 13);
            this.lblTryCount.TabIndex = 3;
            this.lblTryCount.Text = "0";
            // 
            // lblTryDscr
            // 
            this.lblTryDscr.AutoSize = true;
            this.lblTryDscr.Location = new System.Drawing.Point(9, 38);
            this.lblTryDscr.Name = "lblTryDscr";
            this.lblTryDscr.Size = new System.Drawing.Size(40, 13);
            this.lblTryDscr.TabIndex = 2;
            this.lblTryDscr.Text = "Try nr. ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(81, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(101, 16);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "disconnected";
            // 
            // lblYouAre
            // 
            this.lblYouAre.AutoSize = true;
            this.lblYouAre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouAre.Location = new System.Drawing.Point(9, 16);
            this.lblYouAre.Name = "lblYouAre";
            this.lblYouAre.Size = new System.Drawing.Size(66, 16);
            this.lblYouAre.TabIndex = 0;
            this.lblYouAre.Text = "You are ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Name = "Form1";
            this.Text = "Reconnect Checker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblYouAre;
        private System.Windows.Forms.Label lblTryingForDesc;
        private System.Windows.Forms.Label lblTryCount;
        private System.Windows.Forms.Label lblTryDscr;
        private System.Windows.Forms.Label lblTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCheckStatus;
    }
}

