﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class Pokemon
    {
        private string pokemonName;
        private string pokemonType;

        public Pokemon(string pokemonName, string pokemonType)
        {
            this.pokemonName = pokemonName;
            this.pokemonType = pokemonType;
        }

        public override string ToString()
        {
            return $"{this.pokemonName} {this.pokemonType}";
        }
    }
}
