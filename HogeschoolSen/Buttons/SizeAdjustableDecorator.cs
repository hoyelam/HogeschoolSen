using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public class SizeAdjustableDecorator : ButtonDecorator
    {
        private int _height = 40;
        private int _width = 40;

        public SizeAdjustableDecorator(AbstractButton button) : base(button)
        {
        }

        public void AdjustHeight(int heightIncreaseBy)
        {
            _height += heightIncreaseBy;
        }

        public void AdjustWidth(int widthIncreaseBy)
        {
            _width += widthIncreaseBy;
        }

        public string GetHeight()
        {
            return _height.ToString();
        }

        public string GetWidth()
        {
            return _width.ToString();
        }
    }
}
