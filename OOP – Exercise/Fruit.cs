using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Exercise
{
    abstract class Fruit
    {
        public string _name;
        public int _calories;

        public abstract bool Is_This_My_Favorite();

        public override string ToString()
        {
            return "Fruit name: " + _name + " ," + "Fruit calories: " + _calories; 
        }
    }
}
