using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.NPCs.Bosses.NovaPillar;

public class NovaPilarSummon : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 32; // Øèðèíà ñïðàéòà
        Item.height = 32; // Âûñîòà ñïðàéòà
        Item.useStyle = ItemUseStyleID.HoldUp; // Àíèìàöèÿ èñïîëüçîâàíèÿ
        Item.useTime = 20; // Âðåìÿ èñïîëüçîâàíèÿ
        Item.useAnimation = 20; // Àíèìàöèÿ èñïîëüçîâàíèÿ
        Item.rare = ItemRarityID.Red; // Ðåäêîñòü ïðåäìåòà
        Item.value = Item.sellPrice(0, 5, 0, 0); // Öåíà ïðåäìåòà
        Item.consumable = true; // Èñïîëüçóåòñÿ ëè ïðåäìåò (ñîõðàíÿåòñÿ/èñ÷åçàåò ïîñëå èñïîëüçîâàíèÿ)
        Item.maxStack = 20; // Ìàêñèìàëüíîå êîëè÷åñòâî â ñòàêå
    }

    public override bool CanUseItem(Player player)
    {
        // Ïðîâåðÿåì, ìîæíî ëè èñïîëüçîâàòü ïðåäìåò
        if (NPC.AnyNPCs(ModContent.NPCType<NovaPillar>()))
        {
            Main.NewText("A Nova Pillar already exists in this world!", Color.Red);
            return false; // Åñëè NovaPillar óæå ñóùåñòâóåò, èñïîëüçîâàíèå ïðåäìåòà çàïðåùåíî
        }
        return true;
    }

    public override bool? UseItem(Player player)
    {
        // Îïðåäåëÿåì êîîðäèíàòû äëÿ ñïàâíà NovaPillar
        Vector2 spawnPos = player.Center + new Vector2(Main.rand.Next(-1600, 1600), -100); // Ïðèìåð ïîçèöèè íàä èãðîêîì

        int spawnNPC = NPC.NewNPC(new Terraria.DataStructures.EntitySource_ItemUse(player, Item),
            (int)spawnPos.X, (int)spawnPos.Y, ModContent.NPCType<NovaPillar>());

        if (spawnNPC < 200)
        {
            Main.NewText("The Nova Pillar has been summoned!", Color.Orange);
            return true; // Ïðåäìåò óñïåøíî èñïîëüçîâàí
        }
        else
        {
            Main.NewText("Failed to summon the Nova Pillar.", Color.Red);
            return false; // Îøèáêà ïðè èñïîëüçîâàíèè
        }
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.FragmentVortex, 10);
        recipe.AddIngredient(ItemID.FragmentNebula, 10);
        recipe.AddIngredient(ItemID.FragmentSolar, 10);
        //recipe.AddIngredient(3459, 1);
        //recipe.SetResult(this);
        recipe.AddTile(TileID.LunarCraftingStation);
        recipe.Register();

        Recipe recipe1 = CreateRecipe();
        recipe1.AddIngredient(ItemID.FragmentVortex, 10);
        recipe1.AddIngredient(ItemID.FragmentNebula, 10);
        recipe1.AddIngredient(ItemID.FragmentStardust, 10);
        recipe1.AddTile(TileID.LunarCraftingStation);
        recipe1.Register();

        Recipe recipe2 = CreateRecipe();
        recipe2.AddIngredient(ItemID.FragmentVortex, 10);
        recipe2.AddIngredient(ItemID.FragmentStardust, 10);
        recipe2.AddIngredient(ItemID.FragmentSolar, 10);
        recipe2.AddTile(TileID.LunarCraftingStation);
        recipe2.Register();

        Recipe recipe3 = CreateRecipe();
        recipe3.AddIngredient(ItemID.FragmentStardust, 10);
        recipe3.AddIngredient(ItemID.FragmentNebula, 10);
        recipe3.AddIngredient(ItemID.FragmentSolar, 10);
        recipe3.AddTile(TileID.LunarCraftingStation);
        recipe3.Register();
    }
}