using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class MoltenDrill : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Drill");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.MoltenPickaxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 0;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("MoltenDrill");
			item.shootSpeed = 40f;
		}
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}