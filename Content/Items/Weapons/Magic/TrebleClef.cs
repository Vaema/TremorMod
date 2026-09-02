using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Magic;

	public class TrebleClef : ModItem
	{
		public override void SetDefaults()
		{

			Item.mana = 6;
			Item.noMelee = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.damage = 362;
			Item.autoReuse = true;
			Item.useAnimation = 12;
			Item.useTime = 12;
			Item.width = 40;
			Item.height = 40;
			Item.shoot = ProjectileID.QuarterNote;
			Item.shootSpeed = 6f;
			Item.knockBack = 6f;
			Item.value = Item.sellPrice(0, 40, 0, 0);
			Item.DamageType = DamageClass.Magic;
			Item.noMelee = true;
			Item.rare = ItemRarityID.White;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Treble Clef");
			// Tooltip.SetDefault("");
		}

    public override void ModifyTooltips(List<TooltipLine> tooltips)
    {
        foreach (var tooltip in tooltips)
        {
            if (tooltip.Mod == "Terraria" && tooltip.Name == "ItemName")
            {
                tooltip.OverrideColor = new Color(238, 194, 73);
            }
        }
    }

    public override Vector2? HoldoutOffset()
		{
			return new Vector2(-28, -9);
		}
	}
