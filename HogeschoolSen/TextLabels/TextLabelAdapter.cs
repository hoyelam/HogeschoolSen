using HogeschoolSen.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.TextLabels
{
    public class TextLabelAdapter : IButton
    {
        private TextLabel _textLabel;

        public TextLabelAdapter(TextLabel textLabel)
        {
            _textLabel = textLabel;
        }

        public void DoAction()
        {
            _textLabel.PrintText();
        }

        public string GetColor()
        {
            return _textLabel.GetTextColor();
        }

        public string getName()
        {
            return _textLabel.GetName();
        }

        public void SetAction(string action)
        {
            _textLabel.SetText(action);
        }

        public void SetColor(string color)
        {
            _textLabel.SetTextColor(color);
        }

        public void SetName(string name)
        {
            _textLabel.SetName(name);
        }
    }
}
