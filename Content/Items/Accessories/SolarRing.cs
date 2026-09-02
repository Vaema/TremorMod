using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Accessories;

	public class SolarRing : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 22;
			Item.value = 250000;
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Solar Ring ");
			// Tooltip.SetDefault("20% increased melee damage\n" +
			//"Increases melee critical strike chance by 15\n" +
			//"Casts a ring of fire");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Melee) += 0.2f;
			player.GetCritChance(DamageClass.Melee) += 15;
			player.AddBuff(BuffID.Inferno, 60, true);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddIngredient(ModContent.ItemType<Band>());
			//recipe.SetResult(this);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}