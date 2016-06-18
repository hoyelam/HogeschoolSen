using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public interface IButton
    {
        string getName();
        void SetName(string name);
        string GetColor();
        void SetColor(string color);
        void SetAction(string action);
        void DoAction();
    }
}
