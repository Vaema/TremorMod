using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Legs)]
	public class CursedKnightGreaves : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 18;
			Item.value = 30000;

			Item.rare = ItemRarityID.Cyan;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Knight Greaves");
			// Tooltip.SetDefault("'Great for impersonating devs!'");
		}

	}
