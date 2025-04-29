using GymGame.Character;
using GymGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGame.Gym_Equipment_MEGA
{
    public class Archery : IGymEquipment
    {
        public void Training(Person _Person)
        {
            if (_Person.Dexterity == 100)
            {
                throw new Exception("Max Stats.");
            }

            else if (_Person.Dexterity >= 95) { _Person.Dexterity = 100; }

            else { _Person.Dexterity += 5; }

            Random rand = new Random();
            var temp = rand.Next(1, 10);

            if (temp * _Person.Dexterity > _Person.ArcheryPR)
            {
                _Person.ArcheryPR = temp * _Person.Dexterity;

                Console.WriteLine("Congradulations, your new Archery PR is: " + _Person.ArcheryPR);
            }

            else
            {
                Console.WriteLine("You failed to beat your PR.");
            }
        }
    }
}
