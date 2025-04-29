using GymGame.Character;
using GymGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGame.Gym_Equipment_MEGA
{
    public class Speech : IGymEquipment
    {
        public void Training(Person _Person)
        {
            if (_Person.Persistence == 100)
            {
                throw new Exception("Max Stats.");
            }

            else if(_Person.Persistence >= 95) { _Person.Persistence = 100; }

            else { _Person.Persistence += 5; }

            Random rand = new Random();
            var temp = _Person.FanAmount = rand.Next(10, 1000) * _Person.FanAmount;

            if (temp > _Person.FanAmount)
            {
                _Person.FanAmount = temp * _Person.Persistence;

                Console.WriteLine("Congradulations, your new Fan Amount is: " + _Person.FanAmount);
            }

            else
            {
                Console.WriteLine("You failed to beat your PR.");
            }

        }
    }
}
