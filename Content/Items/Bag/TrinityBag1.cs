using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using TremorMod.Content.Items.Weapons.Ranged;
using TremorMod.Content.Items.Weapons.Magic;
using TremorMod.Content.Items.Vanity;
using TremorMod.Content.Items.Materials;
using Terraria.ID;

namespace TremorMod.Content.Items.Bag;

public class TrinityBag1 : ModItem
{
    public override void SetDefaults()
    {
        Item.maxStack = 9999;
        Item.consumable = true;
        Item.width = 24;
        Item.height = 24;
        Item.rare = ItemRarityID.Cyan;
        Item.expert = true;
    }

    public override bool CanRightClick()
    {
        return true;
    }

    public override void ModifyItemLoot(ItemLoot itemLoot)
    {
        itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TruthMask>(), 3));

        itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrebleClef>(), 3));

        itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Revolwar>(), 3));

        itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<UnpredictableСompass>(), 3));

        itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<OmnikronBar>(), 1, 20, 36));

        itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueEssense>(), 1, 10, 25));
    }
}