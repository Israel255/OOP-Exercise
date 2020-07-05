using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Exercise
{
    class Fruit_Salad
    {
        public Fruit[] _fruits;

        public int Get_Total_Calories()
        {
            int total_calories = 0;
            for (int i = 0; i < _fruits.Length; i++)
            {
                total_calories += _fruits[i]._calories;
            }
            return total_calories;
        }

        public bool Contains_My_Favorite_Fruit()
        {
            bool are_you_there = false;
            for (int i = 0; i < _fruits.Length; i++)
            {
                if (_fruits[i].Is_This_My_Favorite() == true)
                {
                    are_you_there = true;
                    break;
                }
                else
                {
                    are_you_there = false;
                }
            }
            return are_you_there;
        }

        public override string ToString()
        {
            for (int i = 0; i < _fruits.Length; i++)
            {
                Console.WriteLine("Fruit number" + " " + (i + 1) + ":" + _fruits[i]._name);
            }
            return "Total calories: " + Get_Total_Calories() + " ," + "My favorite fruit is there?: " + Contains_My_Favorite_Fruit();
        }
    }
}
