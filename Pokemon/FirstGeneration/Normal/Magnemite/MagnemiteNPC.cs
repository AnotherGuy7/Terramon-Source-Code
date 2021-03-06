using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Magnemite
{
    public class MagnemiteNPC : ParentPokemonNPCFlying
    { public override string Texture => "Terramon/Pokemon/FirstGeneration/Normal/Magnemite/Magnemite";
        public override Type HomeClass()
        {
            return typeof(Magnemite);
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.width = 20;
            npc.height = 20;
            npc.scale = 1f;
        }



        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = Main.LocalPlayer;
            if (spawnInfo.player.ZoneGlowshroom)
                return 0.06f;
            return 0f;
        }
    }
}
