using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items.Weapons
{
    public class Slingshot : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Slingshot");
            Tooltip.SetDefault("Uses rocks for ammo");
        }

        public override void SetDefaults() {
            item.damage = 5;
            item.ranged = true;
            item.width = 25;
            item.height = 25;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 200;
            item.rare = 1;
            item.UseSound = SoundID.Item39;
            item.autoReuse = false;
            item.shoot = 10;
            item.scale = 1.5f;
            item.shootSpeed = 4f;
            item.useAmmo = mod.ItemType("StoneAmmo");
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(9, 50);
            recipe.AddIngredient(225, 10);
            recipe.AddIngredient(mod.ItemType("StickyGlue"), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override Vector2? HoldoutOffset()
		{
			return new Vector2(5, 0);
		}
    }
}