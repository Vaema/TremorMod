using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials.OreAndBar;
using TremorMod.Utilities;

namespace TremorMod.Content.Items.Armor.Invar;

[AutoloadEquip(EquipType.Body)]
internal class InvarBreastPlate : ModItem
{

    public override void SetStaticDefaults()
    {
        base.SetStaticDefaults();
        // Óêàçûâàåì òåêñòóðû òåëà è ðóê
        ArmorIDs.Body.Sets.HidesArms[Item.bodySlot] = false; // Ïîêàçûâàåì òåêñòóðó ðóê
        ArmorIDs.Body.Sets.HidesTopSkin[Item.bodySlot] = false; // Ïîêàçûâàåì âåðõíþþ ÷àñòü êîæè
    }


    public override void SetDefaults()
    {
			Item.width = 26;
			Item.height = 18;
			Item.value = Item.sellPrice(silver: 19);
			Item.rare = ItemRarityID.Blue;
			Item.defense = 3;
		}

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.GetModPlayer<MPlayer>().damageReduction += 0.03f; 
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<InvarBar>(), 18);
        //recipe.SetResult(this);
        recipe.AddTile((TileID.Anvils));
        recipe.Register();
    }

    /*public sealed override void SafeStaticDefaults()
		{
			DisplayName.SetDefault("Reinforced Invar Breastplate");
			Tooltip.SetDefault("Reinforced to grant +1 defense");
		}*/
}
