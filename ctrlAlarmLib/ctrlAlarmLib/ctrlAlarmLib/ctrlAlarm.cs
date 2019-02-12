using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctrlAlarmLib
{
    public enum gameOutcome { GoodMorning, TryItAgain };

    public partial class ctrlAlarm: UserControl
    {
        private Color fColor;
        
        //Sets and updates the font colour of time 
        public Color ClockForeColor
        {
            get
            {
                return fColor;
            }
            set
            {
                fColor = value;
                lblTime.ForeColor = fColor;
            }
        }

        public ctrlAlarm()
        {
            InitializeComponent();
        }

        class Game
        {

        }

        class GameController
        {

        }

        private void btnVolume_Click(object sender, EventArgs e)
        {

        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            //ClockForeColor();
        }

        protected virtual void timer_Tick(object sender, EventArgs e)
        {
            // Causes the label to display the current time.
            lblTime.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
