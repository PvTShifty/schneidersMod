using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items.Placeable
{
    public class EnchantingTable : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Enchantment Table");
            Tooltip.SetDefault("Table for all your enchantment needs.");
        }

        public override void SetDefaults() {
            item.width = 28;
            item.height = 14;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("EnchantingTable");
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WorkBench);
            recipe.AddIngredient(mod.ItemType("FireEnchantment"), 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}