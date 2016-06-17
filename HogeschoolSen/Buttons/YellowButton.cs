using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public class YellowButton : AbstractButton
    {
        public YellowButton(string action)
        {
            SetColor("Yellow");
            SetName("Yellow Button");
            SetAction(action);
        }
    }
}
