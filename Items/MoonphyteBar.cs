using Terraria.ModLoader;

namespace MoonMod.Items

{
	public class MoonphyteBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonphyte Bar");
			Tooltip.SetDefault("A bar of the gods");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(mod, "Moonphyte", 5);
			modRecipe.AddIngredient(3467, 5);
			modRecipe.AddTile(133);
			modRecipe.SetResult(this, 5);
			modRecipe.AddRecipe();
		}
	}
}
