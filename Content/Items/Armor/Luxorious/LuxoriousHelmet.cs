using Terraria;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials.OreAndBar;
using Terraria.Localization;
using Terraria.ID;

namespace TremorMod.Content.Items.Armor.Luxorious;

	[AutoloadEquip(EquipType.Head)]
	public class LuxoriousHelmet : ModItem
	{

    public static LocalizedText SetBonusText { get; private set; }

    public override void SetDefaults()
		{
			Item.defense = 15;
			Item.width = 26;
			Item.height = 32;
			Item.value = 2500;
			Item.rare = ItemRarityID.Yellow;
		}

		public override void SetStaticDefaults()
		{
        //DisplayName.SetDefault("Luxorious Helmet");
        //Tooltip.SetDefault("12% increased mining speed");
        SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs("Allows to detect treasures, ores and traps");
    }

		public override void UpdateEquip(Player player)
		{
			player.pickSpeed -= 0.12f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<LuxoriousBreastplate>() && legs.type == ModContent.ItemType<LuxoriousLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
        player.setBonus = SetBonusText.Value;
        player.setBonus = "Allows to detect treasures, ores and traps";
			player.findTreasure = true;
			player.AddBuff(BuffID.Dangersense, 2);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<EvershinyBar>(), 15);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
