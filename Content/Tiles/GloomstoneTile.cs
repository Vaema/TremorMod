using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Tiles;

	public class GloomstoneTile : ModTile
	{
    public override void SetStaticDefaults()
    {
        Main.tileSolid[Type] = true; // Ïëèòêà ÿâëÿåòñÿ òâåðäîé.
        Main.tileMergeDirt[Type] = true; // Ñëèâàåòñÿ ñ ãðÿçüþ.
        Main.tileBlockLight[Type] = true; // Áëîêèðóåò ñâåò.
        Main.tileLighted[Type] = true; // Îñâåùàåòñÿ.
        //ItemDrop = ModContent.ItemType<GloomstoneItem>(); // Âûïàäàþùèé ïðåäìåò.
        HitSound = SoundID.Tink; // Çâóê ïðè ðàçðóøåíèè.
        AddMapEntry(new Color(36, 118, 174));
    }

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
