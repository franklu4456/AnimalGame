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
        protected int _level;
        protected Type _species;

        protected Attack[] _attackArray = new Attack[3];


        public Animal(int maxHealth, int attack, int defense, int speed, Type species, int level,Attack attack1, Attack attack2, Attack attack3)
        {
            _maxHealth = maxHealth;
            _currentHealth = maxHealth;
            _attack = attack;
            _defense = defense;
            _speed = speed;
            _level = level;
            _species = species;
            _attackArray[0] = attack1;
            _attackArray[1] = attack2;
            _attackArray[2] = attack3;
        }

        public bool Evolve
        {
            get
            {
                if (_level >= 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Type Species
        {
            get
            {
                return _species;
            }
        }
        public int Level
        {
            set
            {
                _level = value;
            }
            get
            {
                return _level;
            }
        }
        

        public int Health
        {
            get
            {
                if (_currentHealth > _maxHealth)
                {
                    _currentHealth = _maxHealth;
                }
                return _currentHealth;
            }
            set
            {
                //change later!!
                _currentHealth = value;
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

        public int Speed
        {
            get
            {

                return _speed;
            }
        }

        public bool HasFainted
        {
            get
            {
                if (_currentHealth <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
    }

    
}
