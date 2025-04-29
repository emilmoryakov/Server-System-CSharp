using GymGame.Character;
using GymGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGame.Gym_Equipment_MEGA
{
    public class Benchpress : IGymEquipment
    {
        public void Training(Person _Person)
        {
            if (_Person.Strength == 100)
            {
                throw new Exception("Max Stats.");
            }

            else if (_Person.Strength >= 95) { _Person.Strength = 100; }

            else { _Person.Strength += 5; }

            Random rand = new Random();
            var temp = rand.Next(1, 10);

            if (temp * _Person.Strength > _Person.BenchPR)
            {
                _Person.BenchPR = temp * _Person.Strength;

                Console.WriteLine("Congradulations, your new Running PR is: " + _Person.BenchPR);
            }

            else
            {
                Console.WriteLine("You failed to beat your PR.");
            }
        }
    }
}
