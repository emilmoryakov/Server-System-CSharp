using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGame.Character
{
    public class Person
    {
        public int Strength { get; set; }
        public int Cardio { get; set; }
        public int Persistence { get; set; }
        public int Dexterity { get; set; }

        public int BenchPR { get; set; }
        public int RunningPR { get; set; }
        public int FanAmount { get; set; }
        public int ArcheryPR { get; set; }

        public Person()
        {
            Random random = new Random();
            Strength = random.Next(1, 100);
            Cardio = random.Next(1, 100);
            Persistence = random.Next(1, 100);
            Dexterity = random.Next(1, 100);

            BenchPR = 0;
            RunningPR = 0;
            FanAmount = 0;
            ArcheryPR = 0;
        }

        public void PrintStats()
        {
            string characterLevel = "";

            if (Strength == 100 || Cardio == 100 || Persistence == 100 || Dexterity == 100)
            {
                characterLevel = "Greek God";
            }

            else if (Strength > 90 || Cardio > 90 || Persistence > 90 || Dexterity > 90)
            {
                characterLevel = "Steroids";
            }


            else if (Strength > 70 || Cardio > 70 || Persistence > 70 || Dexterity > 70)
            {
                characterLevel = "Ripped";
            }

            else if (Strength > 50 || Cardio > 50 || Persistence > 50 || Dexterity > 50)
            {
                characterLevel = "Naturally Strong";
            }

            else if (Strength > 30 || Cardio > 30 || Persistence > 30 || Dexterity > 30)
            {
                characterLevel = "Average Joe";
            }

            else if (Strength > 15 || Cardio > 15 || Persistence > 15 || Dexterity > 15)
            {
                characterLevel = "Stick Man";
            }

            else { characterLevel = "xQc"; }



            Console.WriteLine(
                $"Your character Stats:\n\n" +
                $"Strength: {Strength}\n" +
                $"--------------------\n" +
                $"Cardio: {Cardio}\n" +
                $"--------------------\n" +
                $"Persistence: {Persistence}\n" +
                $"--------------------\n" +
                $"Dexterity: {Dexterity}\n" +
                $"--------------------\n\n" +
                $"Bench press PR: {BenchPR}\n" +
                $"--------------------\n" +
                $"Running PR: {RunningPR}\n" +
                $"--------------------\n" +
                $"Fans: {FanAmount}\n" +
                $"--------------------\n" +
                $"Archery PR: {ArcheryPR}\n" +
                $"--------------------\n\n" +
                $"Character Level: {characterLevel}\n");

        }
    }
}
