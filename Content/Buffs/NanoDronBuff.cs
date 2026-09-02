using Terraria;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles.Minions;

namespace TremorMod.Content.Buffs;

public class NanoDronBuff : ModBuff
{
    int MinionType = -1;
    int MinionID = -1;

    public override void SetStaticDefaults()
    {
        Main.buffNoTimeDisplay[Type] = true;
        //DisplayName.SetDefault("Nano Dron");
        //Description.SetDefault("Summons a dron that destroys your enemies");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        if (MinionType == -1)
            MinionType = ModContent.ProjectileType<NanoDronPro>();

        // Ïðîâåðÿåì íàëè÷èå àêòèâíîãî ìèíüîíà
        if (MinionID == -1 ||
            !Main.projectile[MinionID].active ||
            Main.projectile[MinionID].type != MinionType ||
            Main.projectile[MinionID].owner != player.whoAmI)
        {
            // Ñîçäàåì èñòî÷íèê äåéñòâèÿ êîððåêòíî
            IEntitySource source = player.GetSource_Buff(buffIndex);

            // Âûçûâàåì íîâîãî ìèíüîíà
            MinionID = Projectile.NewProjectile(
                source,             // Èñòî÷íèê äåéñòâèÿ
                player.Center,       // Ïîçèöèÿ
                Vector2.Zero,        // Ñêîðîñòü
                MinionType,          // Òèï ìèíüîíà
                50,                  // Óðîí
                1f,                  // Îòáðîñ
                player.whoAmI        // Âëàäåëåö
            );
        }
        else
        {
            // Îáíîâëÿåì âðåìÿ æèçíè ìèíüîíà
            Main.projectile[MinionID].timeLeft = 5;
        }
    }
}
