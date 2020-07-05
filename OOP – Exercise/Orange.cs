using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Exercise
{
    class Orange : Fruit
    {
        public bool _chinese;
        public string _fruit_type;

        public Orange(bool chinese, string fruit_type)
        {
            _chinese = chinese;
            _fruit_type = fruit_type;
        }

        public override bool Is_This_My_Favorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + " ," + "Is the Orange chinese?: " + _chinese + " ," + "Fruit type: " + _fruit_type;
        }
    }
}
