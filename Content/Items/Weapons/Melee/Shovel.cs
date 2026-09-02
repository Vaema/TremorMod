using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class Shovel : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 24;
			Item.DamageType = DamageClass.Melee;
			Item.width = 46;
			Item.height = 50;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 7;
			Item.value = 121000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shovel");
			// Tooltip.SetDefault("");
		}

	}
