using Terraria.GameContent.ItemDropRules;

namespace TremorMod.Utilities;

public class MissingItemCondition : IItemDropRuleCondition
{
    private readonly int itemType;

    public MissingItemCondition(int itemType)
    {
        this.itemType = itemType;
    }

    public bool CanDrop(DropAttemptInfo info)
    {
        if (info.player == null)
            return false;

        for (int i = 0; i < info.player.inventory.Length; i++)
        {
            if (info.player.inventory[i].type == itemType)
                return false;
        }

        return true;
    }

    public bool CanShowItemDropInUI() => true;

    public string GetConditionDescription() => null;
}
