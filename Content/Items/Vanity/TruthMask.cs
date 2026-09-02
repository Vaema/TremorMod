using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class TruthMask : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 28;
			Item.rare = ItemRarityID.Blue;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Truth Mask");
			// Tooltip.SetDefault("");
		}

	}
