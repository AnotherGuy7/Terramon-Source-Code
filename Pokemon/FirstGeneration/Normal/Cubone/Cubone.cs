using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Cubone
{
    public class Cubone : ParentPokemon
    {
        public override int EvolveCost => 23;

        public override Type EvolveTo => typeof(Marowak.Marowak);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Ground };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}