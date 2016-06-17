using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.TextLabels
{
    interface  ITextLabel
    {
        void SetText(string text);
        void SetName(string name);
        void SetTextColor(string color);
        void PrintText();
        string GetText();
        string GetName();
        string GetTextColor();


    }

    public class TextLabel : ITextLabel
    {
        private string _textColor;
        private string _textLabelName;
        private string _text;

        public string GetTextColor()
        {
            return _textColor;
        }

        public string GetName()
        {
            return _textLabelName;
        }

        public string GetText()
        {
            return _text;
        }

        public void PrintText()
        {
            Console.WriteLine("Text Label " + _textLabelName + "has text : " + _text);
        }

        public void SetName(string name)
        {
            _textLabelName = name;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public void SetTextColor(string color)
        {
            _textColor = color;
        }
    }
}
