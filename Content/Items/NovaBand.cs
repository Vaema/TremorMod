using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Buffs;
using TremorMod.Content.Items.Materials;
using TremorMod.Content.NPCs.Bosses.NovaPillar.Items;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items;

public class NovaBand : ModItem
{
    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.Carrot);
        Item.rare = ItemRarityID.Purple;
        Item.value = 380000;
        Item.useTime = Item.useAnimation = 25;
        Item.shoot = ModContent.ProjectileType<Warkee>();
        Item.buffType = ModContent.BuffType<WarkeeBuff>();
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
            AddIngredient(ModContent.ItemType<NovaFragment>(), 10).
            AddTile(TileID.LunarCraftingStation).
            Register();
    }
}
