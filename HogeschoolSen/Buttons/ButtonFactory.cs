using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public class ButtonFactory
    {
        public AbstractButton makeNewButton(string color, string action)
        {
            if (color.ToLower() == "yellow")
                return new YellowButton(action);
            else if (color.ToLower() == "blue")
                return new BlueButton(action);
            else if (color.ToLower() == "red")
                return new RedButton(action);
            else return null;
        }
    }
}
