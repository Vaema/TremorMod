using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Armor.Hummer;

	[AutoloadEquip(EquipType.Head)]
	public class HummerHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 26;
			Item.rare = ItemRarityID.Cyan;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Hummer's Helmet");
			//Tooltip.SetDefault("'Great for impersonating devs!'");
		}
	}