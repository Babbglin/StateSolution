using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib.Infrastructure.State
{
    public class MonthState:IClockSetup
    {
        private ClockSetup clockSetup;
        private int month;
        public MonthState(ClockSetup setup, int month)
        {
            this.clockSetup = setup;
            this.month = month;
        }

        public void SelectValue()
        {
            Debug.WriteLine("Setting month to " + month);
            clockSetup.State = clockSetup.DayState;
        }

        public void NextValue()
        {
            if (this.month < 12)
            {
                this.month++;
            }
           
        }

        public void PreviousValue()
        {
            if (this.month > 1)
            {
                this.month--;
            }
            
        }

        public int SelectedValue
        {
            get
            {
                return this.month;
            }
        }
    }
}
