using Terraria.ID;                              // enables the terraria.ID functions.
using Terraria.ModLoader;                       // enables the terraria.ModLoader functions.

namespace SchneidersMod.Items.Weapons.Modifiers
{
    public class FireEnchantment : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Fire");     // Set the display name for if your cursor hovers over the item.
        }

        public override void SetDefaults() {
            item.width = 12;                    // hitbox width in px.
            item.height = 15;                   // hitbox height in px.
            item.maxStack = 10;                 // maximum amount the item can stack.
            item.value = 100;                   // determines the amount of copper coins this item is worth.
            item.rare = 2;                      // determines the rarity of the item.
        }
    }
}
