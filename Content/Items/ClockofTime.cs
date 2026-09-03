using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items;

public class ClockofTime : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 16;
        Item.height = 16;
        Item.value = 1000;
        Item.rare = ItemRarityID.Pink;
        Item.useTurn = true;
        Item.autoReuse = false;
        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.maxStack = 1;
        Item.mana = 100;
        Item.UseSound = SoundID.Item8;
    }

    public override bool? UseItem(Player player)
    {
        if (player.altFunctionUse == 2)
        {
            Main.bloodMoon = true;
            return true;
        }

        if (Main.netMode != NetmodeID.MultiplayerClient)
        {
            Main.dayTime = !Main.dayTime;
            Main.time = (Main.dayTime ? 10000f : 0f);
            return true;
        }

        return true;
    }

    public override bool AltFunctionUse(Player player) => true;
}
