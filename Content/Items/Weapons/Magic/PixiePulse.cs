using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Magic;

	public class PixiePulse : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 46;
			Item.DamageType = DamageClass.Magic;
			Item.width = 46;
			Item.height = 26;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.knockBack = 7;
			Item.value = 10000;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item12;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.PurpleLaser;
			Item.shootSpeed = 5f;
			Item.mana = 10;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Pixie Pulse");
			//Tooltip.SetDefault("");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-1, 0);
		}
	}
