using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Buffs;

namespace TremorMod.Content.Items.Buffs;

	public class EnchantedHourglass : ModItem
	{
		public override void SetDefaults()
		{
			//item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 3;
			Item.value = 30000;
			Item.rare = ItemRarityID.Cyan;
			Item.expert = true;
			Item.UseSound = SoundID.Item4;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Enchanted Hourglass");
			//Tooltip.SetDefault("");
		}

		public override bool? UseItem(Player player)/* tModPorter Suggestion: Return null instead of false */
		{
			if (Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<HealthRecharging>()) != -1)
			{
				Item.mana = 0;
				Item.healLife = 0;
			}
			else
			{
				player.AddBuff(ModContent.BuffType<HealthRecharging>(), 1200, true);
				//item.mana = 50;
				Item.healLife = 30;
			}
			return false;
		}
	}
