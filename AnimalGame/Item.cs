using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Item
    {
        private string _name;
        private int _statNumber;
        private int _quantity;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int StatNumber
        {
            get
            {
                return _statNumber;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }

        public Item(string name, int statNumber, int quantity)
        {
            _name = name;
            _statNumber = statNumber;
            _quantity = quantity;
        }
    }
}
