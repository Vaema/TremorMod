using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Buffs;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items;

public class HauntHat : ModItem
{
    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.Carrot);
        Item.useTime = Item.useAnimation = 25;
        Item.shoot = ModContent.ProjectileType<TheHauntPro>();
        Item.buffType = ModContent.BuffType<HauntPetBuff>();
    }

    public override void UseStyle(Player player, Rectangle heldItemFrame)
    {
        if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            player.AddBuff(Item.buffType, 3600);
    }
}
