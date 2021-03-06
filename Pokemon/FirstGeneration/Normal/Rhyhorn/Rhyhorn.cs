using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Rhyhorn
{
    public class Rhyhorn : ParentPokemon
    {
        public override int EvolveCost => 37;

        public override Type EvolveTo => typeof(Rhydon.Rhydon);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Ground, PokemonType.Rock };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}