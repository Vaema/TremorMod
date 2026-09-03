using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;
using TremorMod.Content.Mounts;

namespace TremorMod.Content.Items;

public class DrippingSaddle : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 14;
        Item.height = 36;
        Item.useTime = 30;
        Item.useAnimation = 30;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.value = 8000;
        Item.rare = ItemRarityID.Orange;
        Item.UseSound = SoundID.Item44;
        Item.noMelee = true;
        Item.mountType = ModContent.MountType<DripplerMount>();
    }

    public override void AddRecipes()
    {
        CreateRecipe().
            AddIngredient(ItemID.GoldBar, 5).
            AddIngredient(ModContent.ItemType<AtisBlood>(), 10).
            AddIngredient(ModContent.ItemType<DrippingRoot>(), 15).
            AddTile(TileID.MythrilAnvil).
            Register();

        CreateRecipe().
            AddIngredient(ItemID.PlatinumBar, 5).
            AddIngredient(ModContent.ItemType<AtisBlood>(), 10).
            AddIngredient(ModContent.ItemType<DrippingRoot>(), 15).
            AddTile(TileID.MythrilAnvil).
            Register();
    }
}
