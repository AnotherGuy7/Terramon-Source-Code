using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Seel
{
    public class Seel : ParentPokemon
    {
        public override int EvolveCost => 29;

        public override Type EvolveTo => typeof(Dewgong.Dewgong);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Water };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}