using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items.AndasItems;

	public class HellStorm : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 220;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 32;
			Item.height = 78;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			Item.channel = true;
			Item.knockBack = 5f;
			Item.value = 10000000;
			Item.rare = ItemRarityID.White;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<HellStormProj>();
			Item.shootSpeed = 20f;
			Item.useAmmo = AmmoID.Arrow;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hell Storm");
			Tooltip.SetDefault("Shoots out homing hell arrows\n" +
			"The amount of arrows shot increases when used for longer time");
		}*/

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			foreach (var tooltip in tooltips)
			{
				// Ìåíÿåì öâåò òåêñòà äëÿ íàçâàíèÿ ïðåäìåòà
				if (tooltip.Mod == "Terraria" && tooltip.Name == "ItemName")
				{
					tooltip.OverrideColor = new Color(238, 194, 73); // Öâåò çîëîòà
				}
			}
		}

    public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
    {
        // Ñìåùåíèå ïîçèöèè ïðè ñòðåëüáå
        Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
        position += muzzleOffset;

        // Ñîçäàåì êàñòîìíûé ñíàðÿä
        Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<HellStormProj>(), damage, knockback, player.whoAmI);

        return false; // Îòêëþ÷àåì ñòàíäàðòíûé âûñòðåë
    }
}
