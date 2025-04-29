using GymGame.Character;
using GymGame.Gym_Equipment;
using GymGame.Services;
using System;


namespace GymGame
{


    class Program
    {
        public static void Main()
        {
            Person char1 = new Person();
            char1.PrintStats();

            ProxyMethods methods = new ProxyMethods();
            Dumbells dumbells = new Dumbells();
            Jog jog = new Jog();

            dumbells.Training(char1);

            char1.PrintStats();
            
        }
    }
}