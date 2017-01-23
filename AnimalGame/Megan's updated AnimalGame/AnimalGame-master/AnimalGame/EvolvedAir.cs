using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class EvolvedAir:EvolvedAnimal
    {
        public EvolvedAir(int maxHealth, int attack, int defense, int speed, Type species, int level)
            : base(maxHealth, attack, defense, speed, Type.Water, level)
        {

        }
        public override bool LearnSpecialMove()
        {

        }
    }
}
