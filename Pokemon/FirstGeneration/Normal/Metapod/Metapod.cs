using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Metapod
{
    public class Metapod : ParentPokemon
    {
        public override int EvolveCost => 3;

        public override Type EvolveTo => typeof(Butterfree.Butterfree);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Bug };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}