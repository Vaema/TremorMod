using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items.Weapons.Magic;

	public class ShadowReaperBook : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.WaterBolt);
			Item.damage = 39;
			Item.DamageType = DamageClass.Magic;
			Item.width = 26;
			Item.maxStack = 1;
			Item.height = 30;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.shoot = ModContent.ProjectileType<ShadowR>();
			Item.shootSpeed = 11.5f;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 4;
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.mana = 9;

		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Shadow Reaper");
			//Tooltip.SetDefault("Summons homing shadow creature");
		}
	}