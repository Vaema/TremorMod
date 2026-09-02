using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.BossLoot.TikiTotem;

	public class TikiSkull : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 24;
			Item.value = 10000;
			Item.rare = ItemRarityID.Cyan;
			Item.expert = true;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Tiki Skull");
			//Tooltip.SetDefault("10% increased minion damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Summon) += 0.1f;
		}
	}
