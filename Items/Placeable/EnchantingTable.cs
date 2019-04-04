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
            item.useTurn = true;                                            // honestly have no clue.
            item.autoReuse = true;                                          // the item gets reused automatically.
            item.useAnimation = 15;                                         // use the animation number 15.
            item.useTime = 10;                                              // set the use time.
            item.useStyle = 1;                                              // how does the item get used?
            item.consumable = true;                                         // removes the item after it's "consumed".
            item.value = 150;                                               // determines the amount of copper coins this item is worth.
            item.createTile = mod.TileType("EnchantingTable");              // this item creates the tile EnchantingTable.
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);                          // make a new recipe class.
            recipe.AddIngredient(ItemID.WorkBench);                         // add an ingredient to the recipe.
            recipe.AddIngredient(mod.ItemType("FireEnchantment"), 10);      // add an ingredient to the recipe.
            recipe.SetResult(this);                                         // sets the reesult of the recipe.
            recipe.AddRecipe();                                             // add the recipe to the item.
        }
    }
}