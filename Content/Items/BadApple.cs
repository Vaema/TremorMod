using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Buffs;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items;

public class BadApple : ModItem
{
    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.Carrot);
        Item.useTime = 25;
        Item.useAnimation = 25;
        Item.shoot = ModContent.ProjectileType<GurdPet>();
        Item.buffType = ModContent.BuffType<GurdPetBuff>();
    }

    public override bool? UseItem(Player player)
    {
        if (player.whoAmI == Main.myPlayer)
            player.AddBuff(Item.buffType, 3600, true);

        return true;
    }
}
