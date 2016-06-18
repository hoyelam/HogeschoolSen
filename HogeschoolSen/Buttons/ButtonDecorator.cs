using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public abstract class ButtonDecorator : IButton
    {
        protected AbstractButton _button;

        public ButtonDecorator(AbstractButton button)
        {
            _button = button;
        }

        public void DoAction()
        {
            _button.DoAction();
        }

        public string GetColor()
        {
            return _button.GetColor();
        }

        public string getName()
        {
            return _button.getName();
        }

        public void SetAction(string action)
        {
            _button.SetAction(action);
        }

        public void SetColor(string color)
        {
            _button.SetColor(color);
        }

        public void SetName(string name)
        {
            _button.SetName(name);
        }
    }
}
