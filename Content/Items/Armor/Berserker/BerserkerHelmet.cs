using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using TremorMod.Content.Buffs;
using TremorMod.Content.Items.Materials;
using Terraria.ID;

namespace TremorMod.Content.Items.Armor.Berserker;

	[AutoloadEquip(EquipType.Head)]
	public class BerserkerHelmet : ModItem
	{
    public static LocalizedText SetBonusText { get; private set; }

    public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.value = 400;
			Item.rare = ItemRarityID.Green;
			Item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
        //DisplayName.SetDefault("Berserker Helmet");
        //Tooltip.SetDefault("15% increased melee speed");
        SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs("Summons a Rotating Sword to fight for you");
    }

		public override void UpdateEquip(Player player)
		{
        player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
    }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<BerserkerChestplate>() && legs.type == ModContent.ItemType<BerserkerGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = SetBonusText.Value;
        SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs("Summons a Rotating Sword to fight for you");
        player.AddBuff(ModContent.BuffType<BerserkerBuff>(), 2);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}

		public override void AddRecipes()
		{
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 16);
        recipe.AddIngredient(ModContent.ItemType<MinotaurHorn>(), 1);
        recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 6);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }
	}
