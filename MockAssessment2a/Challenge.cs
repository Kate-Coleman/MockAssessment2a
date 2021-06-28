using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment2a
{
    public class Challenge
    {
        // Challenge 1
        static int AddStarWarsCharacters(string yodaString)
        {
            int yodaIndex = yodaString.IndexOf("Yoda");

            return yodaIndex;
        }
        // Challenge 2
        static string DeathStarCombat(Dictionary<string, int> SWChars)
        {
            double max = SWChars.Max(kvp => kvp.Value);
            return SWChars.Where(kvp => kvp.Value == max).Select(kvp => kvp.Key).First();

        }
        //Challenge 3
        static List<string> ConvertPlanets(string[] planetArray)
        {
            return planetArray.Reverse().ToList();
        }
        //Challenge 4
        static double AverageDroids(List<int> droids)
        {
            var evenDroids = (from m in droids
                              where m % 2 == 0
                              select m).ToList();

            return evenDroids.Average();
        }
        //Challenge 5
        static string TryToCatchDarthVader(string vader)
        {
            try
            {
                int.Parse(vader);
                return "Vader Was Captured!";

            }
            catch
            {
                return "Vader got away!";
            }
        }
        public Challenge()
        {

        }
    }
}
