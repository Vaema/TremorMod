using Terraria;
using Terraria.ModLoader;

namespace TremorMod.Content.Biomes.Ice;

public class IceOreItem : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 12;
        Item.height = 12;
        Item.maxStack = 999;
        Item.useTurn = true;
        Item.autoReuse = true;
        Item.useAnimation = 15;
        Item.useTime = 10;
        Item.useStyle = 1;
        Item.consumable = true;
        Item.createTile = ModContent.TileType<IceOre>();
    }

    /*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Everfrost Block");
			Tooltip.SetDefault("");
		}*/
}
