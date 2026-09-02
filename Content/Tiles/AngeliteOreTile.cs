using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Tiles;

public class AngeliteOreTile : ModTile
{
    public override void SetStaticDefaults()
    {
        TileID.Sets.Ore[Type] = true;
        // Óñòàíàâëèâàåì áàçîâûå ñâîéñòâà ïëèòêè
        Main.tileSolid[Type] = true;
        Main.tileMergeDirt[Type] = true;
        Main.tileBlockLight[Type] = true;
        Main.tileLighted[Type] = true;

        // Çàäà¸ì òèï ïûëè, êîòîðàÿ áóäåò ãåíåðèðîâàòüñÿ ïðè ðàçðóøåíèè ïëèòêè
        DustType = DustID.Enchanted_Gold;

        // Çàäà¸ì çâóê äëÿ ðàçðóøåíèÿ ïëèòêè
        HitSound = SoundID.Tink;  // Óñòàíîâèì çâóê ðàçðóøåíèÿ

        // Çàäà¸ì ñîïðîòèâëåíèå ðàçðóøåíèþ è ìèíèìàëüíóþ êèðêó
        MineResist = 15f;          // Óðîâåíü ñîïðîòèâëåíèÿ ðàçðóøåíèþ ïëèòêè
        MinPick = 250;             // Ìèíèìàëüíûé óðîâåíü êèðêè äëÿ ðàçðóøåíèÿ ïëèòêè

        // Äîáàâëÿåì ïëèòêó íà êàðòó ñ óêàçàííûì öâåòîì
        AddMapEntry(new Color(0, 191, 255), CreateMapEntryName());
    }

    public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0f;
        g = 0.3f;
        b = 0.9f;
    }
}
