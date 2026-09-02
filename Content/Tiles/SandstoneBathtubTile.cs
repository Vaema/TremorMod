using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using TremorMod.Content.Items.Placeable;

namespace TremorMod.Content.Tiles;

public class SandstoneBathtubTile : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileLavaDeath[Type] = true;

        TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2); // Ýòîò ñòèëü àâòîìàòè÷åñêè ó÷èòûâàåò íàïðàâëåíèå
        TileObjectData.newTile.CoordinateHeights = [16, 16];
        TileObjectData.addTile(Type);

        // Äîáàâëåíèå â ìàññèâû äëÿ ôóíêöèîíàëà êðîâàòè
        TileID.Sets.CanBeSleptIn[Type] = true; // Óêàçûâàåò, ÷òî ïëèòêà ìîæåò áûòü èñïîëüçîâàíà êàê êðîâàòü
        TileID.Sets.IsValidSpawnPoint[Type] = true; // Ïîçâîëÿåò óñòàíîâèòü òî÷êó âîçðîæäåíèÿ

        AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable); // Äîáàâëÿåò, ÷òîáû ïëèòêà ñ÷èòàëàñü êàê ñòîë (åñëè íóæíî)
        AddMapEntry(new Color(233, 211, 123), CreateMapEntryName());
    }

    public override void MouseOver(int i, int j)
    {
        Player player = Main.LocalPlayer;

        // Óêàçûâàåì, ÷òî èãðîê âçàèìîäåéñòâóåò ñ ïðåäìåòîì
        player.noThrow = 2;
        player.cursorItemIconEnabled = true;
        player.cursorItemIconID = ModContent.ItemType<SandstoneBathtub>(); // Óêàçûâàåì èêîíêó äëÿ îòîáðàæåíèÿ
    }

    // Ïåðåîïðåäåëèòå ìåòîä äëÿ îáðàáîòêè âçàèìîäåéñòâèÿ ñ êðîâàòüþ
  
}
