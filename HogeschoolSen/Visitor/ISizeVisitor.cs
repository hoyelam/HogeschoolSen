using HogeschoolSen.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Visitor
{
    public interface ISizeVisitor
    {
        SizeAdjustableDecorator Visit(SizeAdjustableDecorator button);
    }
}
