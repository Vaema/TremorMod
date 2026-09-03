using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items;

public class WarpPad : ModItem
{
    public override void SetDefaults()
    {
        Item.UseSound = SoundID.Item6;
        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.useAnimation = 30;
        Item.useTime = 30;
        Item.width = Item.height = 32;
        Item.value = 60000;
        Item.rare = ItemRarityID.Yellow;
        Item.mana = 10;
    }

    public override bool? UseItem(Player player)
    {
        if (player.lastDeathPostion != player.position && player.showLastDeath)
        {
            player.Teleport(player.lastDeathPostion, 1, 0);
            NetMessage.SendData(MessageID.TeleportEntity, -1, -1, null, 0, player.whoAmI, player.lastDeathPostion.X, player.lastDeathPostion.Y, 1, 0, 0);
            player.showLastDeath = false;
            return true;
        }
        return null;
    }

    public override bool CanUseItem(Player player)
    {
        if (!player.showLastDeath)
            return false;

        return true;
    }
}
