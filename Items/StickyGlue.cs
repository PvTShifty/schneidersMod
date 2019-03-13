using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items
{
    public class StickyGlue : ModItem
    {
        public override void SetDefaults() {
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 20);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}