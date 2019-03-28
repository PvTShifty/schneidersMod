using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items.Ammo
{
    public class StoneAmmo : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rock");
            Tooltip.SetDefault("Used by the Slingshot");
        }

        public override void SetDefaults() {
            item.damage = 3;
            item.ranged = true;
            item.width = 14;
            item.height = 14;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2f;
            item.value = 10;
            item.rare = 1;
            item.shoot = mod.ProjectileType("StoneAmmo");
            item.shootSpeed = 9f;
            item.ammo = AmmoID.Snowball;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}