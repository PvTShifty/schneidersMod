using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Items.Weapons
{
	public class AncientSwordOne : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ancient Fire Sword");
		}

		public override void SetDefaults() {
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10;
			item.rare = 2;
			item.shoot = 504;
			item.shootSpeed = 7f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("AncientSword"));
			recipe.AddIngredient(mod.ItemType("FireEnchantment"), 5);
			recipe.AddTile(mod.TileType("EnchantingTable"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			{
				if (Main.rand.NextBool(3)) {
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width/3, hitbox.Height/3, 6);
				}
			}
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 300);
		}
	}
}