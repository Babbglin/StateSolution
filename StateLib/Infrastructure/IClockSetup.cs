using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib.Infrastructure
{
    public interface IClockSetup
    {
        void SelectValue();
        void NextValue();
        void PreviousValue();

        int SelectedValue { get; }
    }
}
