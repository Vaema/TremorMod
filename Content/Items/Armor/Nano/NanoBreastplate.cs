using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials.OreAndBar;

namespace TremorMod.Content.Items.Armor.Nano;

	[AutoloadEquip(EquipType.Body)]
	public class NanoBreastplate : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 18;
			Item.value = 60000;
			Item.rare = ItemRarityID.LightPurple;
			Item.defense = 17;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nano Breastplate");
			Tooltip.SetDefault("8% increased damage\n" +
			"10% increased melee speed");
		}*/

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.08f;   // +8% ê áëèæíåìó óðîíó
			player.GetDamage(DamageClass.Magic) += 0.08f;   // +8% ê ìàãè÷åñêîìó óðîíó
			player.GetDamage(DamageClass.Ranged) += 0.08f;  // +8% ê äàëüíåìó óðîíó
			player.GetDamage(DamageClass.Throwing) += 0.08f; // +8% ê óðîíó áðîñêîâ
			player.GetDamage(DamageClass.Summon) += 0.08f;  // +8% ê óðîíó ïðèñëóæíèêîâ
			player.GetAttackSpeed(DamageClass.Melee) += 0.10f;
		}

		public override void AddRecipes()
		{
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<NanoBar>(), 20);
        //recipe.SetResult(this);
			recipe.AddTile(TileID.MythrilAnvil);
        recipe.Register();
    }
	}
