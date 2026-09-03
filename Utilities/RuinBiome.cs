using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Utilities;

public class RuinBiome : ModBiome
{
    public override bool IsBiomeActive(Player player)
    {
        return BiomeTileCounterSystem.RuinAltar > 1;
    }

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

    public override int Music
    {
        get
        {
            if (ModLoader.HasMod("TremorModMusic"))
            {
                Mod musicMod = ModLoader.GetMod("TremorModMusic");
                if (musicMod != null)
                {
                    return MusicLoader.GetMusicSlot(musicMod, "Assets/Music/Eternal-Echoes");
                }
            }
            return MusicID.Underground;
        }
    }
}
