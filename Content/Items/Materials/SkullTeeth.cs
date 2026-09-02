using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class SkullTeeth : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 30;
			Item.maxStack = 9999;
			Item.value = 8000;
			Item.rare = ItemRarityID.LightPurple;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skull Teeth");
			Tooltip.SetDefault("'Hell yeah!'");
		}*/

	}
