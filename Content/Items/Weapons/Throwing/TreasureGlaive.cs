using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items.Weapons.Throwing;

	public class TreasureGlaive : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 290;
			Item.width = 18;
			Item.height = 66;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<TreasureGlaivePro>();
			Item.shootSpeed = 15f;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 4;
			Item.value = 1000000;
			Item.rare = ItemRarityID.Purple;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Treasure Glaive");
			//Tooltip.SetDefault("");
		}
	}