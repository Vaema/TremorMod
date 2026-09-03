using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Buffs;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items;

public class GenieLamp : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 38;
        Item.height = 20;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.value = 40000;
        Item.rare = ItemRarityID.Green;
        Item.UseSound = SoundID.Item8;
        Item.autoReuse = false;
    }

    public override bool? UseItem(Player player)
    {
        player.AddBuff(ModContent.BuffType<petGenie>(), 2);
        for (int i = 0; i < Main.projectile.Length; i++)
        {
            if (Main.projectile[i].type == ModContent.ProjectileType<projGenie>() && Main.projectile[i].owner == Item.playerIndexTheItemIsReservedFor)
                Main.projectile[i].Center = Main.player[Item.playerIndexTheItemIsReservedFor].Center;
        }

        return true;
    }
}
