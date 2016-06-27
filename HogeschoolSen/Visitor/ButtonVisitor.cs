using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogeschoolSen.Buttons;

namespace HogeschoolSen.Visitor
{
    class ButtonVisitor : ISizeVisitor
    {
        public SizeAdjustableDecorator Visit(SizeAdjustableDecorator button)
        {
            if (button.GetColor() == "yellow")
            {
                button.AdjustHeight(30);
                button.AdjustWidth(30);
                return button;
            } else if (button.GetColor() == "red")
            {
                button.AdjustHeight(40);
                button.AdjustWidth(40);
                return button;
            } else if (button.GetColor() == "blue")
            {
                button.AdjustHeight(50);
                button.AdjustWidth(50);
                return button;
            } else
            {
                button.AdjustHeight(20);
                button.AdjustWidth(20);
                return button;
            }
        }
    }
}
