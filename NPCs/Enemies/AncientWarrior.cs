using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.NPCs.Enemies
{
    public class AncientWarrior : ModNPC {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ancient Warrior");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye];
        }

        public override void SetDefaults() {
            npc.width = 18;
            npc.height = 40;
            npc.damage = 30;
            npc.defense = 5;
            npc.lifeMax = 200;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 200f;
            npc.knockBackResist = 0.7f;
            npc.aiStyle = 3;
            aiType = NPCID.Zombie;
            animationType = NPCID.Zombie;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo) {
            if(Main.dayTime) {
                if(spawnInfo.player.ZoneOverworld.day) {
                    return 1f;
                }
            }
            return 0f;
        }

        public override void HitEffect(int hitDirection, double damage) {
			if (npc.life > 0) {
				for (int i = 0; i < damage / npc.lifeMax * 100; i++) {
					Dust dust = Dust.NewDustDirect(npc.position, npc.width, npc.height, 192, hitDirection, -1f, 100, new Color(100, 100, 100, 100), 1f);
					dust.noGravity = false;
				}
				return;
			}
			for (int i = 0; i < 50; i++) {
				Dust dust = Dust.NewDustDirect(npc.position, npc.width, npc.height, 192, 2 * hitDirection, -2f, 100, new Color(100, 100, 100, 100), 1f);
				dust.noGravity = false;
			}
		}
    }
}