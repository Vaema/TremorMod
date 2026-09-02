using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Materials;

	public class VoidBar : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 100;
			Item.rare = ItemRarityID.Purple;
			Item.createTile = ModContent.TileType<VoidBarTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void Bar");
			Tooltip.SetDefault("");
		}*/
	}
