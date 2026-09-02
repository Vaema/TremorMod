using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class TearsofDeath : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 28;
			Item.maxStack = 9999;
			Item.value = 100;
			Item.rare = ItemRarityID.Orange;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Tears of Death");
			//Tooltip.SetDefault("Unstable ingredient");
		}
	}