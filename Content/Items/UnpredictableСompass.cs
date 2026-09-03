using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items;

public class UnpredictableСompass : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 44;
        Item.height = 48;
        Item.useTime = Item.useAnimation = 30;
        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.knockBack = 0;
        Item.value = 240000;
        Item.rare = ItemRarityID.Cyan;
        Item.expert = true;
        Item.UseSound = SoundID.Item6;
    }

    public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
    {
        player.TeleportationPotion();
        return false;
    }
}
