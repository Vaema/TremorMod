using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class Sharking : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 72;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 45;
			Item.useAnimation = 35;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 7;
			Item.shoot = ProjectileID.MiniSharkron;
			Item.shootSpeed = 14f;
			Item.value = 13570;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Sharking");
			//Tooltip.SetDefault("");
		}
	}