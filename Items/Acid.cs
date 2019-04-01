using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items
{
    public class Acid : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Acid");
        }

        public override void SetDefaults() {
            item.width = 10;
            item.height = 10;
            item.MaxStack = 999;
            item.rare = 1;
            item.value = 50f;
        }

        public override void AddRecipe() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.JungleSpores, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}