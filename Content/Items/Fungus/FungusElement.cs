using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Fungus;

	public class FungusElement : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 14;
			Item.height = 22;
			Item.rare = ItemRarityID.Orange;
			Item.maxStack = 9999;
			Item.value = 100;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fungus Element");
			Tooltip.SetDefault("");
		}*/

	}
