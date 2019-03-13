using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items
{
    public class AncientSwordHandle : ModItem
    {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("The handle of an Ancient Sword.");
        }

        public override void SetDefaults() {
            item.width = 8;
            item.height = 8;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 1;
        }
    }
}