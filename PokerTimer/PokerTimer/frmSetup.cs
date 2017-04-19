using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerTimer
{
    public partial class frmSetup : Form
    {
        /// <summary>
        /// constructor
        /// </summary>
        public frmSetup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// start button was clicked:
        /// validate all form input then show the Timer form
        /// if validation is successful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            List<int> smallBlinds = new List<int>();
            List<int> bigBlinds = new List<int>();
            List<int> antes = new List<int>();
            List<int> breaks = new List<int>();
            int time = 15;

            var timeRegex = new Regex(@"^(\d+)$");
            Match match = timeRegex.Match(txtTimePerLevel.Text.ToString());

            if (match.Success)
            {
                time = Convert.ToInt32(txtTimePerLevel.Text);

                var regex = new Regex(@"^(\d+),?(\d+)?,?(\d+)?$");
                var matches = 0;

                for (int i = 0; i < txtSchedule.Lines.Length; i++)
                {
                    Match m = regex.Match(txtSchedule.Lines[i].ToString());

                    // verify that each line of input is valid
                    if (m.Success)
                    {
                        var breakRegex = new Regex(@"^\d+$");
                        var smallBig = new Regex(@"^\d+,\d+$");
                        var smallBigAnte = new Regex(@"^\d+,\d+,\d+$");

                        Match m1 = breakRegex.Match(txtSchedule.Lines[i].ToString());
                        Match m2 = smallBig.Match(txtSchedule.Lines[i].ToString());
                        Match m3 = smallBigAnte.Match(txtSchedule.Lines[i].ToString());

                        if (m1.Success) // we have a break
                        {
                            smallBlinds.Add(0);
                            bigBlinds.Add(0);
                            antes.Add(0);
                            breaks.Add(Convert.ToInt32(m.Groups[1].Value));
                        }
                        else if (m2.Success) // we have small/big
                        {
                            smallBlinds.Add(Convert.ToInt32(m.Groups[1].Value));
                            bigBlinds.Add(Convert.ToInt32(m.Groups[2].Value));
                            antes.Add(0);
                            breaks.Add(0);
                        }
                        else if (m3.Success) // we have small/big/ante
                        {
                            smallBlinds.Add(Convert.ToInt32(m.Groups[1].Value));
                            bigBlinds.Add(Convert.ToInt32(m.Groups[2].Value));
                            antes.Add(Convert.ToInt32(m.Groups[3].Value));
                            breaks.Add(0);
                        }

                        matches++;
                    }
                    else
                    {
                        MessageBox.Show("Your input is invalid");
                    }
                }

                // all input lines are good - lets show the timer
                if (matches == txtSchedule.Lines.Length)
                {
                    this.Hide();
                    frmTimer f = new frmTimer(smallBlinds, bigBlinds, antes, breaks, time, txtName.Text);
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Please provide the Time Per Level in minutes");
            }
        }

        /// <summary>
        /// open file dialog button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {   
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        String line = sr.ReadToEnd();
                        txtSchedule.Text = line.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file could not be read: " + ex.Message);
                }
            }
        }
    }
}
