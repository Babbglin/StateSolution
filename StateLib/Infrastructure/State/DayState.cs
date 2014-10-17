using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib.Infrastructure.State
{
    public class DayState:IClockSetup
    {
        private ClockSetup clockSetup;
        private int day;
        public DayState(ClockSetup setup, int day)
        {
            this.clockSetup = setup;
            this.day = day;
        }

        public void SelectValue()
        {
            Debug.WriteLine("Setting day to "+ day);
            clockSetup.State = clockSetup.FinishedState;
        }

        public void NextValue()
        {
            if (this.day < 30)
            {
                this.day++;
            }
        }

        public void PreviousValue()
        {
            if (this.day > 1)
            {
                this.day--;
            }
        }

        public int SelectedValue
        {
            get
            {
                return this.day;
            }
        }
    }
}
