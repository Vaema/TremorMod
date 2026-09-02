using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items.AndasItems;

	public class VulcanBlade : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 545;
			Item.DamageType = DamageClass.Melee;
			Item.width = 46;
			Item.height = 48;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.shoot = ModContent.ProjectileType<VulcanBladePro>();
			Item.shootSpeed = 12f;
			Item.value = 600000;
			Item.rare = 0;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;
			Item.useTurn = false;
		}

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
}
