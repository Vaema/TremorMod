using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class EyeofOblivion : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 16000;
			Item.rare = ItemRarityID.Purple;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Eye of Oblivion");
			//Tooltip.SetDefault("");
		}
	}