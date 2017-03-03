using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Lecture1_Examples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //---------------------------------------------
            // Claim
            //---------------------------------------------
            Pokemon pokemon = new Pokemon();

            pokemon.Height = 2.0f;
            pokemon.Weight = 18.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            //---------------------------------------------

            Console.WriteLine("身高:{0}inch, 體重{1}lbs",
                pokemon.Height, pokemon.Weight);
        }
    }
}