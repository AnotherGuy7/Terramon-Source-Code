using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;

namespace Terramon.Pokemon.FirstGeneration.Normal.Magikarp
{
    public class MagikarpNPC : NotCatchablePKMN
    {
        public override Type HomeClass() => typeof(Magikarp);

        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.width = 20;
            npc.height = 20;
            npc.scale = 1f;
        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
        {
            npc.gfxOffY = 6;
            return true;
        }

        public override void AI()
        {
            if (Main.rand.Next(12) == 0)
            {
                Dust.NewDust(npc.position, npc.width, npc.height, 34, 0f, 0f, 100, default, 1f);
            }
        }
    }
}