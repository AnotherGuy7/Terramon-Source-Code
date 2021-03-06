using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Bellsprout
{
    public class Bellsprout : ParentPokemon
    {
        public override int EvolveCost => 16;

        public override Type EvolveTo => typeof(Weepinbell.Weepinbell);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Grass, PokemonType.Poison };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}