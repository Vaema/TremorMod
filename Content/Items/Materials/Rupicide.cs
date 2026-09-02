using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class Rupicide : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 100;
			Item.rare = ItemRarityID.Orange;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rupicide");
			// Tooltip.SetDefault("");
		}
	}
