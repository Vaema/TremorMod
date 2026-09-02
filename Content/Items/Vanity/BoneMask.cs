using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class BoneMask : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 24;
			Item.rare = ItemRarityID.Green;
			Item.vanity = true;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bone Mask");
			Tooltip.SetDefault("");
		}*/
	}
