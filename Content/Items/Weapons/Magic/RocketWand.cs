using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Magic;

	public class RocketWand : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Starfury);

			Item.damage = 300;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 20;
			Item.mana = 9;
        Item.shoot = ProjectileID.RocketI;
        Item.useAnimation = 50;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.shootSpeed = 10f;
			Item.staff[Item.type] = true;
			Item.knockBack = 3;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item9;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rocket Wand");
			// Tooltip.SetDefault("Causes missiles to fall from the sky");
		}
	}
