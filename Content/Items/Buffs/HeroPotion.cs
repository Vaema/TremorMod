using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Buffs;
using TremorMod.Content.Items.Materials;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Buffs;

	public class HeroPotion : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 32;
			Item.maxStack = 20;
			Item.rare = ItemRarityID.Blue;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;
        Item.buffType = ModContent.BuffType<HeroBuff>();
    }

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Hero Potion");
			//Tooltip.SetDefault("Grants 10000 defense\n" +
			//"Grants immunity to all debuffs\n" +
			//"Increases movement speed\n" +
			//"Makes you priority target for enemies\n" +
			//"'Feel like a real hero! At least for 15 seconds.'");
		}

		public override bool? UseItem(Player player)
		{
			player.AddBuff(ModContent.BuffType<HeroBuff>(), 900);
			return true;
		}

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        foreach (var tooltip in tooltips)
        {
            // Ìåíÿåì öâåò òåêñòà äëÿ íàçâàíèÿ ïðåäìåòà
            if (tooltip.Mod == "Terraria" && tooltip.Name == "ItemName")
            {
                tooltip.OverrideColor = new Color(238, 194, 73); // Öâåò çîëîòà
            }
        }
    }

    public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ModContent.ItemType<MultidimensionalFragment>(), 10);
			recipe.AddIngredient(ModContent.ItemType<NightmareOre>(), 25);
			recipe.AddIngredient(ItemID.RegenerationPotion, 5);
			recipe.AddIngredient(ItemID.IronskinPotion, 5);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 5);
			recipe.AddIngredient(ItemID.ObsidianSkinPotion, 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddIngredient(ItemID.FragmentStardust, 5);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 1);
			recipe.AddTile(ModContent.TileType<AlchemyStationTile>());
			//recipe.SetResult(this);
			recipe.Register();
		}
	}
