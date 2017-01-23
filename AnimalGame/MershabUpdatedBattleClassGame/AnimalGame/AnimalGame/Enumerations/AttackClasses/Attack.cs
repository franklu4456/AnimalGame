using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    abstract class Attack
    {
        protected string _name;
        protected Type _attackType;
        protected AttackEffect _effect;
        protected bool _isDamageAttack;

        public Attack(Type attackType, AttackEffect effect, string name, bool isDamageAttack)
        {
            _attackType = attackType;
            _effect = effect;
            _name = name;
            _isDamageAttack = isDamageAttack;
        }

        public string Name
        {
            get
            {
                return _name;
            }
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

        public bool IsDamageAttack
        {
            get
            {
                return _isDamageAttack;
            }
        }
    }
}