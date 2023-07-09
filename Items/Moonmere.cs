using Terraria.ID;
using Terraria.ModLoader;

namespace MoonMod.Items

{
	public class Moonmere : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonmere");
			Tooltip.SetDefault("This sword is not just a normal meowmere, Its plated with Moonphyte");
		}

		public override void SetDefaults()
		{
			item.damage = 280;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6f;
			item.value = 300000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 502;
			item.shootSpeed = 12f;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(3063);
			modRecipe.AddIngredient(mod, "MoonphyteBar", 30);
			modRecipe.AddTile(mod, "Infuser");
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}
	}
}
