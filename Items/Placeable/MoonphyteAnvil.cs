using Terraria.ModLoader;

namespace MoonMod.Items.Placeable

{
	public class MoonphyteAnvil : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used to create moon themed items");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 10000;
			item.createTile = mod.TileType("MoonphyteAnvil");
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(3467, 15);
			modRecipe.AddIngredient(mod, "MoonphyteBar", 15);
			modRecipe.AddTile(134);
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}
	}
}
