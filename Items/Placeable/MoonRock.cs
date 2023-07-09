using Terraria.ModLoader;

namespace MoonMod.Items.Placeable

{
	public class MoonRock : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moon Dirt");
			Tooltip.SetDefault("This rock has experienced things unimaginable");
		}

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
			item.createTile = mod.TileType("MoonRock");
		}
	}
}
