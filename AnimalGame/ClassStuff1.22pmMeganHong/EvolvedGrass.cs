using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class EvolvedGrass:EvolvedAnimal
    {
        public EvolvedGrass(int maxHealth, int attack, int defense, int speed, Type species, int level, Attack attack1, Attack attack2, Attack attack3)
            : base(maxHealth, attack, defense, speed, Type.Water, level, attack1, attack2, attack3)
        {

        }

        public override bool LearnSpecialMove()
        {
            DamageAttack leafBlower = new DamageAttack(Type.Water, AttackEffect.EnemyHealthDown, Level * 4, "Leaf Blower");

            for (int i = 0; i < 3; i++)
            {
                if (_attackArray[i] is DamageAttack)
                {
                    _attackArray[i] = leafBlower;
                }
            }
            return true;
        } 

    
    }
}
