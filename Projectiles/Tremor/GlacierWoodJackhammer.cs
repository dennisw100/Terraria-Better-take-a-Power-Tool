using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class GlacierWoodJackhammer : ModProjectile
	{
		public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
                Main.projFrames[projectile.type] = 4;
            }
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Projectiles/Tremor/GlacierWoodJackhammer" + Config.OldWoodJackhammersSprite + Config.GustoneVersionWoodJackhammersSprite; }
        }
        public override void AI()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                projectile.frameCounter++;
                if (projectile.frameCounter >= 6.66666666667f)
                {
                    projectile.frameCounter = 0;
                    projectile.frame = (projectile.frame + 1) % 4;
                }
            }
		}
	}
}