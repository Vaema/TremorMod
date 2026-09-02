using Terraria;
using Terraria.ModLoader;

namespace TremorMod.Content.Buffs;

	public class SteamMageBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Brass Magic Enchanting");
			//Description.SetDefault("Increases Brass Stave damage");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}