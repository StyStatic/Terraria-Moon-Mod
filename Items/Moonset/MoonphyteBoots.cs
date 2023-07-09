using Terraria;
using Terraria.ModLoader;

namespace MoonMod.Items.Moonset

{
	[AutoloadEquip(EquipType.Legs)]
	public class MoonphyteBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("These boots were forged out of the most legendary armor and rocks from the moon.\n20% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000000;
			item.rare = 12;
			item.defense = 30;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(mod, "MoonphyteBar", 20);
			modRecipe.AddIngredient(2765);
			modRecipe.AddIngredient(3383);
			modRecipe.AddIngredient(2762);
			modRecipe.AddIngredient(2759);
			modRecipe.AddTile(mod, "MoonphyteAnvil");
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}
	}
}
