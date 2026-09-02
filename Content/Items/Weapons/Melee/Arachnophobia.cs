using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class Arachnophobia : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 7;
			Item.shoot = ProjectileID.SpiderEgg;
			Item.shootSpeed = 14f;
			Item.value = 12500;
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Arachnophobia");
			// Tooltip.SetDefault("");
		}

	}
