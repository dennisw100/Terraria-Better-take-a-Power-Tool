using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class WarChainsawoftheNight : ModProjectile
	{
		public override void SetDefaults()
		{
           
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Projectiles/WarChainsawoftheNight" + Config.OldWarChainsawoftheNightSprite; }
        }
        public override void AI()
		{
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 14, projectile.velocity.X * 0.1f, projectile.velocity.Y * 0.1f, 100, default(Color), 1.5f);
                Main.dust[dust].noGravity = true;
		}
	}
}