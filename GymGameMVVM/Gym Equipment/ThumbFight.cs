using GymGame.Character;
using GymGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGame.Gym_Equipment
{
    public class ThumbFight : IGymEquipment
    {
        public void Training(Person _Person)
        {
            if (_Person.Dexterity >= 95)
            {
                _Person.Dexterity = 100;
            }

            else { _Person.Dexterity += 1; }
        }
    }
}
