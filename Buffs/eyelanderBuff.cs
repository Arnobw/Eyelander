using Terraria;
using Terraria.ModLoader;



namespace Eyelander.Buffs {
public class eyelanderBuff : ModBuff
{
    int heads = 0;
    
    
    public override void SetDefaults()
    {
        DisplayName.SetDefault("Taking Heads");
        Description.SetDefault("Heads taken increase max health up to 25%");
        Main.buffNoTimeDisplay[Type] = false;
        Main.debuff[Type] = false; 
    }

    public override void Update(Player player, ref int buffIndex) {
        player.moveSpeed += 0.3f;
            if (heads <= player.statLifeMax2 / 4)
            {
                player.statLifeMax2 += heads;
            } else {
               player.statLifeMax2 += player.statLifeMax2 / 4;
            }
            
            if (player.buffTime[buffIndex] == 0) {
                heads = 0;
            }
        }

    public override bool ReApply (Player player, int time, int buffIndex)
        { 
    heads += 5;
    player.buffTime[buffIndex] ++;
    if (heads <= player.statLifeMax2 / 4) {
    player.HealEffect(heads / 5);
    player.statLife +=heads / 5;
    } else {
    player.HealEffect(player.statLife / 10);
    player.statLife += player.statLife / 10;
    }
    return false;
    }
    }
}

