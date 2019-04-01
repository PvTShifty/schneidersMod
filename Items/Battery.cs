using Microsoft.Xna.Framework;                              // 
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items
{
    public class Battery : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Battery");
            Tooltip.SetDefault("Used for basic powering");
        }

        public override void SetDefaults() {
            item.width = 20;
            item.height = 10;
            item.value = 100f;
            item.rare = 1;
            item.maxStack = 999;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.itemType("acid"), 5);
            recipe.AddIngredient(ItemID.IronOre, 3);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}