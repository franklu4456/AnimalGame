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

        public DamageAttack(Type attackType, AttackEffect effect, int damage, string name)
            : base(attackType, effect, name, true)
        {
            AttackType = attackType;
            Effect = effect;
            _damage = damage;
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
