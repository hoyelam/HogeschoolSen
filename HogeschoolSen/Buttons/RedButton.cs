using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public class RedButton : AbstractButton
    {
        public RedButton(string action)
        {
            SetColor("Red");
            SetName("Red Button");
            SetAction(action);
        }
    }
}
