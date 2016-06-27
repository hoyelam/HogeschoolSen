using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Buttons
{
    public class AbstractButton : IButton
    {
        private string _name;
        private string _color;
        private string _action;
        private Vector2 _position;

        public string getName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public void SetAction(string action)
        {
            _action = action;
        }

        public void DoAction()
        {
            Console.WriteLine("Button " + _name + " does action " + _action);
        }

        public Vector2 GetVector()
        {
            return _position;
        }

        public void SetVector(Vector2 vector)
        {
            _position = vector;
        }
    }
}
