using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Throwing;

	public class ThrowingWrench : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 25;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 28;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ProjectileID.MechanicWrench;
			Item.shootSpeed = 14f;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 4;
			Item.value = 60;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Throwing Wrench");
			// Tooltip.SetDefault("");
		}

	}