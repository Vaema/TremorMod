using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class WallofShadowMask : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 24;
			Item.rare = ItemRarityID.Blue;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Wall of Shadows Mask");
			//Tooltip.SetDefault("");
		}
	}
