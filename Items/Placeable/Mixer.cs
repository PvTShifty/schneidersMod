using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items.Placeable
{
    public class Mixer : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Mixer");
            Tooltip.SetDefault("Mix and mash.");            
        }

        public override void SetDefaults() {
            item.height = 20;
            item.width = 20;
            item.maxStack = 99;
            item.value = 20;
            item.rare = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 1;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("Mixer");
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 30);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}