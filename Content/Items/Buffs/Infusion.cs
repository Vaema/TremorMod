using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Buffs;

	public class Infusion : ModItem
	{
		public override void SetDefaults()
		{
			Item.rare = ItemRarityID.Purple;
			Item.maxStack = 1;
			Item.useAnimation = 20;
			Item.useTime = 20;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.potion = true;
			Item.healLife = 100;
			Item.UseSound = SoundID.Item3;
			Item.value = 1000000;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Infusion");
			//Tooltip.SetDefault("Eternal potion");
		}
	}