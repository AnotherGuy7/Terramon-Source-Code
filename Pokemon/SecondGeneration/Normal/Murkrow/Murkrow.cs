using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using Terramon.Pokemon.FourthGeneration.Normal.Honchkrow;

namespace Terramon.Pokemon.SecondGeneration.Normal.Murkrow
{
    public class Murkrow : ParentPokemon
    {
        public override int EvolveCost => 1;

        //public override EvolveItem EvolveItem => typeof(ItemID.LinkCable);
        
        public override Type EvolveTo => typeof(Honchkrow);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Dark, PokemonType.Flying };

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}