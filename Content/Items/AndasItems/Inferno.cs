using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.AndasItems;

	public class Inferno : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 520;
			Item.width = 62;
			Item.height = 62;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 20;
        Item.shoot = ProjectileID.DD2PhoenixBowShot;
        Item.shootSpeed = 12f;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 4;
			Item.value = 600000;
			Item.rare = ItemRarityID.White;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
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
