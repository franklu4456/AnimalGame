using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Battle
    {
        private List<Animal> _playerAnimals, _enemyAnimals;

        private List<Item> _playerItems, _enemyItems;

        private bool _win, _isDead, _isWild, _isAttacking;

        string message;

        public bool Win
        {
            get
            {
                return _win;
            }
            set
            {
                _win = value;
            }
        }

        public bool IsDead
        {
            get
            {
                return IsDead;
            }
            set
            {
                IsDead = value;
            }
        }

        public bool IsWild
        {
            get
            {
                return _isWild;
            }
            set
            {
                _isWild = value;
            }
        }

        public List<Animal> PlayerAnimals
        {
            get
            {
                return _playerAnimals;
            }
            set
            {
                _playerAnimals = value;
            }
        }

        public List<Animal> EnemyAnimals
        {
            get
            {
                return _enemyAnimals;
            }
            set
            {
                _enemyAnimals = value;
            }
        }

        public List<Item> PlayerItems
        {
            get
            {
                return _playerItems;
            }
            set
            {
                _playerItems = value;
            }
        }

        public List<Item> EnemyItems
        {
            get
            {
                return _enemyItems;
            }
            set
            {
                _enemyItems = value;
            }
        }



        public Battle(List<Animal> playerAnimals, List<Animal> enemyAnimals, List<Item> playerItems, List<Item> enemyItems, bool IsWild)
        {
            PlayerAnimals = playerAnimals;
            EnemyAnimals = enemyAnimals;
            PlayerItems = playerItems;
            EnemyItems = enemyItems;
            _isWild = IsWild;
        }

        
        public bool Fight(int selectionNumber)
        {
            if (PlayerAnimals.First().AttackArray[selectionNumber] is DamageAttack)
            {
                DamageAttack selectedAttack = (DamageAttack)PlayerAnimals.First().AttackArray[selectionNumber];

                if (PlayerAnimals.First().Speed > EnemyAnimals.First().Speed)
                {
                    
                }
            }
            else
            {
                StatChangeAttack selectedAttack = (StatChangeAttack)PlayerAnimals.First().AttackArray[selectionNumber];
            }


            

        }

        

    }
}
