using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Psyduck
{
    public class Psyduck : ParentPokemon
    {
        public override int EvolveCost => 28;

        public override Type EvolveTo => typeof(Golduck.Golduck);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Water };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}