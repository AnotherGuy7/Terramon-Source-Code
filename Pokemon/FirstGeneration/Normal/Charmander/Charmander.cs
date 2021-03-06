using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Charmander
{
    public class Charmander : ParentPokemon
    {
        public override int EvolveCost => 11;

        public override Type EvolveTo => typeof(Charmeleon.Charmeleon);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Fire };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}