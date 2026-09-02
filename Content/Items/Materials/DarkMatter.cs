using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class DarkMatter : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 100;
			Item.rare = ItemRarityID.LightPurple;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Dark Matter");
			//Tooltip.SetDefault("");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(8, 4));
		}
	}