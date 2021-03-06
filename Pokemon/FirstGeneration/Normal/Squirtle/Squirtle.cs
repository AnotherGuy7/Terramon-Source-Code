using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Squirtle
{
    public class Squirtle : ParentPokemon
    {
        public override int EvolveCost => 11;

        public override Type EvolveTo => typeof(Wartortle.Wartortle);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Water };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}