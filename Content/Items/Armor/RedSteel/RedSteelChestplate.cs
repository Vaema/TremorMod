using Terraria;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials.OreAndBar;
using TremorMod.Content.Items.Materials;
using Terraria.ID;

namespace TremorMod.Content.Items.Armor.RedSteel;

	[AutoloadEquip(EquipType.Body)]
	public class RedSteelChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.value = 200;

			Item.rare = ItemRarityID.Green;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Steel Chestplate");
			// Tooltip.SetDefault("10% increased melee speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<RedSteelArmorPiece>(), 5);
			recipe.AddIngredient(ModContent.ItemType<RedSteelBar>(), 8);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
