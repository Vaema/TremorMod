using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class SquidHat : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 24;
			Item.rare = ItemRarityID.Blue;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Squid Hat");
			//Tooltip.SetDefault("");
		}
	}