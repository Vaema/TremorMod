using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Magic;

	public class BurningTome : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 7;
			//Item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.mana = 6;
			Item.useStyle = ItemUseStyleID.Shoot;
			//item.shoot = mod.ProjectileType("BurningTome");
			Item.shoot = ProjectileID.ImpFireball;
			Item.shootSpeed = 26f;
			Item.knockBack = 4;
			Item.value = 12000;
			Item.rare = ItemRarityID.Green;
			//item.UseSound = SoundID.Item9;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Burning Tome");
			//Tooltip.SetDefault("");
		}
	}