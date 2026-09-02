using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;

namespace TremorMod.Content.Items.Armor.Meteor;

	[AutoloadEquip(EquipType.Head)]
	public class MeteorMask : ModItem
	{
    public static LocalizedText SetBonusText { get; private set; }

    public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 28;
			Item.value = 9000;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
        //DisplayName.SetDefault("Meteor Mask");
        //Tooltip.SetDefault("Increases magic critical strike chance by 9");
        SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs("Increases magic critical strike chance by 9");
    }

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Magic) += 9;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.MeteorSuit && legs.type == ItemID.MeteorLeggings;
		}

		public override void UpdateArmorSet(Player player)
		{
        player.setBonus = SetBonusText.Value;
        player.setBonus = "Reduces the mana cost of the Space Gun to zero";
			player.spaceGun = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MeteoriteBar, 15);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
