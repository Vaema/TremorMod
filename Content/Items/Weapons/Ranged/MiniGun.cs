using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Ranged;

	public class MiniGun : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 8;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 20;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.useStyle = ItemUseStyleID.Shoot;
			//Item.noMelee = true;
			Item.knockBack = 6;
			Item.value = 100000;
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.PurificationPowder;
			Item.shootSpeed = 15f;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Mini Gun");
			//Tooltip.SetDefault("");
		}
	}