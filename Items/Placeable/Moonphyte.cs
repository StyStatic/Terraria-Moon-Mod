using Terraria.ModLoader;

namespace MoonMod.Items.Placeable

{
	public class Moonphyte : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Moonphyte");
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(mod, "MoonRock", 5);
			modRecipe.AddTile(mod, "Sifter");
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}
	}
}
