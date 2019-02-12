using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ctrlAlarmLib
{
    public partial class ctrlAlarmClock : ctrlAlarmLib.ctrlAlarm
    {
        private DateTime dateAlarmTime;
        private bool alarmSetTime;
        private bool colorTicker;
        private SoundPlayer player;
        private AlarmGame game;

        public DateTime AlarmTime
        {
            get
            {
                return dateAlarmTime;
            }
            set
            {
                dateAlarmTime = value;
            }
        }
        public bool AlarmSet
        {
            get
            {
                return alarmSetTime;
            }
            set
            {
                alarmSetTime = value;
            }
        }

        public ctrlAlarmClock()
        {
            InitializeComponent();
        }

        protected override void timer_Tick(object sender, System.EventArgs e)
        {
            // Calls the Timer_Tick method of ctrlAlarm.
            base.timer_Tick(sender, e);
            // Checks to see if the alarm is set.
            if (AlarmSet == false)
                return;
            else
            // If the date, hour, and minute of the alarm time are the same as
            // the current time, flash an alarm. 
            {
                if (AlarmTime.Date == DateTime.Now.Date && AlarmTime.Hour ==
                    DateTime.Now.Hour && AlarmTime.Minute == DateTime.Now.Minute)
                {
                    // Sets lblAlarmTime to true, and changes the background color based on
                    // the value of colorTicker. The background color of the label will flash once per tick of the clock.
                    lblAlarmTime.Visible = true;
                    if (colorTicker == false)
                    {
                        lblAlarmTime.BackColor = Color.Red;
                        colorTicker = true;
                    }
                    else
                    {
                        lblAlarmTime.BackColor = Color.Blue;
                        colorTicker = false;
                    }

                    //Sound Alarm
                    try
                    {
                        player = new SoundPlayer();
                        player.SoundLocation = @"E:\Berna\Unitec\2nd Sem 2016\ISCG7421 Adv Programme Devt\Assignment1\Rooster.wav";
                        player.PlayLooping();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Once the alarm has flashed for a minute, the label is made invisible again.
                    lblAlarmTime.BackColor = Color.Empty;
                }
                
            }
        }

        private void btnAlarmOff_Click(object sender, EventArgs e)
        {
            // Turns off the alarm.
            AlarmSet = false;
            // Hides the flashing label.
            lblAlarmTime.BackColor = Color.Empty;
            //finish the game
            player.Stop();

        }

        private void dtpAlarm_ValueChanged(object sender, EventArgs e)
        {
            AlarmTime = dtpAlarm.Value;
            AlarmSet = true;
            //lblAlarmTime.Text = AlarmTime.ToShortTimeString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //display picked alarm 
            lblAlarmTime.Text = AlarmTime.ToShortTimeString();
            lblAlarmTime.Visible = true;
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            game = new AlarmGame();
            game.Show();
        }
    }
}
