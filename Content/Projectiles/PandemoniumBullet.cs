using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class PandemoniumBullet : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.CloneDefaults(14);
			Projectile.light = 0.5f;
			Projectile.width = 1;
			Projectile.height = 1;
			Projectile.extraUpdates = 1;
			Projectile.alpha = 255;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
			//AiType = ProjectileID.Bullet;
		}

    /*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pandemonium Bullet");
		}*/

    const int ShootDirection = 7;
    public override void OnKill(int timeLeft)
    {
        // Èñòî÷íèê ñîçäàíèÿ ïðîåêòèëÿ — èñïîëüçîâàíèå EntitySource_Death, êîòîðûé ïðèìåíèì â äàííîì ñëó÷àå
        var source = new Terraria.DataStructures.EntitySource_Death(Projectile);

        // Ïîçèöèÿ ïðîåêòèëÿ
        Vector2 startPosition = Projectile.position + new Vector2(40, 40);

        // Ñîçäàíèå ïðîåêòèëåé â ðàçíûõ íàïðàâëåíèÿõ
        int[] projectiles =
        [
            Projectile.NewProjectile(source, startPosition, new Vector2(-ShootDirection, 0), ProjectileID.ApprenticeStaffT3Shot, 50, 1f, Main.myPlayer),
            Projectile.NewProjectile(source, startPosition, new Vector2(ShootDirection, 0), ProjectileID.ApprenticeStaffT3Shot, 50, 1f, Main.myPlayer),
            Projectile.NewProjectile(source, startPosition, new Vector2(0, ShootDirection), ProjectileID.ApprenticeStaffT3Shot, 50, 1f, Main.myPlayer),
            Projectile.NewProjectile(source, startPosition, new Vector2(0, -ShootDirection), ProjectileID.ApprenticeStaffT3Shot, 50, 1f, Main.myPlayer),
            Projectile.NewProjectile(source, startPosition, new Vector2(-ShootDirection, -ShootDirection), ProjectileID.ApprenticeStaffT3Shot, 50, 1f, Main.myPlayer),
            Projectile.NewProjectile(source, startPosition, new Vector2(ShootDirection, -ShootDirection), ProjectileID.ApprenticeStaffT3Shot, 50, 1f, Main.myPlayer),
            Projectile.NewProjectile(source, startPosition, new Vector2(-ShootDirection, ShootDirection), ProjectileID.ApprenticeStaffT3Shot, 50, 1f, Main.myPlayer),
            Projectile.NewProjectile(source, startPosition, new Vector2(ShootDirection, ShootDirection), ProjectileID.ApprenticeStaffT3Shot, 50, 1f, Main.myPlayer),
        ];

        // Íàñòðîéêà ñîçäàííûõ ïðîåêòèëåé
        foreach (int proj in projectiles)
        {
            if (proj >= 0) // Ïðîâåðêà, ÷òî ïðîåêòèëü áûë óñïåøíî ñîçäàí
            {
                Main.projectile[proj].friendly = true;
                Main.projectile[proj].tileCollide = false;
                Main.projectile[proj].timeLeft = 120;
            }
        }
    }


}
/*public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
{
    Vector2 drawOrigin = new Vector2(Main.ProjectileTexture[Projectile.type].Width * 0.5f, Projectile.height * 0.5f);
    for (int k = 0; k < Projectile.oldPos.Length; k++)
    {
        Vector2 drawPos = Projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, Projectile.gfxOffY);
        Color color = Projectile.GetAlpha(lightColor) * ((Projectile.oldPos.Length - k) / (float)Projectile.oldPos.Length);
        spriteBatch.Draw(Main.ProjectileTexture[Projectile.type], drawPos, null, color, Projectile.rotation, drawOrigin, Projectile.scale, SpriteEffects.None, 0f);
    }
    return true;
}*/

