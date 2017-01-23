using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    /// <summary>
    /// IDK WHAT TO DO 
    /// </summary>
    class EvolvedAnimal:Animal
    {
        public EvolvedAnimal(int maxHealth, int attack, int defense, int speed, Type species, int level, Attack attack1, Attack attack2, Attack attack3)
            :base (maxHealth,attack,defense,speed,species, level, attack1,attack2, attack3)
        {

        }

        public abstract bool LearnSpecialMove
        {

        }

    }
}
