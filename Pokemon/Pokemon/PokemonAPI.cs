﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Results> results { get; set; }
    }

    public class Results
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Pokemonthing
    {
        public int id { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public Sprite sprites { get; set; }

        public override string ToString()
        {
            return $"Their id is {id}, height is {height}, weight is {weight} sucker";
        }
    }

    public class Sprite
    {
        public string front_default { get; set; }
        public string back_default { get; set; }
    }
}
