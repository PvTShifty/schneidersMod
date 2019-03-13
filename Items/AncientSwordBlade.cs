using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items
{
    public class AncientSwordBlade : ModItem
    {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("The blade of an Ancient Sword.");
        }

        public override void SetDefaults() {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 1;
        }
    }
}