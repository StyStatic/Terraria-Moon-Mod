using Terraria;
using Terraria.ModLoader;

namespace MoonMod.NPCs

{ 
	public class NpcDrops : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (npc.type != 398)
			{
				return;
			}
			if (modnameworld.spawnOre)
			{
				Main.NewText("The gods do not approve of your decision. The Celestial ores have been activated", 16, 199, 245);
				for (int i = 0; i < (int)(WorldGen.rockLayer * (double)Main.maxTilesY * 0.0004); i++)
				{
					int i2 = WorldGen.genRand.Next(0, Main.maxTilesX);
					int j = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 200);
					WorldGen.OreRunner(i2, j, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("Moonphyte"));
				}
			}
			modnameworld.spawnOre = true;
		}
	}
}