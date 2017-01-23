using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class EvolvedFire:EvolvedAnimal
    {
        public EvolvedFire(int maxHealth, int attack, int defense, int speed, Type species, int level, Attack attack1, Attack attack2, Attack attack3)
            : base(maxHealth, attack, defense, speed, Type.Water, level, attack1, attack2, attack3)
        {

        }
        public override bool LearnSpecialMove()
        {
            DamageAttack fireArm = new DamageAttack(Type.Fire, AttackEffect.EnemyHealthDown, Level * 6, "Fire Arms");
            for (int i = 0; i < 3; i++)
            {
                if (_attackArray[i] is DamageAttack)
                {
                    _attackArray[i] = fireArm;
                }
            }
            return true;
        }
    }
}
