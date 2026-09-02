using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class ExecutionerAxe : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 245;
			Item.DamageType = DamageClass.Melee;
			Item.width = 66;
			Item.height = 66;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 25;
			Item.value = 12500;
			Item.rare = ItemRarityID.Purple;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;
			Item.useTurn = false;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Executioner Axe");
			//Tooltip.SetDefault("");
		}

    public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
    {
        player.AddBuff(BuffID.CursedInferno, 120);
    }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightCore>(), 1);
			recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.AddIngredient(ModContent.ItemType<MultidimensionalFragment>(), 8);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 20);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
