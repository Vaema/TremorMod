using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class ConcentratedEther : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 15000;
			Item.rare = ItemRarityID.Cyan;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Concentrated Ether");
			//Tooltip.SetDefault("");
		}
	}
