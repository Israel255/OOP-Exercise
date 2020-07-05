using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Exercise
{
    class Peach : Fruit
    {
        public string _color;
        public float _diameter;

        public Peach(string color, float diameter)
        {
            _color = color;
            _diameter = diameter;
        }

        public override bool Is_This_My_Favorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + " ," + "Fruit color: " + _color + " ," + "Fruit diameter: " + _diameter;
        }
    }
}
