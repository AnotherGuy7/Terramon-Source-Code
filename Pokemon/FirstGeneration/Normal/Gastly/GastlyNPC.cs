using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Gastly
{
    public class GastlyNPC : ParentPokemonNPCFlying
    { public override string Texture => "Terramon/Pokemon/FirstGeneration/Normal/Gastly/Gastly";
        public override Type HomeClass()
        {
            return typeof(Gastly);
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
            if (spawnInfo.player.ZoneDungeon)
                return 0.07f;
            return 0f;
        }
    }
}
