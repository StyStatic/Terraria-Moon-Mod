using Terraria;
using Terraria.ModLoader;

namespace MoonMod.Items.Moonset

{
	[AutoloadEquip(EquipType.Head)]
	public class MoonphyteSpaceHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This helmet was forged using pieces of the moon");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000000;
			item.rare = 11;
			item.defense = 40;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			if (body.type == mod.ItemType("ExampleBreastplate"))
			{
				return legs.type == mod.ItemType("ExampleLeggings");
			}
			return false;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.meleeDamage *= 0.2f;
			player.thrownDamage *= 0.2f;
			player.rangedDamage *= 0.2f;
			player.magicDamage *= 0.2f;
			player.minionDamage *= 0.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(mod, "MoonphyteBar", 20);
			modRecipe.AddIngredient(2763);
			modRecipe.AddIngredient(2757);
			modRecipe.AddIngredient(3381);
			modRecipe.AddIngredient(2760);
			modRecipe.AddTile(mod, "MoonphyteAnvil");
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}
	}
}

