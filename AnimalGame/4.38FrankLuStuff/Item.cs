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
        private int _price;

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
            set
            {
                _quantity = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
        }

        public Item(string name, int statNumber, int quantity, int price)
        {
            _name = name;
            _statNumber = statNumber;
            _quantity = quantity;
            _price = price;
        }

        public void UsedAtkBuff(Animal currentAnimal, Item atkBuff)
        {
            currentAnimal.Attack = currentAnimal.Attack + atkBuff.StatNumber;
        }

        public void UsedDefBuff(Animal currentAnimal, Item defBuff)
        {
            currentAnimal.Defense = currentAnimal.Defense + defBuff.StatNumber;
        }

        public void UsedSpeedBuff(Animal currentAnimal, Item speedBuff)
        {
            currentAnimal.Speed = currentAnimal.Speed + speedBuff.StatNumber;
        }

        public Animal UsedNet(Animal enemy, bool inBattle)
        {
            if (inBattle == false)
            {
                Random numberGenerator = new Random();
                int randomChance = numberGenerator.Next(1, 11);

                if (enemy.Health > (enemy.MaxHealth / 2))
                {
                    if (randomChance <= 3)
                    {
                        return enemy;
                    }
                }
                else if (enemy.Health < (enemy.MaxHealth / 2) && enemy.Health >= (enemy.MaxHealth / 5))
                {
                    if (randomChance <= 5)
                    {
                        return enemy;
                    }
                }
                else if (enemy.Health < (enemy.MaxHealth / 5))
                {
                    if (randomChance <= 7)
                    {
                        return enemy;
                    }
                }
            }
            return null;
        }
    }
}
