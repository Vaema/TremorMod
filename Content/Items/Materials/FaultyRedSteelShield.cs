using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class FaultyRedSteelShield : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 28;
			Item.maxStack = 9999;
			Item.value = 50;
			Item.rare = ItemRarityID.Blue;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Faulty Red Steel Shield");
			// Tooltip.SetDefault("");
		}
	}
