using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class EvolvedWater:EvolvedAnimal
    {
        public EvolvedWater(int maxHealth, int attack, int defense, int speed, Type species, int level, Attack attack1, Attack attack2, Attack attack3)
            : base(maxHealth, attack, defense, speed, Type.Water, level, attack1, attack2, attack3)
        {

        }

        public override bool LearnSpecialMove()
        {
            DamageAttack superSoaker = new DamageAttack(Type.Water, AttackEffect.EnemyHealthDown, Level * 5, "Super Soaker");
            for (int i = 0; i < 3; i++)
            {
                if (_attackArray[i] is DamageAttack)
                {
                    _attackArray[i] = superSoaker;
                }
            }
            return true;
        }
        
    }
}
