using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles.Bottled;

namespace TremorMod.Content.Items.Placeable.Bottled;

	public class BottledSoulOfFright : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 28;
			Item.maxStack = 1;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;

			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.value = 150;
			Item.rare = ItemRarityID.Pink;
			Item.createTile = ModContent.TileType<BottledSoulOfFrightTile>();
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bottled Soul of Fright");
			/* Tooltip.SetDefault("Increases critical strike chance by 6 if worn\n" +
"Increased critical strike chance by 2 if placed"); */
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetCritChance(DamageClass.Ranged) += 6;
			player.GetCritChance(DamageClass.Melee) += 6;
			player.GetCritChance(DamageClass.Magic) += 6;
			player.GetCritChance(DamageClass.Throwing) += 6;
		}
	}
