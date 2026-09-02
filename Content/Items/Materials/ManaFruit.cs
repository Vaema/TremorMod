using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class ManaFruit : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 26;
			Item.maxStack = 9999;
			Item.value = 250;
			Item.rare = ItemRarityID.Orange;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Mana Fruit");
			//Tooltip.SetDefault("");
		}
	}