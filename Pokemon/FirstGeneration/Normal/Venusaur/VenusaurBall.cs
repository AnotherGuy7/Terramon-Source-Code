using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Venusaur
{
    public class VenusaurBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pokéball (Venusaur)");
            Tooltip.SetDefault("Used to send out [c/33FF33:Venusaur!]"
            + "\n[c/B76FB7:Tier Three]");
        }

        public override void SetDefaults()
        {

            item.damage = 0;

            item.width = 24;
            item.height = 24;

            item.useTime = 20;
            item.useStyle = 1;
            item.useAnimation = 20;

            item.UseSound = SoundID.Item2;
            item.shoot = mod.ProjectileType("Venusaur");
            item.buffType = mod.BuffType("VenusaurBuff");
            item.accessory = false;

            item.noMelee = true;

            item.rare = 0;
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }

        public override void OnCraft(Recipe recipe)
        {
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/evolve").WithVolume(.7f));
            Main.NewText("[c/FFFF66:Bulbasaur evolved into Ivysaur!]");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BulbasaurBall"));
            recipe.AddIngredient(mod.ItemType("RareCandy"), 11);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}