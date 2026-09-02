using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace TremorMod;

public class TremorConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [Header("$Mods.TremorMod.Config.BuffSettings")]

    [DefaultValue(false)]
    [LabelKey("$Mods.TremorMod.Config.AllowHealthBuffsTogether")]
    [TooltipKey("$Mods.TremorMod.Config.AllowHealthBuffsTogetherTooltip")]
    public bool AllowHealthBuffsTogether;

    [DefaultValue(false)]
    [LabelKey("$Mods.TremorMod.Config.AllowManaBuffsTogether")]
    [TooltipKey("$Mods.TremorMod.Config.AllowManaBuffsTogetherTooltip")]
    public bool AllowManaBuffsTogether;

    [Header("$Mods.TremorMod.Config.CreateSettings")]

    [DefaultValue(true)]
    [LabelKey("$Mods.TremorMod.Config.AllowZenithRecipeChange")]
    [TooltipKey("$Mods.TremorMod.Config.AllowZenithRecipeChangeTooltip")]
    public bool AllowZenithRecipeChange;

    [DefaultValue(false)]
    [LabelKey("$Mods.TremorMod.Config.Disablingspawn")]
    [TooltipKey("$Mods.TremorMod.Config.DisablingspawnTooltip")]
    public bool DisablingspawnAvengerPhobosDeimos;
}
