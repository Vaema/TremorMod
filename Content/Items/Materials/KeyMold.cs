using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class KeyMold : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 40;
			Item.maxStack = 9999;
			Item.value = 300000;
			Item.rare = ItemRarityID.Pink;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Key Mold");
			//Tooltip.SetDefault("");
		}
	}