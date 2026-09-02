using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Biomes.Ruins.Items;

public class RuinKey : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 18;
        Item.height = 32;
        Item.maxStack = 99;
        Item.value = 3000;
        Item.rare = ItemRarityID.LightRed;
    }
}
