using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class PumpkingMask : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 30;
			Item.rare = ItemRarityID.Blue;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Pumpking Mask");
			//Tooltip.SetDefault("");
		}
	}