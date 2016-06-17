using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public class BlueButton : AbstractButton
    {
        public BlueButton(string action)
        {
            SetColor("Blue");
            SetName("Blue Button");
            SetAction(action);
        }
    }
}
