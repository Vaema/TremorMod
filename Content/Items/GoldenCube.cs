using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Buffs;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items;

public class GoldenCube : ModItem
{
    public override void SetDefaults()
    {
        Item.CloneDefaults(ItemID.Carrot);
        Item.useTime = Item.useAnimation = 25;
        Item.shoot = ModContent.ProjectileType<GoldenWhalePro>();
        Item.buffType = ModContent.BuffType<GoldenWhale>();
    }

    public override bool? UseItem(Player player)
    {
        player.AddBuff(ModContent.BuffType<GoldenWhale>(), 2);
        for (int i = 0; i < Main.projectile.Length; i++)
        {
            if (Main.projectile[i].type == ModContent.ProjectileType<GoldenWhalePro>() && Main.projectile[i].owner == Item.playerIndexTheItemIsReservedFor)
                Main.projectile[i].Center = Main.player[Item.playerIndexTheItemIsReservedFor].Center;
        }

        return true;
    }
}
