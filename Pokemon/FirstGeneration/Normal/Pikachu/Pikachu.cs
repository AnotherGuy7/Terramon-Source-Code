using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Pikachu
{
    public class Pikachu : ParentPokemon
    {
        public override int EvolveCost => 16;

        public override Type EvolveTo => typeof(Raichu.Raichu);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Electric };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}