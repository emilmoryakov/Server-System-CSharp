using GymGame.Character;
using GymGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGame.Gym_Equipment
{
    public class Jog : IGymEquipment
    {
        public void Training(Person _Person)
        {
            if (_Person.Cardio == 100)
            {
                throw new Exception("Max Level Reached");
            }

            else { _Person.Cardio += 1; }
        }
    }
}
