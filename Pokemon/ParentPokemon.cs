﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.FirstGeneration.Normal.Bulbasaur;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Terramon.Pokemon
{
    public abstract class ParentPokemon : ModProjectile
    {
        public override string Texture => "Terramon/Pokemon/Empty";

        /// <summary>
        ///     Next stage pokemon to evolve.
        ///     If value == null => mon can't evolve
        /// </summary>
        public virtual Type EvolveTo { get; } = null;

        /// <summary>
        ///     How much candies need to evolve.
        /// </summary>
        public virtual int EvolveCost { get; } = 0;

        /// <summary>
        ///     Item what used for evolution
        /// </summary>
        public virtual EvolveItem EvolveItem { get; } = EvolveItem.RareCandy;

        /// <summary>
        ///     Just for checking if this mon can evolve or not
        /// </summary>
        public bool CanEvolve => EvolveTo != null && EvolveCost != 0;

        public virtual PokemonType[] PokemonTypes => new[] {PokemonType.Normal};

        public virtual string[] DefaultMove => new[] {"", "", "", ""};

        private string iconName;

        public int SpawnTime = 0;
        public virtual string IconName => iconName ?? (iconName = $"Terramon/Minisprites/Regular/mini{GetType().Name}");

        public int AttackDuration;

        public bool shiny = false;

        public int frame;
        public int frameCounter;


        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 2;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Puppy);
            aiType = ProjectileID.Puppy;
            projectile.owner = Main.myPlayer;
            drawOffsetX = 100;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
        {
            var arr = GetType().Namespace.Split('.');
            string path = String.Empty;
            for (int i = 1; i < arr.Length && i < 4; i++)// We skip "Terramon" at 0 pos
            {
                path += path.Length > 0 ? $"/{arr[i]}" : arr[i];
            }
            path += $"/{projectile.Name}/{projectile.Name}";
            if (shiny)
            {
                path += "_Shiny";
            }
            SpriteEffects effects = projectile.spriteDirection == -1 ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
            Texture2D pkmnTexture = mod.GetTexture(path);
            int frameHeight = pkmnTexture.Height / Main.projFrames[projectile.type];
            spriteBatch.Draw(pkmnTexture, projectile.position - Main.screenPosition + new Vector2(14, 0), new Rectangle(0, frameHeight * frame, pkmnTexture.Width, frameHeight), drawColor, projectile.rotation, new Vector2(pkmnTexture.Width / 2f, frameHeight / 2), projectile.scale, effects, 0f);
            return true;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false; // Relic from aiType
            if (aiType != 0)
                mainAi = aiType;
            return true;
        }

        private int mainAi = ProjectileID.Puppy;
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            TerramonPlayer modPlayer = player.GetModPlayer<TerramonPlayer>();

            if (modPlayer.ActivePetShiny)
            {
                shiny = true;
            } else
            {
                shiny = false;
            }

            //Animations

            projectile.spriteDirection = projectile.velocity.X > 0 ? -1 : (projectile.velocity.X < 0 ? 1 : projectile.spriteDirection);

            if (projectile.velocity.X != 0 || projectile.velocity.Y > 1)
            {
                frameCounter++;
                if (frameCounter > 15)
                {
                    frame += 1;
                    frameCounter = 0;
                    if (frame >= Main.projFrames[projectile.type])
                    {
                        frame = 0;
                    }
                }
            }
            else
            {
                frame = 1;
                frameCounter = 0;
            }

            SpawnTime++;
            if (SpawnTime == 1)
            {
                if (player.direction == -1) // direction right
                {
                    projectile.direction = -1;
                }
                else
                {
                    projectile.direction = 1;
                }
                if(!Main.dedServ)
                    Main.PlaySound(ModContent.GetInstance<TerramonMod>().GetLegacySoundSlot(SoundType.Custom, "Sounds/Cries/Kanto/cry" + projectile.Name).WithVolume(0.55f));
                
                for (int i = 0; i < 18; i++)
                {
                    Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("SmokeTransformDust"));
                }
            }

            if (player.dead)
            {
                modPlayer.ResetEffects();
                modPlayer.ActivePetId = -1;
            }

            if (modPlayer.IsPetActive(GetType().Name)) projectile.timeLeft = 2;

            if (modPlayer.ActiveMove != null)
            {
                if (modPlayer.ActiveMove.OverrideAI(projectile, this, modPlayer))
                    aiType = 0;
            }
            else if (aiType == 0)
            {
                aiType = mainAi;
            }

            if (modPlayer.Attacking)
            {
                AttackDuration++;
                if (AttackDuration < 60)
                {
                    if (projectile.type == ModContent.ProjectileType<Bulbasaur>())
                    {
                        Projectile.NewProjectile(projectile.position.X + 23, projectile.position.Y + 8, 0f, 0f, ModContent.ProjectileType<AngerOverlay>(), 0, 0, Main.myPlayer);
                    }
                    AttackDuration = 0;
                }
                else
                {
                    // dont make any more.
                }
            }
            else
            {

            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Player player = Main.player[projectile.owner];
            if (SpawnTime <= 6)
            {
                projectile.position = player.position;
            }
            return true;
        }
    }

    public enum PokemonType
    {
        Bug,
        Dark,
        Dragon,
        Electric,
        Fairy,
        Fighting,
        Fire,
        Flying,
        Ghost,
        Grass,
        Ground,
        Ice,
        Normal,
        Poison,
        Psychic,
        Rock,
        Steel,
        Water,
        Nuclear,
        Light,
        Machine,
        Sound
    }

    public enum EvolveItem
    {
        RareCandy,
        LinkCable
    }
}