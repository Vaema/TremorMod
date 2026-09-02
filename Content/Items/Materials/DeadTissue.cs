using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class DeadTissue : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 12000;
			Item.rare = ItemRarityID.Red;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Dead Tissue");
			//Tooltip.SetDefault("");
		}
	}