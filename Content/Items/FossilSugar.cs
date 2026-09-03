using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Mounts;

namespace TremorMod.Content.Items;

public class FossilSugar : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 28;
        Item.height = 30;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 6;
        Item.value = 30000;
        Item.rare = ItemRarityID.Green;
        Item.UseSound = SoundID.Item79;
        Item.mountType = ModContent.MountType<Antlion>();
    }
}
