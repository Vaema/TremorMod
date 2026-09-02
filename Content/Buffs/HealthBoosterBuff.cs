using Terraria;
using Terraria.ModLoader;

namespace TremorMod.Content.Buffs;

public class HealthBoosterBuff : ModBuff
{
    public override void Update(Player player, ref int buffIndex)
    {
        if (!ModContent.GetInstance<TremorConfig>().AllowHealthBuffsTogether && player.HasBuff(ModContent.BuffType<ExtendedHealthBooster>()))
        {
            player.DelBuff(buffIndex);
            buffIndex--; // Êîððåêòíîå óäàëåíèå áàôôà
            return;
        }
        if (player.buffTime[buffIndex] == 0)
        {
            player.statLife += 100;
            player.HealEffect(100);
            player.AddBuff(ModContent.BuffType<HealthBoosterBuff>(), 3600);
        }
    }
}
