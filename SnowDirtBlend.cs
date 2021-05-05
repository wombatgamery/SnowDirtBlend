using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SnowDirtBlend
{
	public class SnowDirtBlend : Mod
	{
	}

	public class blend : GlobalTile
	{
		public override void SetDefaults()
		{
			Main.tileMergeDirt[TileID.SnowBlock] = true;
			Main.tileMerge[TileID.SnowBlock][TileID.IceBlock] = true;
		}
	}
}