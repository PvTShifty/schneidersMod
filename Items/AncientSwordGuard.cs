using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items
{
    public class AncientSwordGuard : ModItem
    {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("A guard of an Ancient Sword.");
        }

        public override void SetDefaults() {
            item.width = 14;
            item.height = 14;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 1;
        }
    }
}