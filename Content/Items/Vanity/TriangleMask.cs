using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class TriangleMask : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 24;

			Item.rare = ItemRarityID.Blue;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Triangle Mask");
			// Tooltip.SetDefault("");
		}

	}
