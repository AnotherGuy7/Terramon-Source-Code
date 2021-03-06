using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Tentacool
{
    public class Tentacool : ParentPokemon
    {
        public override int EvolveCost => 25;

        public override Type EvolveTo => typeof(Tentacruel.Tentacruel);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Water, PokemonType.Poison };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}