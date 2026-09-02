using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Legs)]
	public class PossessedGreaves : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.value = 100;
			Item.rare = ItemRarityID.Blue;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Possessed Greaves");
			//Tooltip.SetDefault("");
		}
	}