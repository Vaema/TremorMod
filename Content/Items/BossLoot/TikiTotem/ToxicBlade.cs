using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.BossLoot.TikiTotem;

	public class ToxicBlade : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 36;
			Item.maxStack = 9999;
			Item.value = 100;
			Item.rare = ItemRarityID.Blue;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Toxic Blade");
			//Tooltip.SetDefault("");
		}
	}