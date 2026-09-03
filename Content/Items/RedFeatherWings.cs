using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items;

[AutoloadEquip(EquipType.Wings)]
public class RedFeatherWings : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 22;
        Item.height = 20;
        Item.value = 100000;
        Item.rare = ItemRarityID.Pink;
        Item.accessory = true;
    }

    public override void SetStaticDefaults() =>
        ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(140, 6f, 1f);

    public override void UpdateAccessory(Player player, bool hideVisual) =>
        player.wingTimeMax = 140;

    public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
        ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
    {
        ascentWhenFalling = 0.85f;
        ascentWhenRising = 0.15f;
        maxCanAscendMultiplier = 1f;
        maxAscentMultiplier = 3f;
        constantAscend = 0.135f;
    }

    public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
    {
        speed = 6f;
        acceleration *= 2.5f;
    }

    public override void AddRecipes()
    {
        CreateRecipe().
            AddIngredient(ModContent.ItemType<RedFeather>(), 1).
            AddIngredient(ItemID.SoulofFlight, 20).
            AddTile(TileID.MythrilAnvil).
            Register();
    }
}
