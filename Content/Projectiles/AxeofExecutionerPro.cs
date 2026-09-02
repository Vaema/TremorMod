using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class AxeofExecutionerPro : ModProjectile
	{
    public override void SetDefaults()
    {
        // Êîïèðóåì ïàðàìåòðû ïîâåäåíèÿ ñíàðÿäà ñ ID 182
        Projectile.CloneDefaults(182);

        // Çàäàåì ðàçìåðû ñíàðÿäà
        Projectile.width = 29;
        Projectile.height = 29;

        // Óêàçûâàåì AIType (ñíàðÿä, íà êîòîðûé îðèåíòèðóåòñÿ ëîãèêà ïîâåäåíèÿ)
        AIType = ProjectileID.PossessedHatchet; // Óáåäèòåñü, ÷òî 182 — ýòî ñóùåñòâóþùèé ID ñíàðÿäà, ñ êîòîðûì âû õîòèòå ñðàâíÿòüñÿ
    }


    /*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("AxeofExecutioner");
		}*/
}
