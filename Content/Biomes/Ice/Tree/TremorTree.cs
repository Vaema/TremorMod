using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent;
using Terraria.ModLoader;
using TremorMod.Content.Biomes.Ice.Items;

namespace TremorMod.Content.Biomes.Ice.Tree;

public class ExampleTree : ModTree
{
    private Asset<Texture2D> texture;
    private Asset<Texture2D> branchesTexture;
    private Asset<Texture2D> topsTexture;

    public override TreePaintingSettings TreeShaderSettings => new()
    {
        UseSpecialGroups = true,
        SpecialGroupMinimalHueValue = 11f / 72f,
        SpecialGroupMaximumHueValue = 0.25f,
        SpecialGroupMinimumSaturationValue = 0.88f,
        SpecialGroupMaximumSaturationValue = 1f
    };

    public override void SetStaticDefaults()
    {
        GrowsOnTileId = [ModContent.TileType<VeryVeryIce>()];
        texture = ModContent.Request<Texture2D>("TremorMod/Content/Biomes/Ice/Tree/TremorTree");
        branchesTexture = ModContent.Request<Texture2D>("TremorMod/Content/Biomes/Ice/Tree/TremorTree_Branches");
        topsTexture = ModContent.Request<Texture2D>("TremorMod/Content/Biomes/Ice/Tree/TremorTree_Tops");
    }

    // This is the primary texture for the trunk. Branches and foliage use different methods.
    public override Asset<Texture2D> GetTexture() => texture;

    public override Asset<Texture2D> GetBranchTextures() => branchesTexture;

    public override Asset<Texture2D> GetTopTextures() => topsTexture;

    public override int DropWood() => ModContent.ItemType<GlacierWood>();
}
