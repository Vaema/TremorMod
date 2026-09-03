using Terraria;
using Terraria.ModLoader;

namespace TremorMod.Utilities;

public class AlchemicalClass : DamageClass
{
    public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
    {
        if (damageClass == Generic)
            return StatInheritanceData.Full;

        return new StatInheritanceData(
            damageInheritance: 0f,
            critChanceInheritance: 0f,
            attackSpeedInheritance: 0f,
            armorPenInheritance: 0f,
            knockbackInheritance: 0f
        );
    }

    public override bool GetEffectInheritance(DamageClass damageClass)
    {
        if (damageClass == Melee)
            return true;
        if (damageClass == Magic)
            return true;

        return false;
    }

    public override bool UseStandardCritCalcs => true;

    public override bool ShowStatTooltipLine(Player player, string lineName)
    {
        if (lineName == "Speed")
            return false;

        return true;
    }
}
