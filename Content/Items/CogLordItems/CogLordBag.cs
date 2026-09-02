using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;

namespace TremorMod.Content.Items.CogLordItems;

	public class CogLordBag : ModItem
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

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}*/

		public override bool CanRightClick()
		{
			return true;
		}

    public override void ModifyItemLoot(ItemLoot itemLoot)
    {
        // Guarantee one item from the following three
        itemLoot.Add(ItemDropRule.OneFromOptions(1,
            ModContent.ItemType<BrassStave>(),
            ModContent.ItemType<BrassChainRepeater>(),
            ModContent.ItemType<BrassRapier>()
        ));

        // Add CyberStaff drop only in Expert mode
        itemLoot.Add(ItemDropRule.ByCondition(new Conditions.IsExpert(), ModContent.ItemType<HeatCore>()));

			// Add CyberKingMask with a 1/7 chance
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CogLordMask>(), 7));
        itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrassChip>(), 10));

        // Add other drops as necessary
        itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrassNugget>(),1, 18, 34));
    }
}
