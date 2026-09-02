using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Accessories;

	public class EtherealFeather : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 44;
			Item.value = 1000;
			Item.rare = ItemRarityID.Orange;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Ethereal Feather");
			//Tooltip.SetDefault("Allows you to fall slowly");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.slowFall = true;
		}
	}