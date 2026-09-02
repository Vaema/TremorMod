using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using TremorMod.Content.Items.Materials.OreAndBar;
using TremorMod.Content.Items.Materials;
using Terraria.ID;

namespace TremorMod.Content.Items.Armor.Brutallisk;

	[AutoloadEquip(EquipType.Head)]
	public class BrutalliskHelmet : ModItem
	{
    public static LocalizedText SetBonusText { get; private set; }

    public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;
			Item.value = 150000;
			Item.rare = ItemRarityID.Purple;
			Item.defense = 20;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brutallisk Helmet");
			/* Tooltip.SetDefault("Increases maximum life by 40\n" +
			"15% increased melee speed"); */
        SetBonusText = this.GetLocalization("SetBonus").WithFormatArgs("Greatly increases health regeneration");
    }

		public override void UpdateEquip(Player player)
		{
			player.statLifeMax2 += 40;
			player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<BrutalliskChestplate>() && legs.type == ModContent.ItemType<BrutalliskGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
        player.setBonus = SetBonusText.Value;
        player.setBonus = "Greatly increases health regeneration";
			player.lifeRegen = +30;

			if (Math.Abs(player.velocity.X) + Math.Abs(player.velocity.Y) > 1f && !player.rocketFrame) // Makes sure the player is actually moving
			{
				for (int k = 0; k < 1; k++)
				{
					int index = Dust.NewDust(new Vector2(player.position.X - player.velocity.X * 2f, player.position.Y - 2f - player.velocity.Y * 2f), player.width, player.height, DustID.Glass, 0f, 0f, 100, default(Color), 2f);
					Main.dust[index].noGravity = true;
					Main.dust[index].noLight = true;
					Dust dust = Main.dust[index];
					dust.velocity.X -= player.velocity.X * 0.5f;
					dust.velocity.Y -= player.velocity.Y * 0.5f;
				}
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Aquamarine>(), 10);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 6);
			recipe.AddIngredient(ModContent.ItemType<EvershinyBar>(), 6);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 3);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
