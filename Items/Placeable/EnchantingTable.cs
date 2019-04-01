using Terraria.ID;                                                          // enables the terraria.ID functions.
using Terraria.ModLoader;                                                   // enables the terraria.ModLoader functions.

namespace SchneidersMod.Items.Placeable
{
    public class EnchantingTable : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Enchantment Table");                    // Set the display name for if your cursor hovers over the item.
            Tooltip.SetDefault("Table for all your enchantment needs.");    // set the tooltip (description) for if your cursor hovers over the item.
        }

        public override void SetDefaults() {
            item.width = 28;                                                // hitbox width in px.
            item.height = 14;                                               // hitbox height in px.
            item.maxStack = 1;                                              // maximum amount the item can stack.
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;                                         // removes the item after it's "consumed".
            item.value = 150;                                               // determines the amount of copper coins this item is worth.
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