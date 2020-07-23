using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using HarmonyLib;
using Vintagestory.Client.NoObf;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;
using Vintagestory.API.Config;
using Vintagestory.API.Util;
using Cairo;
using Vintagestory.API.Datastructures;
using Vintagestory.ServerMods;

namespace ChiselPlus
{
    public class ChiselPlusSystem : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            Patch();
        }

        public void Patch()
        {
            var Harmony = new Harmony("ModSystem.ChiselPlus");
            Harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(ItemChisel), "OnLoaded")]
    public class Patch_ItemChisel_OnLoaded
    {
        public static void Postfix(ICoreAPI api, ref SkillItem[] ___toolModes)
        {
            if (api.Side.IsClient())
            {
                var modes = new List<SkillItem>(___toolModes);
                ___toolModes = ObjectCacheUtil.GetOrCreate(api, "chiselToolModesPlus", () =>
                {
                    modes.Add(new SkillItem() { Code = new AssetLocation("ChiselPlus"), Name = Lang.Get("ChiselPlus") }.WithIcon((ICoreClientAPI)api, Drawcorner1_svg));
                    return modes.ToArray();
                });
            }
        }

        public static void Drawcorner1_svg(Context cr, int x, int y, float width, float height, double[] rgba)
        {
            Pattern pattern;
            Matrix matrix = cr.Matrix;

            cr.Save();
            float w = 1024;
            float h = 1024;
            float scale = Math.Min(width / w, height / h);
            matrix.Translate(x + Math.Max(0, (width - w * scale) / 2), y + Math.Max(0, (height - h * scale) / 2));
            matrix.Scale(scale, scale);
            cr.Matrix = matrix;

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(304.226563, 272.78125);
            cr.LineTo(527.988281, 685.785156);
            cr.LineTo(919.699219, 463.308594);
            cr.LineTo(735.460938, 140.246094);
            cr.ClosePath();
            cr.MoveTo(304.226563, 272.78125);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            cr.LineWidth = 0.264583;
            cr.MiterLimit = 4;
            cr.LineCap = LineCap.Butt;
            cr.LineJoin = LineJoin.Miter;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(304.226563, 272.78125);
            cr.LineTo(527.988281, 685.785156);
            cr.LineTo(919.699219, 463.308594);
            cr.LineTo(735.460938, 140.246094);
            cr.ClosePath();
            cr.MoveTo(304.226563, 272.78125);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            matrix = new Matrix(3.779527, 0, 0, 3.779527, 0.0000188976, 0);
            pattern.Matrix = matrix;
            cr.StrokePreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(300.226563, 260.78125);
            cr.LineTo(131.785156, 179.71875);
            cr.LineTo(549.960938, 76.734375);
            cr.LineTo(731.460938, 128.246094);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            cr.LineWidth = 0.264583;
            cr.MiterLimit = 4;
            cr.LineCap = LineCap.Butt;
            cr.LineJoin = LineJoin.Miter;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(300.226563, 260.78125);
            cr.LineTo(131.785156, 179.71875);
            cr.LineTo(549.960938, 76.734375);
            cr.LineTo(731.460938, 128.246094);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            matrix = new Matrix(3.779527, 0, 0, 3.779527, 0.0000188976, 0);
            pattern.Matrix = matrix;
            cr.StrokePreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(529.796875, 690.511719);
            cr.LineTo(528.5, 931.648438);
            cr.LineTo(886.988281, 679.261719);
            cr.LineTo(921.699219, 467.308594);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            cr.LineWidth = 0.264583;
            cr.MiterLimit = 4;
            cr.LineCap = LineCap.Butt;
            cr.LineJoin = LineJoin.Miter;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(529.796875, 690.511719);
            cr.LineTo(528.5, 931.648438);
            cr.LineTo(886.988281, 679.261719);
            cr.LineTo(921.699219, 467.308594);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            matrix = new Matrix(3.779527, 0, 0, 3.779527, 0.0000188976, 0);
            pattern.Matrix = matrix;
            cr.StrokePreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(519.984375, 689.785156);
            cr.LineTo(296.058594, 276.613281);
            cr.LineTo(127.90625, 195.628906);
            cr.LineTo(194.152344, 660.5);
            cr.LineTo(518.273438, 931.691406);
            cr.LineTo(519.984375, 689.785156);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            cr.LineWidth = 0.264583;
            cr.MiterLimit = 4;
            cr.LineCap = LineCap.Butt;
            cr.LineJoin = LineJoin.Miter;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(519.984375, 689.785156);
            cr.LineTo(296.058594, 276.613281);
            cr.LineTo(127.90625, 195.628906);
            cr.LineTo(194.152344, 660.5);
            cr.LineTo(518.273438, 931.691406);
            cr.LineTo(519.984375, 689.785156);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            matrix = new Matrix(3.779527, 0, 0, 3.779527, 0.0000188976, 0);
            pattern.Matrix = matrix;
            cr.StrokePreserve();
            if (pattern != null) pattern.Dispose();

            cr.Restore();
        }
    }

    [HarmonyPatch(typeof(ItemChisel), "SetToolMode")]
    public class Patch_ItemChisel_SetToolMode
    {
        public static void Postfix(ItemSlot slot, IPlayer byPlayer, BlockSelection blockSel, int toolMode)
        {
            if (toolMode > 7)
            {
                slot.Itemstack.Attributes.SetInt("materialNum", toolMode - 8);
                return;
            }

            slot.Itemstack.Attributes.SetInt("toolMode", toolMode);
        }
    }

    public class ChiselPlusProperties
    {
        public EnumChiselPlusMesh Mesh { get; set; } = EnumChiselPlusMesh.none;
        public Vec3f Rotation { get; set; } = new Vec3f();
    }

    public class ChiselPlusPropertyAccessor
    {
        public ICoreAPI api;

        public ChiselPlusPropertyAccessor(ICoreAPI api)
        {
            this.api = api;
        }

        public Dictionary<BlockPos, ChiselPlusProperties> Properties { get => GetProperties(); set => SetProperties(value); }

        void UpdateProperties(BlockPos pos)
        {
            SetPropertyValues(pos, Properties?[pos]);
        }

        void SetPropertyValues(BlockPos pos, ChiselPlusProperties props)
        {
            var sprop = (api.ObjectCache["ChiselPlusProperties"] as Dictionary<BlockPos, ChiselPlusProperties>);
            
            if (sprop != null && sprop.ContainsKey(pos))
            {
                (api.ObjectCache["ChiselPlusProperties"] as Dictionary<BlockPos, ChiselPlusProperties>)[pos].Mesh = props.Mesh;
                (api.ObjectCache["ChiselPlusProperties"] as Dictionary<BlockPos, ChiselPlusProperties>)[pos].Rotation = props.Rotation;
            }

        }


        Dictionary<BlockPos, ChiselPlusProperties> GetProperties()
        {
            return ObjectCacheUtil.GetOrCreate(api, "ChiselPlusProperties", () => new Dictionary<BlockPos, ChiselPlusProperties>());
        }

        void SetProperties(Dictionary<BlockPos, ChiselPlusProperties> val)
        {
            api.ObjectCache["ChiselPlusProperties"] = val;
        }
    }

    [HarmonyPatch(typeof(BlockEntityChisel), "Initialize")]
    public class Patch_BlockEntityChisel_Initialize
    {
        public static void Postfix(BlockEntityChisel __instance, ICoreAPI api)
        {
            ChiselPlusPropertyAccessor accessor = new ChiselPlusPropertyAccessor(api);
            if (!accessor.Properties.ContainsKey(__instance.Pos)) accessor.Properties[__instance.Pos] = new ChiselPlusProperties();

            if (api.Side.IsClient())
            {
                __instance.RegenMesh();
                __instance.MarkDirty(true);
            }
        }
    }

    [HarmonyPatch(typeof(BlockEntityChisel), "OnBlockInteract")]
    public class Patch_BlockEntityChisel_UpdateVoxel
    {
        public static void Postfix(BlockEntityChisel __instance, IPlayer byPlayer, BlockSelection blockSel, bool isBreak)
        {
            if (!__instance.Api.World.Claims.TryAccess(byPlayer, __instance.Pos, EnumBlockAccessFlags.Use))
            {
                __instance.MarkDirty(true);
                return;
            }

            ChiselPlusPropertyAccessor accessor = new ChiselPlusPropertyAccessor(__instance.Api);
            if (!accessor.Properties.ContainsKey(__instance.Pos)) accessor.Properties[__instance.Pos] = new ChiselPlusProperties();

            EnumChiselPlusMode mode = (EnumChiselPlusMode)__instance.ChiselMode(byPlayer);

            switch (mode)
            {
                case EnumChiselPlusMode.ChiselPlus:
                    if (isBreak)
                    {
                        //accessor.Properties[__instance.Pos] = new ChiselPlusProperties();

                        EnumChiselPlusMesh mesh = accessor.Properties[__instance.Pos].Mesh;
                        accessor.Properties[__instance.Pos].Mesh = mesh > EnumChiselPlusMesh.slopehalf ? EnumChiselPlusMesh.none : mesh + 1;
                    }
                    else
                    {
                        bool success;

                        accessor.Properties[__instance.Pos].Rotation.Z += (success = byPlayer.Entity.Controls.Sneak) ? 45 : 0;
                        accessor.Properties[__instance.Pos].Rotation.X += (success = byPlayer.Entity.Controls.Sprint && !success) ? 45 : 0;
                        accessor.Properties[__instance.Pos].Rotation.Y += !success ? 45 : 0;
                    }
                    break;
                default:
                    break;
            }

            if (__instance.Api.Side.IsClient())
            {
                __instance.RegenMesh();
                __instance.MarkDirty(true);
            }
        }
    }

    [HarmonyPatch(typeof(BlockEntityChisel), "ToTreeAttributes")]
    public class Patch_BlockEntityChisel_ToTreeAttributes
    {
        public static void Postfix(BlockEntityChisel __instance, ITreeAttribute tree)
        {
            ChiselPlusPropertyAccessor accessor = new ChiselPlusPropertyAccessor(__instance.Api);

            var store = accessor.Properties[__instance.Pos];

            tree.SetInt("chiselplusmesh", (int)store.Mesh);
            tree.SetFloat("chiselplusRotX", store.Rotation.X);
            tree.SetFloat("chiselplusRotY", store.Rotation.Y);
            tree.SetFloat("chiselplusRotZ", store.Rotation.Z);
        }
    }

    [HarmonyPatch(typeof(BlockEntityChisel), "FromTreeAtributes")]
    public class Patch_BlockEntityChisel_FromTreeAtributes
    {
        public static void Postfix(BlockEntityChisel __instance, ITreeAttribute tree, IWorldAccessor worldAccessForResolve)
        {
            ChiselPlusPropertyAccessor accessor = new ChiselPlusPropertyAccessor(worldAccessForResolve.Api);

            if (!accessor.Properties.ContainsKey(__instance.Pos)) accessor.Properties[__instance.Pos] = new ChiselPlusProperties();

            accessor.Properties[__instance.Pos].Mesh = (EnumChiselPlusMesh)(tree.TryGetInt("chiselplusmesh") ?? -1);
            accessor.Properties[__instance.Pos].Rotation.X = tree.TryGetFloat("chiselplusRotX") ?? 0.0f;
            accessor.Properties[__instance.Pos].Rotation.Y = tree.TryGetFloat("chiselplusRotY") ?? 0.0f;
            accessor.Properties[__instance.Pos].Rotation.Z = tree.TryGetFloat("chiselplusRotZ") ?? 0.0f;

            if (__instance.Api?.Side.IsClient() ?? false) __instance.MarkDirty(true);
        }
    }

    [HarmonyPatch(typeof(BlockEntityChisel), "RegenMesh")]
    public class Patch_BlockEntityChisel_RegenMesh
    {
        public static void Postfix(BlockEntityChisel __instance)
        {
            try
            {
                ChiselPlusPropertyAccessor accessor = new ChiselPlusPropertyAccessor(__instance.Api);

                EnumChiselPlusMesh setMesh = accessor.Properties[__instance.Pos].Mesh;

                if (setMesh != EnumChiselPlusMesh.none && __instance.MaterialIds != null)
                {
                    Vec3f rot = accessor.Properties[__instance.Pos].Rotation;

                    ICoreClientAPI capi = (__instance.Api as ICoreClientAPI);
                    string name = Enum.GetName(typeof(EnumChiselPlusMesh), setMesh);
                    if (name == null) return;
                    string code = string.Format("chiselplus:genericblocks-{0}", name);

                    capi.Tesselator.TesselateBlock(capi.World.BlockAccessor.GetBlock(new AssetLocation(code)), out MeshData mesh);

                    TextureSource texSource = new TextureSource(__instance.Api.World as ClientMain, capi.BlockTextureAtlas.Size, capi.World.BlockAccessor.GetBlock(__instance.MaterialIds.FirstOrDefault()));
                    Dictionary<string, int> textureCodeToIdMapping = AccessTools.Field(typeof(TextureSource), "textureCodeToIdMapping").GetValue(texSource) as Dictionary<string, int>;

                    mesh.SetTexPos(texSource[textureCodeToIdMapping.FirstOrDefault().Key]);
                    mesh.Rotate(new Vec3f(0.5f, 0.5f, 0.5f), GameMath.DEG2RAD * rot.X, GameMath.DEG2RAD * rot.Y, GameMath.DEG2RAD * rot.Z);
                    __instance.Mesh = mesh;
                }
            }
            catch (Exception ex)
            {
            }

        }
    }

    [HarmonyPatch(typeof(ChiselBlockModelCache), "GetOrCreateMeshRef")]
    public class Patch_ChiselBlockModelCache_GetOrCreateMeshRef
    {
        public static void Postfix(ChiselBlockModelCache __instance, ItemStack forStack, ref ICoreClientAPI ___capi, ref MeshRef __result)
        {
            int? setMesh = forStack.Attributes.TryGetInt("chiselplusmesh");
            if (setMesh != null && setMesh != (int)EnumChiselPlusMesh.none)
            {
                Vec3f rot = new Vec3f()
                {
                    X = forStack.Attributes.TryGetFloat("chiselplusRotX") ?? 0.0f,
                    Y = forStack.Attributes.TryGetFloat("chiselplusRotY") ?? 0.0f,
                    Z = forStack.Attributes.TryGetFloat("chiselplusRotZ") ?? 0.0f
                };

                string name = Enum.GetName(typeof(EnumChiselPlusMesh), setMesh);
                IntArrayAttribute materials = forStack.Attributes["materials"] as IntArrayAttribute;

                if (name == null || materials == null) return;

                string code = string.Format("chiselplus:genericblocks-{0}", name);

                ___capi.Tesselator.TesselateBlock(___capi.World.BlockAccessor.GetBlock(new AssetLocation(code)), out MeshData mesh);

                TextureSource texSource = new TextureSource(___capi.World as ClientMain, ___capi.BlockTextureAtlas.Size, ___capi.World.BlockAccessor.GetBlock(materials.value.FirstOrDefault()));

                Dictionary<string, int> textureCodeToIdMapping = AccessTools.Field(typeof(TextureSource), "textureCodeToIdMapping").GetValue(texSource) as Dictionary<string, int>;

                mesh.SetTexPos(texSource[textureCodeToIdMapping.FirstOrDefault().Key]);
                mesh.Rotate(new Vec3f(0.5f, 0.5f, 0.5f), GameMath.DEG2RAD * rot.X, GameMath.DEG2RAD * rot.Y, GameMath.DEG2RAD * rot.Z);

                __result = ___capi.Render.UploadMesh(mesh);
            }
        }
    }


    public enum EnumChiselPlusMode
    {
        Flip = EnumChiselMode.Flip, Rename = EnumChiselMode.Rename, Rotate = EnumChiselMode.Rotate, Size1 = EnumChiselMode.Size1, Size2 = EnumChiselMode.Size2, Size4 = EnumChiselMode.Size4, Size8 = EnumChiselMode.Size8,
        ChiselPlus = 7
    }

    public enum EnumChiselPlusMesh
    {
        none = -1, corner1, corner2, pyramid, slope, slopehalf
    }

    public static class HackMan
    {
        public static T GetField<T, K>(this K instance, string fieldname) => (T)AccessTools.Field(instance.GetType(), fieldname).GetValue(instance);
    }
}
