using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Buffs;
using TremorMod.Content.Items.Materials;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items;

public class VortexBand : ModItem
{
    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.Carrot);
        Item.rare = ItemRarityID.Purple;
        Item.value = 380000;
        Item.useTime = Item.useAnimation = 25;
        Item.shoot = ModContent.ProjectileType<VortexBee>();
        Item.buffType = ModContent.BuffType<VortexBeeBuff>();
    }

    public override void UseStyle(Player player, Rectangle heldItemFrame)
    {
        if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            player.AddBuff(Item.buffType, 3600);
    }

    public override void AddRecipes()
    {
        CreateRecipe().
            AddIngredient(ModContent.ItemType<UnchargedBand>()).
            AddIngredient(ItemID.FragmentVortex, 10).
            AddTile(TileID.LunarCraftingStation).
            Register();
    }
}
