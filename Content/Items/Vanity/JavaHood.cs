using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class JavaHood : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 28;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Java Hood");
			//Tooltip.SetDefault("");
		}
	}