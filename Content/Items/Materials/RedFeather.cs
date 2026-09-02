using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class RedFeather : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 3000;
			Item.rare = ItemRarityID.LightRed;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Red Feather");
			//Tooltip.SetDefault("");
		}
	}