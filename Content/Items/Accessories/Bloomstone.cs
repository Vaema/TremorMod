using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Accessories;

	public class Bloomstone : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 28;
			Item.value = 50000;
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Bloomstone");
			//Tooltip.SetDefault("You are glowing during night");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{	
        player.AddBuff(BuffID.Shine, 600); // Áàôô äëèòñÿ 10 ñåêóíä (600 òèêîâ)
			player.AddBuff(BuffID.NightOwl, 600);			
		}
	}
