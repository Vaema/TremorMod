using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Ranged;

	public class CandyBow : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 24;
			Item.height = 46;
			Item.useTime = 30;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 8f;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 5;
			Item.value = 30000;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Candy Bow");
			// Tooltip.SetDefault("");
		}

	}
