using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class DrillofBloom : ModProjectile
	{
		public override void SetDefaults()
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				projectile.CloneDefaults(ProjectileID.SawtoothShark);
			}
		}
	}
}