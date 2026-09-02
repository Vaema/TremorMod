using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles.Bottled;

namespace TremorMod.Content.Items.Placeable.Bottled;

	public class BottledSoulOfLight : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 30;
			Item.maxStack = 1;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;

			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.value = 150;
			Item.rare = ItemRarityID.Pink;
			Item.createTile = ModContent.TileType<BottledSoulOfLightTile>();
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bottled Soul of Light");
			/* Tooltip.SetDefault("50% increased movement speed if worn\n" +
			"20% increased movement speed if placed"); */
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 0.5f;
		}
	}
