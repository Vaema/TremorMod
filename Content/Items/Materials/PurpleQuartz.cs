using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class PurpleQuartz : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 12000;
			Item.rare = ItemRarityID.Cyan;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Purple Quartz");
			//Tooltip.SetDefault("");
		}
	}