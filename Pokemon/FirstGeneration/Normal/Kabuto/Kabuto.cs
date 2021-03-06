using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Kabuto
{
    public class Kabuto : ParentPokemon
    {
        public override int EvolveCost => 35;

        public override Type EvolveTo => typeof(Kabutops.Kabutops);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Rock, PokemonType.Water };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}