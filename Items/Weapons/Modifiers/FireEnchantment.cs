using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items.Weapons.Modifiers
{
    public class FireEnchantment : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Fire");
        }

        public override void SetDefaults() {
            item.width = 12;
            item.height = 15;
            item.maxStack = 10;
            item.value = 100;
            item.rare = 2;
        }
    }
}
