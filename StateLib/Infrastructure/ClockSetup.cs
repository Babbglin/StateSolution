using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateLib.Infrastructure.State;

namespace StateLib.Infrastructure
{
    public class ClockSetup
    {
        private IClockSetup yearState;
        private IClockSetup monthState;
        private IClockSetup dayState;
        private IClockSetup currentState;
        private IClockSetup finishedState;

        public ClockSetup()
        {
            this.finishedState = new FinishedState(this);
            this.currentState = this.finishedState;
        }

        public IClockSetup State
        {
            set
            {
                this.currentState = value;
            }
        }

        public IClockSetup YearState
        {
            get
            {
                return yearState;
            }
            set
            {
                yearState = value;
            }
        }

        public IClockSetup MonthState
        {
            get
            {
                return monthState;
            }
            set
            {
                monthState = value;
            }
        }

        public IClockSetup DayState
        {
            get
            {
                return dayState;
            }
            set
            {
                dayState = value;
            }
        }

        public IClockSetup FinishedState
        {
            get
            {
                return finishedState;
            }
        }

        public virtual void PushKnob()
        {
            currentState.SelectValue();
        }

        public virtual void RotateRight()
        {
            currentState.NextValue();
        }

        public virtual void RotateLeft()
        {
            currentState.PreviousValue();
        }

        public virtual DateTime GetSelectedDate()
        {
            return new DateTime(this.yearState.SelectedValue, this.monthState.SelectedValue, this.dayState.SelectedValue, 0, 0, 0);
        }
    }
}
