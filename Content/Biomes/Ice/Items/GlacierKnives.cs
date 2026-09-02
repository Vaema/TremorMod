using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Biomes.Ice.Items;

	public class GlacierKnives : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 32;
			Item.DamageType = DamageClass.Magic;
			Item.width = 36;
			Item.mana = 11;
			Item.height = 46;
			Item.useTime = 19;
			Item.useAnimation = 19;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			Item.knockBack = 5;
			Item.value = 10000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<GlacierKnivesProj>();
        Item.shootSpeed = 10f;

    }

    public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Glacier Knives");
			//Tooltip.SetDefault("Spreads out glacier knives");

		}

    public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
    {
        int ShotAmt = 5; // Êîëè÷åñòâî âûñòðåëîâ
        int spread = 15; // Ìàêñèìàëüíîå îòêëîíåíèå
        float spreadMult = 0.35f; // Êîýôôèöèåíò ìíîæèòåëÿ îòêëîíåíèÿ

        for (int i = 0; i < ShotAmt; i++)
        {
            // Ãåíåðàöèÿ îòêëîíåíèÿ ñêîðîñòè
            float vX = velocity.X + Main.rand.NextFloat(-spread, spread) * spreadMult;
            float vY = velocity.Y + Main.rand.NextFloat(-spread, spread) * spreadMult;

            // Ïîçèöèÿ ïîÿâëåíèÿ ñíàðÿäà
            Vector2 spawnPosition = position + Vector2.Normalize(velocity) * 40f;

            // Ñîçäàíèå íîâîãî ñíàðÿäà
            Projectile.NewProjectile(source, spawnPosition, new Vector2(vX, vY), ModContent.ProjectileType<GlacierKnivesProj>(), damage, knockback, player.whoAmI);
        }

        return false; // Ïðåäîòâðàùàåò ñòàíäàðòíûé âûñòðåë
    }

}
