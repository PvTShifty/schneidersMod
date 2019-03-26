using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SchneidersMod.NPCs.Enemies
{
    public class StickySlime : ModNPC
    {        
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sticky Slime");
            Main.npcFrameCount[npc.type] = 2;
        }

        public override void SetDefaults() {
            npc.width = 25;
            npc.height = 20;
            npc.damage = 10;
            npc.defense = 0;
            npc.lifeMax = 40;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 50f;
            npc.knockBackResist = 0.8f;
            npc.aiStyle = 1;
            aiType = 1;
            animationType = 1;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo) {
            if (Main.dayTime) {
                if (spawnInfo.player.ZoneOverworldHeight) {
                    return 0.4f;
                }
            }
            return 0f;
        } 

        public override void NPCLoot() {
            Item.NewItem(npc.getRect(), mod.ItemType("StickyGlue"), Main.rand.Next(1, 6));
        }

        public override void HitEffect(int hitDirection, double damage) {
			if (npc.life > 0) {
				for (int i = 0; i < damage / npc.lifeMax * 100; i++) {
					Dust dust = Dust.NewDustDirect(npc.position, npc.width, npc.height, 182, hitDirection, -1f, 100);
					dust.noGravity = false;
				}
				return;
			}
			for (int i = 0; i < 50; i++) {
				Dust dust = Dust.NewDustDirect(npc.position, npc.width, npc.height, 182, 2 * hitDirection, -2f, 100);
				dust.noGravity = false;
			}
		}
    }
}