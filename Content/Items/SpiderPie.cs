using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Buffs;
using TremorMod.Content.Mounts;

namespace TremorMod.Content.Items;

public class SpiderPie : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 28;
        Item.height = 30;
        Item.useTime = Item.useAnimation = 20;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 6;
        Item.value = 30000;
        Item.rare = ItemRarityID.Green;
        Item.UseSound = SoundID.Item79;
        Item.noMelee = true;
        Item.mountType = ModContent.MountType<Spider>();
    }

    public override void AddRecipes()
    {
        CreateRecipe().
            AddIngredient(ItemID.Bowl).
            AddIngredient(ModContent.ItemType<SpiderMeat>(), 15).
            AddIngredient(ItemID.Cobweb, 100).
            AddTile(TileID.Furnaces).
            Register();
    }
}
