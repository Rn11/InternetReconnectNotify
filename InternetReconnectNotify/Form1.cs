using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Net.Http;
using System.Media;
using System.Reflection;

namespace InternetReconnectNotify
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        private static string url = "http://google.com/";
        Boolean connected = false;

        public static string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            lblVerVal.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            stop();
            btnStart.Enabled = false;
            chkAlwaysOnTop.Enabled = false;
            lblYouAre.Text = "Bye!";
            lblStatus.Visible = false;
            lblTryDscr.Visible = false;
            lblTryCount.Visible = false;
            lblTryingForDesc.Visible = false;
            lblTimer.Visible = false;
            lblCheckStatus.Visible = false;
            this.Update();
            Thread.Sleep(333);
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start();
        }

        public void checkForCon()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            NetworkUtil nu = new NetworkUtil();
            do
            {
                try
                {
                    lblTimer.Text = stopwatch.Elapsed.Minutes.ToString() + " Minutes";
                    lblTryCount.Text = Convert.ToString(Convert.ToInt32(lblTryCount.Text) + 1);

                    if (nu.checkNetwork(url))
                    {

                        lblStatus.Text = "connected!";
                        lblStatus.ForeColor = Color.Green;
                        connected = true;
                        lblCheckStatus.Text = "Check stopped";
                        SystemSounds.Question.Play();
                        MessageBox.Show("Conratulations, you are connected to the internet!");
                    }

                }
                catch (Exception ex)
                {
                    connected = false;
                }
                // Timeout 8.5 sec
                Thread.Sleep(8500);
            } while (!connected && !backgroundWorker1.CancellationPending);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlwaysOnTop.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void startCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start();
        }

        private void stopCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void start()
        {
            try
            {
                stopwatch.Start();
                lblCheckStatus.Text = "Check running";
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                startCheckToolStripMenuItem.Enabled = false;
                stopCheckToolStripMenuItem.Enabled = true;
                checkForCon();
            }
            catch (Exception ex)
            {
                //lel
            }
        }

        private void stop()
        {
            backgroundWorker1.CancelAsync();
            stopwatch.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            startCheckToolStripMenuItem.Enabled = true;
            stopCheckToolStripMenuItem.Enabled = false;
            lblCheckStatus.Text = "Check stopped";
        }

        private void customURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormURL f_url = new FormURL();
            f_url.Show();
        }
    }
}
