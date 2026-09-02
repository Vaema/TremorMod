using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using TremorMod.Content.Items.Materials.OreAndBar;
using TremorMod.Content.Items.Materials;
using Terraria.ID;

namespace TremorMod.Content.Items.Armor.RedSteel;

	[AutoloadEquip(EquipType.Head)]
	public class RedSteelHeadgear : ModItem
	{
    public static LocalizedText SetBonusText { get; private set; }

    public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 20;
			Item.value = 200;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Steel Headgear");
			// Tooltip.SetDefault("10% increased melee damage");
        SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs("Grants chance to dodge attack");
    }

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<RedSteelChestplate>() && legs.type == ModContent.ItemType<RedSteelGreaves>();
		}

		public override void UpdateArmorSet(Player p)
		{
        p.setBonus = SetBonusText.Value;
        p.setBonus = "Grants chance to dodge attack";
			p.blackBelt = true;
		}

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<RedSteelArmorPiece>(), 5);
        recipe.AddIngredient(ModContent.ItemType<RedSteelBar>(), 7);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }
}
