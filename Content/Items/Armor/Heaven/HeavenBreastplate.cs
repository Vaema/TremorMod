using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Armor.Heaven;

	[AutoloadEquip(EquipType.Body)]
	public class HeavenBreastplate : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;

			Item.value = 6000;
			Item.rare = ItemRarityID.Orange;
			Item.defense = 7;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Heaven Breastplate");
			// Tooltip.SetDefault("12% increased ranged damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Ranged) += 0.12f;
		}

	}
