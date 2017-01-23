using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Animal
    {
        protected int _maxHealth;
        protected int _currentHealth;
        protected int _attack;
        protected int _defense;
        protected int _speed;
        protected bool _hasFainted;
        protected int _level;

        // Did we miss it
        protected string _species;

        //protected Attack<list> attacks;

        public Animal(int maxHealth, int attack, int defense, int speed, string species)
        {
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
            _attack = attack;
            _defense = defense;
            _speed = speed;
            _hasFainted = false;
            _level = 1;
            _species = species;
        }

        public int Health
        {
            get
            {
                // Should we check hasFainted
                return _currentHealth;
            }
        }

        public int Attack
        {
            get
            {
                return _attack;
            }
        }

        public int Defense
        {
            get
            {
                return _defense;
            }
        }

        public bool HasFainted
        {
            get
            {
                return _hasFainted;
            }
        }
        
    }

    
}
