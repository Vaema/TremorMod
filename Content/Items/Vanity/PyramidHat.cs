using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class PyramidHat : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 24;
			Item.rare = ItemRarityID.Green;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Pyramid Hat");
			//Tooltip.SetDefault("");
		}
	}