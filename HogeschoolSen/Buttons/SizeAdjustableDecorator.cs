using HogeschoolSen.Visitor;
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

        public int GetHeight()
        {
            return _height;
        }

        public int GetWidth()
        {
            return _width;
        }

        public SizeAdjustableDecorator Accept(ISizeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
