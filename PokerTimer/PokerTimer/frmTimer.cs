using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PokerTimer
{
    public partial class frmTimer : Form
    {
        public List<int> sbs { get; set; }
        public List<int> bbs { get; set; }
        public List<int> ats { get; set; }
        public List<int> brs { get; set; }
        public int timePerLevel { get; set; }
        public string name { get; set; }

        private TimeSpan timeLeft;
        private int currentTime;
        private int loc = 0;

        private const int multiplier = 60000;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="sbs"></param>
        /// <param name="bbs"></param>
        /// <param name="ats"></param>
        /// <param name="brs"></param>
        /// <param name="timePerLevel"></param>
        public frmTimer(List<int> sbs, List<int> bbs, List<int> ats, List<int> brs, int timePerLevel, string name)
        {
            InitializeComponent();

            // store vars
            this.sbs = sbs;
            this.bbs = bbs;
            this.ats = ats;
            this.brs = brs;
            this.timePerLevel = timePerLevel;
            this.name = name;

            // convert time left to miliseconds for our Timer object
            this.currentTime = timePerLevel * multiplier;

            // setup the initial form view
            setupBaseViews();
        }

        /// <summary>
        /// setup the basic views for this form
        /// </summary>
        private void setupBaseViews()
        {
            if (name == "")
            {
                name = "Poker Tournament";
            }

            clock.Start();

            lblTitle.Text = name;
            this.update_labels(0);
            this.set_timer_label(currentTime);
        }

        /// <summary>
        /// start button clicked - start/pause the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Start" || btnAction.Text == "Resume")
            {
                timer.Start();
                btnAction.Text = "Pause";
            }
            else
            {
                timer.Stop();
                btnAction.Text = "Resume";
            }
        }

        /// <summary>
        /// each tick from our Timer object triggers this method.
        /// Show a countdown, current sb/bb, next sb/bb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            currentTime -= 1000;

            if (currentTime <= 0)
            {
                // reset time and update our array index
                loc++;
                this.play_sound();
                this.set_timer(loc);

                // update the form
                this.update_labels(loc);
            }

            this.set_timer_label(currentTime);
        }

        /// <summary>
        /// update our timer
        /// </summary>
        /// <param name="loc"></param>
        private void set_timer(int loc)
        {
            if (brs[loc] > 0)
            {
                currentTime = brs[loc] * multiplier;
            }
            else
            {
                currentTime = timePerLevel * multiplier;
            }
        }

        /// <summary>
        /// update our form after a level has changed
        /// </summary>
        /// <param name="loc"></param>
        private void update_labels(int loc)
        {
            var level = loc + 1;
            lblLevel.Text = level.ToString();

            if (loc + 1 < sbs.Count())
            {
                if (sbs[loc] == 0)
                {
                    lblBlinds.Text = "Break";
                }
                else
                {
                    lblBlinds.Text = sbs[loc].ToString() + "/" + bbs[loc].ToString();
                    if (ats[loc] != 0)
                    {
                        lblAnte.Text = ats[loc].ToString();
                    }
                }

                if (sbs[loc + 1] == 0)
                {
                    lblNextBlinds.Text = "Break";
                }
                else
                {
                    lblNextBlinds.Text = sbs[loc + 1].ToString() + "/" + bbs[loc + 1].ToString();
                    if (ats[loc + 1] != 0)
                    {
                        lblNextAnte.Text = ats[loc + 1].ToString();
                    }
                }
            }
            else
            {
                // no more levels
                lblBlinds.Text = sbs[loc].ToString() + "/" + bbs[loc].ToString();
                lblNextBlinds.Text = "Finished";
                lblNextAnte.Text = "-";
                btnSkip.Enabled = false;
            }
        }

        /// <summary>
        /// skip a blind level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkip_Click(object sender, EventArgs e)
        {
            loc++;
            this.set_timer(loc);
            this.update_labels(loc);
        }

        /// <summary>
        /// toggle visibility for a list of labels
        /// </summary>
        /// <param name="labels"></param>
        private void toggle(List<Label> labels)
        {
            foreach (Label l in labels)
            {
                if (l.Visible == true)
                {
                    l.Visible = false;
                }
                else
                {
                    l.Visible = true;
                }
            }
        }

        /// <summary>
        /// play the sound for the next level
        /// </summary>
        private void play_sound()
        {
            SoundPlayer snd = new SoundPlayer(PokerTimer.Properties.Resources.next_level);
            snd.Play();
        }

        /// <summary>
        /// Ticker for time of day clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clock_Tick(object sender, EventArgs e)
        {
            lblTimeOfDay.Text = DateTime.Now.ToShortTimeString();
        }

        /// <summary>
        /// update the label for the countdown timer
        /// </summary>
        /// <param name="curTime"></param>
        private void set_timer_label(int curTime)
        {
            timeLeft = TimeSpan.FromMilliseconds(curTime);
            lblTimer.Text = timeLeft.ToString();
        }
    }
}
