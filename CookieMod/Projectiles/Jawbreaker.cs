using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class Jawbreaker : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jawbreaker");     //The English name of the projectile
		}
        public override void SetDefaults()
        {
            projectile.width = 2;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.alpha = 0;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
            projectile.CloneDefaults(ProjectileID.Bullet);
        }
		public override void AI()
		{
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("HardSugar"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}
		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("HardSugar"), projectile.oldVelocity.X * 0f, projectile.oldVelocity.Y * 0f);
			}
		}
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Main.PlaySound(SoundID.Item10, projectile.position);
			return true;
		}		
    }
}
