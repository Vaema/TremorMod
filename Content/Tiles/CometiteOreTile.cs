using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;
using TremorMod.Content.Items.Materials;
using Terraria.ID;

namespace TremorMod.Content.Tiles;

	public class CometiteOreTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;                   
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			DustType = DustID.Shadowflame;
			AddMapEntry(new Color(0, 191, 255), CreateMapEntryName());
			MineResist = 8f;
			MinPick = 225;
		}

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        if (Utils.NextBool(Main.rand, 10))
        {
            // Ñîçäàéòå èñòî÷íèê äëÿ ñîáûòèÿ (ðàçðóøåíèå ïëèòêè)
            IEntitySource source = new EntitySource_TileBreak(i, j);

            // Ñîçäàåì ïðåäìåò ñ èñïîëüçîâàíèåì IEntitySource è êîîðäèíàò â âèäå Vector2
            Item.NewItem(source, i * 16, j * 16, 16, 16, ModContent.ItemType<ChargedCrystal>());
        }
    }


    public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.0f;
			b = 0.7f;
		}
	}