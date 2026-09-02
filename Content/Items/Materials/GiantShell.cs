using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class GiantShell : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 25000;
			Item.rare = ItemRarityID.Yellow;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Giant Shell");
			//Tooltip.SetDefault("");
		}
	}