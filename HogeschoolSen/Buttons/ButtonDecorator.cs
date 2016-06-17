using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public abstract class ButtonDecorator : AbstractButton
    {
        protected AbstractButton _button;

        public ButtonDecorator(AbstractButton button)
        {
            _button = button;
        }


    }
}
