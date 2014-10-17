using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib.Infrastructure.State
{
    public class FinishedState:IClockSetup
    {
        private ClockSetup clockSetup;
        public FinishedState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
        }
        public void SelectValue()
        {
            this.clockSetup.State = this.clockSetup.YearState;
        }

        public void NextValue()
        {
          Debug.WriteLine("You are finished...");
        }

        public void PreviousValue()
        {
            Debug.WriteLine("You are finished...");
        }

        public int SelectedValue
        {
            get
            {
                throw new NotSupportedException("Clock setup is finished");
            } 
        }
    }
}
