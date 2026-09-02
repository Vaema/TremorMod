using Terraria;
using Terraria.ModLoader;
using TremorMod.Utilities;
using TremorMod.Content.Buffs;
using Terraria.ID;

namespace TremorMod.Content.Items.Accessories;

	public class AlchemistGlove : ModItem
	{
		/*public override bool CanEquipAccessory(Player player, int slot)
		{
			for (int i = 0; i < player.armor.Length; i++)
			{
				MPlayer modPlayer = (MPlayer)player.GetModPlayer(mod, "MPlayer");
				if (modPlayer.glove)
				{
					return false;
				}
			}
			return true;
		}*/

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 38;

			Item.value = 1500000;
			Item.rare = ItemRarityID.Lime;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Master Alchemist Glove");
			// Tooltip.SetDefault("Alchemic weapons throw two flasks instead of one");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
        MPlayer modPlayer = player.GetModPlayer<MPlayer>();
        player.AddBuff(ModContent.BuffType<AlchemistGloveBuff>(), 2);
        modPlayer.glove = true;
    }
	}
