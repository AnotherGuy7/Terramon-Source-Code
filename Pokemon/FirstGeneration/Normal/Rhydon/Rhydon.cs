using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Rhydon
{
    public class Rhydon : ParentPokemon
    {
        

        

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Ground, PokemonType.Rock };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}