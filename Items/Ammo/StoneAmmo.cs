using Terraria;                                             // enables the terraria functions.
using Terraria.ID;                                          // enables the terraria.ID functions.
using Terraria.ModLoader;                                   // enables the terraria.ModLoader functions.

namespace SchneidersMod.Items.Ammo
{
    public class StoneAmmo : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rock");                 // Set the display name for if your cursor hovers over the item.
            Tooltip.SetDefault("Used by the Slingshot");    // set the tooltip (description) for if your cursor hovers over the item.
        }

        public override void SetDefaults() {
            item.damage = 5;                                // determines the amount of damage.
            item.ranged = true;                             // tells the game it's a ranged projectile.
            item.width = 14;                                // hitbox width in px.
            item.height = 14;                               // hitbox height in px.
            item.maxStack = 999;                            // maximum amount the item can stack.
            item.consumable = true;                         // removes the item after it's "consumed".
            item.knockBack = 2;                            // determines the amount of knockback the item has.
            item.value = 10;                                // determines the amount of copper coins this item is worth.
            item.rare = 1;                                  // determines the rarity of the item.
            item.shoot = mod.ProjectileType("StoneAmmo");   // if this item gets consumed it shoots the projectile "StoneAmmo".
            item.shootSpeed = 4f;                           // deteremines the shootspeed of the item.
            item.ammo = item.type;                          // tells the game this item is it's own ammo type.
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);          // make a new recipe class.
            recipe.AddIngredient(ItemID.StoneBlock);        // add an ingredient to the recipe.
            recipe.AddTile(TileID.WorkBenches);             // add a tile you have to make the item at.
            recipe.SetResult(this, 2);                      // sets the reesult of the recipe.
            recipe.AddRecipe();                             // add the recipe to the item.
        }
    }
}