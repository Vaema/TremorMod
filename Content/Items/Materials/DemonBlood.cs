using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class DemonBlood : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 26;
			Item.maxStack = 9999;
			Item.value = 100;
			Item.rare = ItemRarityID.LightRed;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Demon Blood");
			//Tooltip.SetDefault("");
		}
	}