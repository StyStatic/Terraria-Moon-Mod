using Terraria;
using Terraria.ModLoader;

namespace MoonMod.Items.Moonset

{
	[AutoloadEquip(EquipType.Body)]
	public class MoonphyteSuit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonphyte Space Suit");
			Tooltip.SetDefault("This chestplate was forged with the power of the celestial armor.\nImmunity to most debuffs\n+20 max mana and +1 max minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000000;
			item.rare = 12;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[24] = true;
			player.buffImmune[31] = true;
			player.buffImmune[30] = true;
			player.buffImmune[20] = true;
			player.buffImmune[70] = true;
			player.buffImmune[47] = true;
			player.buffImmune[156] = true;
			player.statManaMax2 += 60;
			player.maxMinions++;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(mod, "MoonphyteBar", 35);
			modRecipe.AddIngredient(2764);
			modRecipe.AddIngredient(2758);
			modRecipe.AddIngredient(3382);
			modRecipe.AddIngredient(2761);
			modRecipe.AddTile(mod, "MoonphyteAnvil");
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}
	}
}
