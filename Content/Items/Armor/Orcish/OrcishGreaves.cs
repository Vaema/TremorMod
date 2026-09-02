using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Armor.Orcish;

	[AutoloadEquip(EquipType.Legs)]
	public class OrcishGreaves : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.value = 500;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 3;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orcish Greaves");
			Tooltip.SetDefault("7% increased melee damage");
		}*/

		public override void UpdateEquip(Player player)
		{
        player.GetDamage(DamageClass.Melee) += 0.07f;   // +7% ê áëèæíåìó óðîíó
    }

	}
