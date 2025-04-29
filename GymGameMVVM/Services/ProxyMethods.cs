using GymGame.Character;
using GymGame.Gym_Equipment_MEGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGame.Services
{
    public class ProxyMethods
    {
        public void DoArchery(Person _Person)
        {
            if (_Person.Dexterity < 10)
            {
                throw new Exception("Not Enough Dexterity");
            } 

            else
            {
                Archery temp = new Archery();
                temp.Training(_Person);
            }
        }

        public void DoSpeech(Person _Person)
        {
            if (_Person.Persistence < 10)
            {
                throw new Exception("Not Enough Persistence, turn on your sigma grindset.");
            }

            else
            {
                Speech temp = new Speech();
                temp.Training(_Person);
            }
        }

        public void DoTreadmill(Person _Person)
        {
            if (_Person.Cardio < 10)
            {
                throw new Exception("Not Enough Cardio");
            }

            else
            {
                Treadmill temp = new Treadmill();
                temp.Training(_Person);
            }
        }

        public void DoBenchpress(Person _Person)
        {
            if (_Person.Strength < 10)
            {
                throw new Exception("Not Enough Strength");
            }

            else
            {
                Benchpress temp = new Benchpress();
                temp.Training(_Person);
            }
        }
    }
}
