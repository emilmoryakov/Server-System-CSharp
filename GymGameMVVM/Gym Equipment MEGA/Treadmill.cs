using GymGame.Character;
using GymGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGame.Gym_Equipment_MEGA
{
    public class Treadmill : IGymEquipment
    {
        public void Training(Person _Person)
        {
            if (_Person.Cardio == 100)
            {
                throw new Exception("Max Stats.");
            }

            else if (_Person.Cardio >= 95) { _Person.Cardio = 100; }

            else { _Person.Cardio += 5; }

            Random rand = new Random();
            var temp = rand.Next(1, 10);

            if (temp * _Person.Cardio > _Person.RunningPR)
            {
                _Person.RunningPR = temp * _Person.RunningPR;

                Console.WriteLine("Congradulations, your new Running PR is: " + _Person.RunningPR);
            }

            else
            {
                Console.WriteLine("You failed to beat your PR.");
            }
        }
    }
}
