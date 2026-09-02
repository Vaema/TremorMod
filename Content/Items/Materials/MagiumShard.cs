using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class MagiumShard : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 120;
			Item.rare = ItemRarityID.Pink;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Magium Shard");
			//Tooltip.SetDefault("");
		}
	}