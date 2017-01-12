using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class DamageAttack : Attack
    {
        private int _damage;

        public DamageAttack(Type attackType, AttackEffect effect, int damage)
            : base(attackType, effect)
        {
            AttackType = attackType;
            Effect = effect;
        }

        public int Damage
        {
            get
            {
                return _damage;
            }
        }
    }
}
