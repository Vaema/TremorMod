using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Key;

public class Key : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 32;
        Item.height = 18;
        Item.rare = ItemRarityID.Blue;
    }
}