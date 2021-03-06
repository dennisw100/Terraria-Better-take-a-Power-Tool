using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class BloodyMassacre : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ButchersChainsaw);
            projectile.scale = 1f;
        }
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Projectiles/BloodyMassacre" + Config.OldBloodyMassacreSprite; }
        }
        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 5, projectile.velocity.X * 0.1f, projectile.velocity.Y * 0.1f, 100, default(Color), 1.9f);
            Main.dust[dust].noGravity = true;
        }
    }
}