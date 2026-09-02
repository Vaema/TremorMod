using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Tools;

	public class SandstonePickaxe : ModItem
	{
		public override void SetDefaults()
		{
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useAnimation = 45;
			Item.useTime = 21;
			Item.pick = 46;
			Item.width = 24;
			Item.height = 28;
			Item.damage = 8;
			Item.knockBack = 6f;
			Item.scale = 1.3f;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Blue;
			Item.value = 13500;
			Item.DamageType = DamageClass.Melee;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dune Pickaxe");
			Tooltip.SetDefault("");
		}*/

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 1);
			recipe.AddIngredient(ItemID.Topaz, 4);
			recipe.AddIngredient(ItemID.AntlionMandible, 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.SetResult(this);
			recipe.Register();
		}
	}
