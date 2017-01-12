using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    abstract class Attack
    {
        protected Type _attackType;
        protected AttackEffect _effect;

        public Attack(Type attackType, AttackEffect effect)
        {
            AttackType = attackType;
            Effect = effect;
        }

        public Type AttackType
        {
            get
            {
                return _attackType;
            }
            set
            {
                _attackType = value;
            }
        }

        public AttackEffect Effect
        {
            get
            {
                return _effect;
            }
            set
            {
                _effect = value;
            }
        }
    }
}
