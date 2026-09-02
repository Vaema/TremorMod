using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Utilities;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.NPCs;

	public class Phabor : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Phabor");
			Main.npcFrameCount[NPC.type] = 4;
		}

		const int ShootRate = 500;
		const int ShootDamage = 20;
		const float ShootKN = 1.0f;
		const float ShootSpeed = 4;

		int TimeToShoot = 0;

		public override void SetDefaults()
		{
			NPC.lifeMax = 420;
			NPC.damage = 30;
			NPC.defense = 12;
			NPC.knockBackResist = 0f;
			NPC.width = 75;
			NPC.height = 75;
			AnimationType = NPCID.Wraith;
			NPC.aiStyle = NPCAIStyleID.HoveringFighter;
			NPC.npcSlots = 0.5f;
			NPC.noTileCollide = true;
			NPC.HitSound = SoundID.NPCHit31;
			NPC.noGravity = true;
			NPC.DeathSound = SoundID.NPCDeath6;
			NPC.value = Item.buyPrice(0, 0, 55, 9);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("PhaborBanner");

			TimeToShoot = 0;
		}

		public override void AI()
		{
			if (Main.netMode != NetmodeID.MultiplayerClient && TimeToShoot++ >= ShootRate && NPC.target != -1)
			{
				Vector2 velocity = Vector2.Normalize(Main.player[NPC.target].Center - NPC.Center) * ShootSpeed;
				Projectile.NewProjectile(NPC.GetSource_FromThis(), NPC.Center.X, NPC.Center.Y, velocity.X, velocity.Y, ProjectileID.CultistBossFireBallClone, ShootDamage, ShootKN);

				TimeToShoot = 0;
			}
		}

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Gloomstone>(), 1, 6, 12));
    }

    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("PhaborGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("PhaborGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("PhaborGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("PhaborGore3").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("PhaborGore3").Type, 1f);
			}
			else
			{
				for (int k = 0; k < hit.Damage / NPC.lifeMax * 50.0; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hitDirection, -1f, 0, default(Color), 0.7f);
				}
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && Main.hardMode && Main.bloodMoon && spawnInfo.SpawnTileY < Main.worldSurface ? 0.06f : 0f;
	}