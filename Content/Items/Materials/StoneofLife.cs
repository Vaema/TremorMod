using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class StoneofLife : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 16;
			Item.maxStack = 9999;
			Item.value = 500;
			Item.rare = ItemRarityID.Blue;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone of Life");
			Tooltip.SetDefault("");
		}*/

	}
