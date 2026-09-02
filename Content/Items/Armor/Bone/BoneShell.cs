using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Armor.Bone;

	[AutoloadEquip(EquipType.Body)]
	public class BoneShell : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;

			Item.value = 25000;
			Item.rare = ItemRarityID.LightRed;
			Item.defense = 9;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bone Shell");
			/* Tooltip.SetDefault("25% increased thrown damage\n" +
"6% increased ranged damage"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Throwing) += 0.25f;
			player.GetDamage(DamageClass.Ranged) += 0.06f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.NecroBreastplate, 1);
			recipe.AddIngredient(ItemID.FossilShirt, 1);
			recipe.AddIngredient(ModContent.ItemType<CursedSoul>(), 1);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.AddIngredient(ModContent.ItemType<SharpenedTooth>(), 3);
			recipe.AddIngredient(ModContent.ItemType<TheRib>(), 3);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
