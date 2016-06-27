using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen
{
    public class ColorFactory
    {
        public Color MakeColor(string color)
        {
            switch (color)
            {
                case "Yellow":
                    return Color.Yellow;
                case "Red":
                    return Color.Red;
                case "Blue":
                    return Color.Blue;
                default:
                    return Color.White;
            }
            
        }
    }
}
