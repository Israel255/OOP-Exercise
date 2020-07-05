using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Exercise
{
    class Banana : Fruit
    {
        public bool _has_black_spots;
        public bool _is_green;
        public float _size;

        public Banana(bool has_black_spots, bool is_green, float size)
        {
            _has_black_spots = has_black_spots;
            _is_green = is_green;
            _size = size;
        }

        public override bool Is_This_My_Favorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + " ," + "Has black spots?: " + _has_black_spots + " ," + "Is green?: " + _is_green + " ," + "Fruit size: " + _size;
        }
    }
}
