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

            const int STAT_BUFF = 50;

            if (PlayerAnimals.First().Speed > EnemyAnimals.First().Speed)
            {
                if (PlayerAnimals.First().AttackArray[selectionNumber].IsDamageAttack)
                {
                    //Player Calculation
                    DamageAttack selectedAttack = (DamageAttack)PlayerAnimals.First().AttackArray[selectionNumber];

                    int damageCalculation = (int)(selectedAttack.Damage*(PlayerAnimals.First().Attack*0.2));

                    message = PlayerAnimals.First().Species.ToString() + "just attacked " + EnemyAnimals.First().Species.ToString() + "for " + damageCalculation + "damage";

                    if (EnemyAnimals.First().Health <= damageCalculation)
                    {
                        EnemyAnimals.First().Health -= damageCalculation;
                        PlayerAnimals.First().Level += 1;
                        SwitchEnemyAnimal();
                    }
                    else
                    {
                        EnemyAnimals.First().Health -= damageCalculation;

                        //Enemy Attack

                        Random rng = new Random();

                        int enemySelectedAttack = rng.Next(0, 4);

                        if (EnemyAnimals.First().AttackArray[enemySelectedAttack].IsDamageAttack)
                        {
                            DamageAttack enemyDamageAttack = (DamageAttack)EnemyAnimals.First().AttackArray[enemySelectedAttack];

                            int enemyDamageCalculation = (int)(enemyDamageAttack.Damage * (EnemyAnimals.First().Attack * 0.2));

                            if (PlayerAnimals.First().Health <= enemyDamageCalculation)
                            {
                                PlayerAnimals.First().Health -= enemyDamageCalculation;
                                SwitchAnimal();
                            }
                            else
                                PlayerAnimals.First().Health -= enemyDamageCalculation;
                        }
                        else
                        {
                            StatChangeAttack enemyStatAttack = (StatChangeAttack)EnemyAnimals.First().AttackArray[enemySelectedAttack];

                            if (enemyStatAttack.StatChangeValue == Stat.Attack)
                            {
                                EnemyAnimals.First().Attack += STAT_BUFF;
                            }
                            else if (enemyStatAttack.StatChangeValue == Stat.CurrentHealth)
                            {
                                EnemyAnimals.First().Health += STAT_BUFF;
                            }
                            else if (enemyStatAttack.StatChangeValue == Stat.Defense)
                            {
                                EnemyAnimals.First().Defense += STAT_BUFF;
                            }
                            else if (enemyStatAttack.StatChangeValue == Stat.Speed)
                            {
                                EnemyAnimals.First().Speed += STAT_BUFF;
                            }
                        }
                    }
                }
                else
                {
                    StatChangeAttack selectedAttack = (StatChangeAttack)PlayerAnimals.First().AttackArray[selectionNumber];

                    if (selectedAttack.StatChangeValue == Stat.Attack)
                    {
                        PlayerAnimals.First().Attack += STAT_BUFF;
                    }
                    else if (selectedAttack.StatChangeValue == Stat.CurrentHealth)
                    {
                        PlayerAnimals.First().Health += STAT_BUFF;
                    }
                    else if (selectedAttack.StatChangeValue == Stat.Defense)
                    {
                        PlayerAnimals.First().Defense += STAT_BUFF;
                    }
                    else if (selectedAttack.StatChangeValue == Stat.Speed)
                    {
                        PlayerAnimals.First().Speed += STAT_BUFF;
                    }

                    Random rng = new Random();

                    int enemySelectedAttack = rng.Next(0, 4);

                    if (EnemyAnimals.First().AttackArray[enemySelectedAttack].IsDamageAttack)
                    {
                        DamageAttack enemyDamageAttack = (DamageAttack)EnemyAnimals.First().AttackArray[enemySelectedAttack];

                        int enemyDamageCalculation = (int)(enemyDamageAttack.Damage * (EnemyAnimals.First().Attack * 0.2));

                        if (PlayerAnimals.First().Health <= enemyDamageCalculation)
                        {
                            PlayerAnimals.First().Health -= enemyDamageCalculation;
                            SwitchAnimal();
                        }
                        else
                            PlayerAnimals.First().Health -= enemyDamageCalculation;
                    }
                    else
                    {
                        StatChangeAttack enemyStatAttack = (StatChangeAttack)EnemyAnimals.First().AttackArray[enemySelectedAttack];

                        if (enemyStatAttack.StatChangeValue == Stat.Attack)
                        {
                            EnemyAnimals.First().Attack += STAT_BUFF;
                        }
                        else if (enemyStatAttack.StatChangeValue == Stat.CurrentHealth)
                        {
                            EnemyAnimals.First().Health += STAT_BUFF;
                        }
                        else if (enemyStatAttack.StatChangeValue == Stat.Defense)
                        {
                            EnemyAnimals.First().Defense += STAT_BUFF;
                        }
                        else if (enemyStatAttack.StatChangeValue == Stat.Speed)
                        {
                            EnemyAnimals.First().Speed += STAT_BUFF;
                        }
                    }
                }
            }
            else
            {
                //Enemy Attack

                Random rng = new Random();

                int enemySelectedAttack = rng.Next(0, 4);

                if (EnemyAnimals.First().AttackArray[enemySelectedAttack].IsDamageAttack)
                {
                    DamageAttack enemyDamageAttack = (DamageAttack)EnemyAnimals.First().AttackArray[enemySelectedAttack];

                    int enemyDamageCalculation = (int)(enemyDamageAttack.Damage * (EnemyAnimals.First().Attack * 0.2));

                    if (PlayerAnimals.First().Health <= enemyDamageCalculation)
                    {
                        PlayerAnimals.First().Health -= enemyDamageCalculation;
                        SwitchAnimal();
                    }
                    else
                    {
                        PlayerAnimals.First().Health -= enemyDamageCalculation;

                        if (PlayerAnimals.First().AttackArray[selectionNumber].IsDamageAttack)
                        {
                            //Player Calculation
                            DamageAttack selectedAttack = (DamageAttack)PlayerAnimals.First().AttackArray[selectionNumber];

                            int damageCalculation = (int)(selectedAttack.Damage * (PlayerAnimals.First().Attack * 0.2));

                            message = PlayerAnimals.First().Species.ToString() + "just attacked " + EnemyAnimals.First().Species.ToString() + "for " + damageCalculation + "damage";

                            if (EnemyAnimals.First().Health <= damageCalculation)
                            {
                                EnemyAnimals.First().Health -= damageCalculation;
                                PlayerAnimals.First().Level += 1;
                                SwitchEnemyAnimal();
                            }
                            else
                                EnemyAnimals.First().Health -= damageCalculation;
                        }
                        else
                        {
                            StatChangeAttack selectedAttack = (StatChangeAttack)PlayerAnimals.First().AttackArray[selectionNumber];

                            if (selectedAttack.StatChangeValue == Stat.Attack)
                            {
                                PlayerAnimals.First().Attack += STAT_BUFF;
                            }
                            else if (selectedAttack.StatChangeValue == Stat.CurrentHealth)
                            {
                                PlayerAnimals.First().Health += STAT_BUFF;
                            }
                            else if (selectedAttack.StatChangeValue == Stat.Defense)
                            {
                                PlayerAnimals.First().Defense += STAT_BUFF;
                            }
                            else if (selectedAttack.StatChangeValue == Stat.Speed)
                            {
                                PlayerAnimals.First().Speed += STAT_BUFF;
                            }
                        }
                        
                    }
                }
                else
                {
                    StatChangeAttack enemyStatAttack = (StatChangeAttack)EnemyAnimals.First().AttackArray[enemySelectedAttack];

                    if (enemyStatAttack.StatChangeValue == Stat.Attack)
                    {
                        EnemyAnimals.First().Attack += STAT_BUFF;
                    }
                    else if (enemyStatAttack.StatChangeValue == Stat.CurrentHealth)
                    {
                        EnemyAnimals.First().Health += STAT_BUFF;
                    }
                    else if (enemyStatAttack.StatChangeValue == Stat.Defense)
                    {
                        EnemyAnimals.First().Defense += STAT_BUFF;
                    }
                    else if (enemyStatAttack.StatChangeValue == Stat.Speed)
                    {
                        EnemyAnimals.First().Speed += STAT_BUFF;
                    }
                }
            }

            return true;
        }

        //Finish me
        public bool SwitchAnimal()
        {

        }

        public void SwitchEnemyAnimal()
        {

        }

        

    }
}
