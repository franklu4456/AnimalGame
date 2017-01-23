using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class EvoledRock:EvolvedAnimal
    {
        public EvoledRock(int maxHealth, int attack, int defense, int speed, Type species, int level, Attack attack1, Attack attack2, Attack attack3)
            : base(maxHealth, attack, defense, speed, Type.Water, level, attack1, attack2, attack3)
        {

        }

        public override bool LearnSpecialMove()
        {
            DamageAttack pebbleToss = new DamageAttack(Type.Rock, AttackEffect.EnemyHealthDown, Level * 5, "Pebble Toss");
            for (int i = 0; i < 3; i++)
            {
                if (_attackArray[i] is DamageAttack)
                {
                    _attackArray[i] = pebbleToss;
                }
            }
            return true;
        }
    }
}
