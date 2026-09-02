using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Body)]
	public class BenderBody : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = ItemRarityID.Pink;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Bender Body");
			//Tooltip.SetDefault("");
		}
	}
