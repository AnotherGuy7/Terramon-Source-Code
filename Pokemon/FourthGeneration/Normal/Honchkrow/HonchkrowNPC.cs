using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FourthGeneration.Normal.Honchkrow
{
    public class HonchkrowNPC : ParentPokemonNPC
    { public override string Texture => "Terramon/Pokemon/FourthGeneration/Normal/Honchkrow/Honchkrow";
        public override Type HomeClass()
        {
            return typeof(Honchkrow);
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.width = 20;
            npc.height = 20;
            npc.scale = 1f;
        }

public static bool PlayerIsInForest(Player player){
	return !player.ZoneJungle
		&& !player.ZoneDungeon
		&& !player.ZoneCorrupt
		&& !player.ZoneCrimson
		&& !player.ZoneHoly
		&& !player.ZoneSnow
		&& !player.ZoneUndergroundDesert
		&& !player.ZoneGlowshroom
		&& !player.ZoneMeteor
		&& !player.ZoneBeach
		&& !player.ZoneDesert
		&& player.ZoneOverworldHeight;
}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = Main.LocalPlayer;
            if (PlayerIsInForest(player) && !Main.dayTime)
                return 0f;
            return 0f;
        }
    }
}
