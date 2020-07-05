using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Exercise
{
    class Apple : Fruit
    {
        public string _color;
        public bool _pink_lady;

        public Apple(string color, bool pink_lady)
        {
            _color = color;
            _pink_lady = pink_lady;
        }

        public override bool Is_This_My_Favorite()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + " ," + "Fruit color: " + _color + " ," + "Is The apple pink lady?: " + _pink_lady;
        }
    }
}
