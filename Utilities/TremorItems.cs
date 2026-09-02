using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Utilities;

	public class TremorItems : GlobalItem
	{

		public override void UpdateEquip(Item item, Player player)
		{
			//items damage
			if (item.type == ItemID.CelestialStone)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == ItemID.CelestialShell)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == ItemID.SunStone)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == ItemID.MoonStone)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == ItemID.AvengerEmblem)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.12f;
			}
			if (item.type == ItemID.DestroyerEmblem)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == ItemID.HallowedGreaves)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.07f;
			}
			if (item.type == ItemID.PalladiumBreastplate)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.03f;
			}
			if (item.type == ItemID.PalladiumLeggings)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.02f;
			}
			if (item.type == ItemID.MythrilChainmail)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.05f;
			}
			if (item.type == ItemID.AdamantiteBreastplate)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.06f;
			}
			if (item.type == ItemID.TitaniumBreastplate)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.04f;
			}
			if (item.type == ItemID.TitaniumLeggings)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.03f;
			}
			if (item.type == ItemID.ChlorophytePlateMail)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.05f;
			}
			//items crit chance
			if (item.type == ItemID.CobaltBreastplate)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 3;
			}
			if (item.type == ItemID.PalladiumBreastplate)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 2;
			}
			if (item.type == ItemID.PalladiumLeggings)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 1;
			}
			if (item.type == ItemID.MythrilGreaves)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 5;
			}
			if (item.type == ItemID.OrichalcumBreastplate)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 6;
			}
			if (item.type == ItemID.AdamantiteLeggings)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 4;
			}
			if (item.type == ItemID.TitaniumBreastplate)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 3;
			}
			if (item.type == ItemID.TitaniumLeggings)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 3;
			}
			if (item.type == ItemID.MonkPants)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 10;
			}
			if (item.type == ItemID.HallowedPlateMail)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 7;
			}
			if (item.type == ItemID.ChlorophytePlateMail)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 7;
			}
			if (item.type == ItemID.TurtleScaleMail)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 8;
			}
			if (item.type == ItemID.SquireAltPants)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 30;
			}
		}

		public override void SetDefaults(Item item)
		{
			/* WRONG -- TODO: Remove this buff or actually code it correctly
			if (item.ranged && Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].FindBuffIndex(mod.BuffType("ShotSpeedBuff")) != -1)
			{
				item.shootSpeed *= 2f;
			}
			if (item.ranged && Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].FindBuffIndex(mod.BuffType("ShotSpeedBuff")) != -1)
			{
				item.shootSpeed *= 2f;
			}
			*/
			if (item.type == ItemID.LivingLoom)
			{
				item.value = 30;
			}
			if (item.type == ItemID.Minishark)
			{
				item.value = 500000;
			}
			if (item.type == ItemID.StoneBlock)
			{

			}
			/* WRONG -- TODO: Remove this buff or actually code it correctly
			if (item.type == ItemID.EnchantedSword && Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].FindBuffIndex(mod.BuffType("EnchantedBuff")) != -1)
			{
				item.damage += 5;
			}
			if (item.type == ItemID.EnchantedBoomerang && Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].FindBuffIndex(mod.BuffType("EnchantedBuff")) != -1)
			{
				item.damage += 5;
			}
			*/
			if (item.type == ItemID.SlimeStaff)
			{
				item.value = 2000;
			}
		}
	}