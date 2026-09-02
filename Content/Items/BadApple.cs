using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;
using TremorMod.Content.Buffs;

namespace TremorMod.Content.Items;

	public class BadApple : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.shoot = ModContent.ProjectileType<GurdPet>();
			Item.buffType = ModContent.BuffType<GurdPetBuff>();
		}

    /*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bad Apple");
			Tooltip.SetDefault("Summons a gurd pet");
		}*/

    public override bool? UseItem(Player player)
    {
        // Äîïîëíèòåëüíîå ïîâåäåíèå ïðè èñïîëüçîâàíèè
        if (player.whoAmI == Main.myPlayer)
        {
            player.AddBuff(Item.buffType, 3600, true); // Äîáàâëÿåì áàôô íà 60 ñåêóíä
        }
        return true; // Óêàçûâàåò, ÷òî äåéñòâèå âûïîëíåíî óñïåøíî
    }

}
