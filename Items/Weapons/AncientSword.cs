using Microsoft.Xna.Framework;
using Terraria;                                                         // enables the terraria functions.
using Terraria.ID;                                                      // enables the terraria.ID functions.
using Terraria.ModLoader;                                               // enables the terraria.ModLoader functions.

namespace SchneidersMod.Items.Weapons
{
    public class AncientSword : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ancient Sword");                    // Set the display name for if your cursor hovers over the item.
        }
        public override void SetDefaults()
        {
            item.damage = 20;                                           // determines the amount of damage.
            item.melee = true;                                          // tells the game it's a melee item.
            item.width = 40;                                            // hitbox width in px.
            item.height = 40;                                           // hitbox height in px.
            item.useTime = 15;                                          // set the use time.
            item.useAnimation = 20;                                     // use the animation number 15.
            item.useStyle = 1;                                          // how does the item get used?
            item.knockBack = 6;                                         // determines the amount of knockback the item has.
            item.value = 10;                                            // determines the amount of copper coins this item is worth.
            item.rare = 1;                                              // determines the rarity of the item.
            item.UseSound = SoundID.Item1;                              // determines which sound it plays on use.
            item.autoReuse = false;                                     // tells the game whether it should autoreus the item or not
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);                      // make a new recipe class.
            recipe.AddIngredient(mod.ItemType("AncientSwordBlade"));    // add an ingredient to the recipe.
			recipe.AddIngredient(mod.ItemType("AncientSwordHandle"));   // add an ingredient to the recipe.
			recipe.AddIngredient(mod.ItemType("AncientSwordGuard"));    // add an ingredient to the recipe.
            recipe.AddIngredient(mod.ItemType("StickyGlue"), 5);        // add an ingredient to the recipe.
            recipe.AddTile(TileID.Anvils);                              // add a tile you have to make the item at.
            recipe.SetResult(this);                                     // sets the reesult of the recipe.
            recipe.AddRecipe();                                         // add the recipe to the item.
        }
    }
}