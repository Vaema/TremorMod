using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Armor.Hallowed;

	[AutoloadEquip(EquipType.Head)]
	public class HallowedHeader : ModItem
	{
		public static LocalizedText SetBonusText { get; private set; }

    public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 24;
			Item.value = 400;
			Item.rare = ItemRarityID.LightRed;
			Item.defense = 9;
		}

		public override void SetStaticDefaults()
		{
        //DisplayName.SetDefault("Hallowed Header");
        //Tooltip.SetDefault("26% increased thrown damage");
        SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs("Increases thrown weapon velocity");
    }

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Throwing) += 0.26f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.HallowedPlateMail && legs.type == ItemID.HallowedGreaves;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = SetBonusText.Value;
        player.setBonus = "Increases thrown weapon velocity";
			player.GetAttackSpeed(DamageClass.Throwing) += 0.25f;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HallowedBar, 12);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}