using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.Projectiles
{
    public class StoneAmmo : ModProjectile
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rock");
        }

        public override void SetDefaults() {
            projectile.width = 14;
            projectile.height = 14;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            projectile.timeLeft = 1200;
            projectile.penetrate = 2;
            projectile.tileCollide = true;
            aiType = ProjectileID.SnowBallFriendly;
}

        public override void Kill(int timeLeft) {
            for (int i = 0; i < 5; i++) {
                int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 1, projectile.oldVelocity.X * 0.1f, projectile.oldVelocity.Y * 0.1f);
            }
        Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 0);
        }
    }
}