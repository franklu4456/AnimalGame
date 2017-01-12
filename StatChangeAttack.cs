using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class StatChangeAttack : Attack
    {
        private Stat _statChangeValue;

        public StatChangeAttack(Type attackType, AttackEffect effect, Stat statChangeValue)
            : base(attackType, effect)
        {
            AttackType = attackType;
            Effect = effect;
        }

        public Stat StatChangeValue
        {
            get
            {
                return _statChangeValue;
            }
        }
    }
}
