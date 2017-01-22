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
        private Stat _statEffect;

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

        public Stat StatEffect
        {
            get
            {
                return _statEffect;
            }
        }

        public Item(string name, int statNumber, int quantity, int price, Stat statEffect)
        {
            _name = name;
            _statNumber = statNumber;
            _quantity = quantity;
            _price = price;
            _statEffect = statEffect;
        }

        public void UsedBuff(Item buff, Animal currentAnimal)
        {
            if (buff.StatEffect == Stat.Attack)
            {
                currentAnimal.Attack = currentAnimal.Attack + buff.StatNumber;
                buff.Quantity--;
            }
            else if (buff.StatEffect == Stat.Defense)
            {
                currentAnimal.Defense = currentAnimal.Defense + buff.StatNumber;
                buff.Quantity--;
            }
            else if (buff.StatEffect == Stat.Speed)
            {
                currentAnimal.Speed = currentAnimal.Speed + buff.StatNumber;
                buff.Quantity--;
            }
            else if (buff.StatEffect == Stat.Heal)
            {
                currentAnimal.Health = currentAnimal.Health + buff.StatNumber;
                buff.Quantity--;
            }
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
