using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class MusketeerHat : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 24;
			Item.value = 2500;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Muskeeter Hat");
			//Tooltip.SetDefault("");
		}
	}