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

namespace InternetReconnectNotify
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        static string url = "http://google.com/";
        Boolean connected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                stopwatch.Start();
                lblCheckStatus.Text = "Check running";
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                checkForCon();
            }
            catch (Exception ex)
            {
                //lel
            }
        }

        public void checkForCon()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                try
                {
                    lblTimer.Text = stopwatch.Elapsed.Minutes.ToString() + " Minutes";
                    lblTryCount.Text = Convert.ToString(Convert.ToInt32(lblTryCount.Text) + 1);

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                    using (WebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        lblStatus.Text = "connected!";
                        lblStatus.ForeColor = Color.Green;

                        connected = true;
                        SystemSounds.Question.Play();
                        MessageBox.Show("Conratulations, you are connected to the internet!");
                        lblCheckStatus.Text = "Check stopped";
                    }
                }
                catch (Exception ex)
                {
                    connected = false;
                }

                Thread.Sleep(8500);
            } while (!connected && !backgroundWorker1.CancellationPending);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            stopwatch.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            lblCheckStatus.Text = "Check stopped";
        }
    }
}
