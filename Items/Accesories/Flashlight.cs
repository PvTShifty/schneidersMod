using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items.Accesories
{
    public class Flashlight : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Flashlight");
            Tooltip.SetDefault("When equiped grants you the shine buff.");
        }

        public override void SetDefaults() {
            item.width = 20;
            item.height = 20;
            item.value = 2000;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            Player.AddBuff(BuffID.Shine, 1);
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Battery"), 5);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}