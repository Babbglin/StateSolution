using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib.Infrastructure.State
{
    public class YearState:IClockSetup
    {
        private ClockSetup clockSetup;
        private int year;

        public YearState(ClockSetup setup, int year)
        {
            this.clockSetup = setup;
            this.year = year;
        }

        public void SelectValue()
        {
            Debug.WriteLine("Setting year to " + year);
            clockSetup.State = clockSetup.MonthState;
        }

        public void NextValue()
        {
            this.year++;
        }

        public void PreviousValue()
        {
            this.year--;
        }

        public virtual int SelectedValue
        {
            get { return this.year; }
        }
    }
}
