using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;
using TremorMod.Content.NPCs.Bosses.Rukh;

namespace TremorMod.Content.Items.BossSumonItems;

	public class DesertCrown : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 24;
			Item.height = 16;
			Item.maxStack = 20;

			Item.rare = ItemRarityID.Green;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.value = 50000;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{

		}

    public override bool CanUseItem(Player player)
    {
        //if (Romert.romertActive)
        //{
        //    return !NPC.AnyNPCs(ModContent.NPCType<Rukh>()) && player.ZoneDesert;
        //}
        return !NPC.AnyNPCs(ModContent.NPCType<npcVultureKing>()) && player.ZoneDesert;
    }

    public override bool? UseItem(Player player)
    {
        NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<npcVultureKing>());

        SoundEngine.PlaySound(SoundID.Roar, player.position);
        return true;
    }

    public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldCrown);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 3);
			recipe.AddIngredient(ItemID.SandBlock, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ItemID.PlatinumCrown);
			recipe1.AddIngredient(ItemID.AntlionMandible, 5);
			recipe1.AddIngredient(ModContent.ItemType<AntlionShell>(), 3);
			recipe1.AddIngredient(ItemID.SandBlock, 15);
			recipe1.AddTile(TileID.Anvils);
			recipe1.Register();
		}
	}
