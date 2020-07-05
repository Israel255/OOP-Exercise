using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Exercise
{
    class Program
    {
        static void Apple_Color(Apple a)
        {
            Console.WriteLine("The apple color is: " + a._color);
        }

        static void Banana_Size(Banana b)
        {
            Console.WriteLine("The banana size is: " + b._size);
        }

        static void Fs_Clories(Fruit_Salad fs)
        {
            Console.WriteLine("Total calories is: " + fs.Get_Total_Calories());
        }

        static void My_Favorite_Is_Here(Fruit_Salad fs)
        {
            if (fs.Contains_My_Favorite_Fruit() == true)
            {
                Console.WriteLine("Youre favorite fruit is here");
            }
            else
            {
                Console.WriteLine("Youre favorite fruit not here");
            }
        }
        static void Main(string[] args)
        {
            Apple a = new Apple("red", false)
            {
                 _name = "Apple",
                 _calories = 52
            };
            a.Is_This_My_Favorite();
            Console.WriteLine(a);

            Banana b = new Banana(false, true, 100)
            {
                 _name = "Banana",
                 _calories = 89
            };
            b.Is_This_My_Favorite();
            Console.WriteLine(b);

            Orange o = new Orange(false, "Citrus")
            {
                _name = "Orange",
                _calories = 47
            };
            o.Is_This_My_Favorite();
            Console.WriteLine(o);

            Peach p = new Peach("Yellow", 8)
            {
                 _name = "Peach",
                 _calories = 39
            };
            p.Is_This_My_Favorite();
            Console.WriteLine(p);

            Fruit_Salad fs = new Fruit_Salad
            {
                _fruits = new Fruit[4]
                {
                    a,
                    b,
                    o,
                    p
                }
            };
            fs.Get_Total_Calories();
            fs.Contains_My_Favorite_Fruit();
            Console.WriteLine(fs);

            Apple_Color(a);
            Banana_Size(b);
            Fs_Clories(fs);
            My_Favorite_Is_Here(fs);
        }
    }
}
