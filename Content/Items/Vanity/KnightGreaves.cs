using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Legs)]
	public class KnightGreaves : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Knight Greaves");
			//Tooltip.SetDefault("");
		}
	}