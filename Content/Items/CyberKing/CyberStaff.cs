using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles.Minions;
using TremorMod.Content.Buffs;

namespace TremorMod.Content.Items.CyberKing;

public class CyberStaff : ModItem
{
    public override void SetDefaults()
    {
        Item.damage = 62;
        Item.DamageType = DamageClass.Summon;
        Item.mana = 15;
        Item.width = 26;
        Item.height = 28;
        Item.expert = true;
        Item.useTime = 36;
        Item.useAnimation = 36;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.knockBack = 3;
        Item.value = Item.buyPrice(0, 3, 0, 0);
        Item.rare = ItemRarityID.Lime;
        Item.UseSound = SoundID.Item44;
        Item.shoot = ModContent.ProjectileType<CyberStaffPro>();
        Item.shootSpeed = 2f;
        Item.buffType = ModContent.BuffType<CyberSawBuff>();
        Item.buffTime = 3600;
    }

    public override bool AltFunctionUse(Player player)
    {
        return true; // Âîçâðàùàåì true, åñëè èãðîê èñïîëüçóåò àëüòåðíàòèâíóþ êíîïêó
    }

    public override bool? UseItem(Player player)
    {
        // Ëîãèêà äëÿ àêòèâàöèè àëüòåðíàòèâíîãî ïîâåäåíèÿ
        if (player.altFunctionUse == 2)
        {
            player.MinionNPCTargetAim(false); // Äåëàåì öåëü äëÿ ìèíüîíà, íå èãíîðèðóÿ, åñëè öåëü íå èçìåíèëàñü
        }
        return base.UseItem(player); // Âîçâðàùàåì ñòàíäàðòíîå ïîâåäåíèå, ñîõðàíÿÿ òèï bool?
    }


    public override void HoldItem(Player player)
    {
        // Ëîãèêà äëÿ îáû÷íîãî èñïîëüçîâàíèÿ
        if (player.altFunctionUse != 2)
        {
            base.HoldItem(player);
        }
    }
}
