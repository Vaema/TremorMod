using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Ranged;

	public class Vertebrow : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 15;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 30;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 12f;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 8;
			Item.value = 540;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Vertebrow");
			// Tooltip.SetDefault("");
		}

	}
