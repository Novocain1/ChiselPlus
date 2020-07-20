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
            ImageSurface temp_surface;
            Context old_cr;
            Pattern pattern = null;
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
            cr.MoveTo(359, 798.316406);
            cr.CurveTo(271.273438, 724.910156, 198.296875, 663.871094, 196.824219, 662.675781);
            cr.LineTo(194.152344, 660.5);
            cr.LineTo(160.886719, 428.269531);
            cr.CurveTo(142.59375, 300.546875, 127.820313, 195.851563, 128.0625, 195.617188);
            cr.CurveTo(128.613281, 195.082031, 543.832031, 92.878906, 545.941406, 92.757813);
            cr.CurveTo(548.59375, 92.605469, 726.429688, 143.0625, 727.660156, 144.316406);
            cr.CurveTo(728.296875, 144.96875, 770.117188, 217.5, 820.589844, 305.5);
            cr.CurveTo(883.585938, 415.324219, 912.300781, 466.285156, 912.160156, 468);
            cr.CurveTo(911.789063, 472.582031, 877.402344, 678.933594, 876.945313, 679.304688);
            cr.CurveTo(875.488281, 680.492188, 523.046875, 928.933594, 521, 930.214844);
            cr.CurveTo(518.503906, 931.78125, 518.140625, 931.484375, 359, 798.316406);
            cr.ClosePath();
            cr.MoveTo(359, 798.316406);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(359, 798.316406);
            cr.CurveTo(271.273438, 724.910156, 198.296875, 663.871094, 196.824219, 662.675781);
            cr.LineTo(194.152344, 660.5);
            cr.LineTo(160.886719, 428.269531);
            cr.CurveTo(142.59375, 300.546875, 127.820313, 195.851563, 128.0625, 195.617188);
            cr.CurveTo(128.613281, 195.082031, 543.832031, 92.878906, 545.941406, 92.757813);
            cr.CurveTo(547.503906, 92.667969, 726.15625, 142.824219, 726.894531, 143.5625);
            cr.CurveTo(727.441406, 144.105469, 744.476563, 138.820313, 596.5, 184.027344);
            cr.CurveTo(560.199219, 195.117188, 513.625, 209.347656, 493, 215.652344);
            cr.CurveTo(472.375, 221.957031, 435.023438, 233.363281, 410, 241.003906);
            cr.CurveTo(314.226563, 270.230469, 296.503906, 275.804688, 296.675781, 276.640625);
            cr.CurveTo(296.769531, 277.113281, 325.03125, 329.699219, 359.476563, 393.5);
            cr.CurveTo(393.921875, 457.300781, 444.019531, 550.128906, 470.800781, 599.789063);
            cr.CurveTo(506.550781, 666.074219, 519.902344, 689.976563, 521.019531, 689.695313);
            cr.CurveTo(521.851563, 689.480469, 540.976563, 678.726563, 563.519531, 665.792969);
            cr.CurveTo(586.058594, 652.859375, 626.324219, 629.777344, 653, 614.496094);
            cr.CurveTo(718.992188, 576.699219, 771.496094, 546.597656, 841.5, 506.441406);
            cr.CurveTo(910.777344, 466.703125, 910.941406, 466.609375, 911.714844, 467.382813);
            cr.CurveTo(912.332031, 467.996094, 877.960938, 677.515625, 877.023438, 678.863281);
            cr.CurveTo(876.507813, 679.609375, 525.835938, 927.183594, 521, 930.214844);
            cr.CurveTo(518.503906, 931.78125, 518.140625, 931.484375, 359, 798.316406);
            cr.ClosePath();
            cr.MoveTo(359, 798.316406);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(359, 798.25);
            cr.CurveTo(271.273438, 724.878906, 198.296875, 663.871094, 196.828125, 662.675781);
            cr.LineTo(194.152344, 660.5);
            cr.LineTo(161.015625, 429.179688);
            cr.CurveTo(142.792969, 301.953125, 128.019531, 197.488281, 128.191406, 197.035156);
            cr.CurveTo(128.507813, 196.191406, 292.117188, 273.660156, 295.230469, 276.128906);
            cr.CurveTo(296.179688, 276.882813, 324.023438, 327.675781, 357.097656, 389);
            cr.CurveTo(501.777344, 657.230469, 519.265625, 689.515625, 520.054688, 689.816406);
            cr.CurveTo(520.511719, 689.988281, 520.636719, 690.78125, 520.332031, 691.574219);
            cr.CurveTo(520.027344, 692.371094, 519.492188, 746.710938, 519.140625, 812.332031);
            cr.LineTo(518.5, 931.648438);
            cr.ClosePath();
            cr.MoveTo(359, 798.25);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(359, 798.25);
            cr.CurveTo(271.273438, 724.878906, 198.296875, 663.871094, 196.828125, 662.675781);
            cr.LineTo(194.152344, 660.5);
            cr.LineTo(161.015625, 429.179688);
            cr.CurveTo(142.792969, 301.953125, 128.019531, 197.488281, 128.191406, 197.035156);
            cr.CurveTo(128.507813, 196.191406, 292.113281, 273.660156, 295.230469, 276.128906);
            cr.CurveTo(296.179688, 276.882813, 322.445313, 324.75, 353.589844, 382.5);
            cr.CurveTo(384.738281, 440.25, 434.875, 533.175781, 465.007813, 589.007813);
            cr.LineTo(519.796875, 690.511719);
            cr.LineTo(519.148438, 811.078125);
            cr.LineTo(518.5, 931.648438);
            cr.ClosePath();
            cr.MoveTo(359, 798.25);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(359, 798.25);
            cr.CurveTo(271.273438, 724.878906, 198.296875, 663.871094, 196.828125, 662.675781);
            cr.LineTo(194.152344, 660.5);
            cr.LineTo(161.015625, 429.179688);
            cr.CurveTo(142.792969, 301.953125, 128.019531, 197.5, 128.191406, 197.0625);
            cr.CurveTo(128.359375, 196.625, 131.648438, 197.773438, 135.5, 199.609375);
            cr.CurveTo(139.351563, 201.449219, 150.148438, 206.609375, 159.5, 211.074219);
            cr.CurveTo(168.851563, 215.539063, 203.050781, 231.800781, 235.5, 247.207031);
            cr.CurveTo(267.949219, 262.617188, 295.039063, 275.734375, 295.695313, 276.363281);
            cr.CurveTo(296.351563, 276.988281, 322.390625, 324.75, 353.554688, 382.5);
            cr.CurveTo(384.722656, 440.25, 434.875, 533.175781, 465.007813, 589.007813);
            cr.LineTo(519.796875, 690.511719);
            cr.LineTo(519.148438, 811.078125);
            cr.LineTo(518.5, 931.648438);
            cr.ClosePath();
            cr.MoveTo(359, 798.25);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
            if (pattern != null) pattern.Dispose();

            cr.Operator = Operator.Over;
            pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
            cr.SetSource(pattern);

            cr.NewPath();
            cr.MoveTo(359, 798.25);
            cr.CurveTo(271.273438, 724.878906, 198.296875, 663.871094, 196.828125, 662.675781);
            cr.LineTo(194.152344, 660.5);
            cr.LineTo(161.015625, 429.179688);
            cr.CurveTo(142.792969, 301.953125, 128.019531, 197.5, 128.191406, 197.0625);
            cr.CurveTo(128.359375, 196.625, 131.648438, 197.773438, 135.5, 199.609375);
            cr.CurveTo(139.351563, 201.449219, 150.148438, 206.609375, 159.5, 211.074219);
            cr.CurveTo(168.851563, 215.539063, 203.050781, 231.800781, 235.5, 247.207031);
            cr.CurveTo(267.949219, 262.617188, 295.039063, 275.734375, 295.695313, 276.363281);
            cr.CurveTo(296.351563, 276.988281, 323.96875, 327.675781, 357.066406, 389);
            cr.CurveTo(390.160156, 450.324219, 440.125, 542.898438, 468.09375, 594.71875);
            cr.CurveTo(496.0625, 646.535156, 519.167969, 689.960938, 519.4375, 691.21875);
            cr.CurveTo(519.707031, 692.472656, 519.605469, 747.082031, 519.214844, 812.574219);
            cr.LineTo(518.5, 931.648438);
            cr.ClosePath();
            cr.MoveTo(359, 798.25);
            cr.Tolerance = 0.1;
            cr.Antialias = Antialias.Default;
            cr.FillRule = FillRule.Winding;
            cr.FillPreserve();
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

    [HarmonyPatch(typeof(BlockEntityChisel), "Initialize")]
    public class Patch_BlockEntityChisel_Initialize
    {
        public EnumChiselPlusMesh mesh = EnumChiselPlusMesh.none;
        public Vec3f rotation = new Vec3f();

        public static Dictionary<BlockPos, Patch_BlockEntityChisel_Initialize> setMeshes = new Dictionary<BlockPos, Patch_BlockEntityChisel_Initialize>();

        public Patch_BlockEntityChisel_Initialize()
        {
        }

        public static void Postfix(BlockEntityChisel __instance, ICoreAPI api)
        {
            setMeshes[__instance.Pos] = new Patch_BlockEntityChisel_Initialize();
            if (api.Side.IsClient())
            {
                __instance.RegenMesh();
                __instance.MarkDirty(true);
            }
        }
    }

    [HarmonyPatch(typeof(BlockEntityChisel), "UpdateVoxel")]
    public class Patch_BlockEntityChisel_UpdateVoxel
    {
        public static void Postfix(BlockEntityChisel __instance, IPlayer byPlayer, ItemSlot itemslot, Vec3i voxelPos, BlockFacing facing, bool isBreak)
        {
            if (!__instance.Api.World.Claims.TryAccess(byPlayer, __instance.Pos, EnumBlockAccessFlags.Use))
            {
                __instance.MarkDirty(true);
                return;
            }

            EnumChiselPlusMode mode = (EnumChiselPlusMode)__instance.ChiselMode(byPlayer);
            
            switch (mode)
            {
                case EnumChiselPlusMode.ChiselPlus:
                    if (isBreak)
                    {
                        EnumChiselPlusMesh mesh = Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].mesh;
                        Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].mesh = mesh > EnumChiselPlusMesh.slopehalf ? EnumChiselPlusMesh.none : mesh + 1;
                    }
                    else
                    {
                        Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].rotation.X += byPlayer.Entity.Controls.Sneak && !byPlayer.Entity.Controls.Sprint ? 45 : 0;
                        Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].rotation.Y += byPlayer.Entity.Controls.Sprint && !byPlayer.Entity.Controls.Sneak ? 45 : 0;
                        Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].rotation.Z += byPlayer.Entity.Controls.Sneak && byPlayer.Entity.Controls.Sprint ? 45 : 0;
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
            var store = Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos];

            tree.SetInt("chiselplusmesh", (int)store.mesh);
            tree.SetFloat("chiselplusRotX", store.rotation.X);
            tree.SetFloat("chiselplusRotY", store.rotation.Y);
            tree.SetFloat("chiselplusRotZ", store.rotation.Z);
            
            Patch_BlockEntityChisel_Initialize.setMeshes.Remove(__instance.Pos);
        }
    }

    [HarmonyPatch(typeof(BlockEntityChisel), "FromTreeAtributes")]
    public class Patch_BlockEntityChisel_FromTreeAtributes
    {
        public static void Postfix(BlockEntityChisel __instance, ITreeAttribute tree, IWorldAccessor worldAccessForResolve)
        {
            Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos] = new Patch_BlockEntityChisel_Initialize();

            Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].mesh = (EnumChiselPlusMesh)(tree.TryGetInt("chiselplusmesh") ?? -1);
            Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].rotation.X = tree.TryGetFloat("chiselplusRotX") ?? 0.0f;
            Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].rotation.Y = tree.TryGetFloat("chiselplusRotY") ?? 0.0f;
            Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].rotation.Z = tree.TryGetFloat("chiselplusRotZ") ?? 0.0f;

            if (__instance.Api?.Side.IsClient() ?? false) __instance.MarkDirty(true);
        }
    }

    [HarmonyPatch(typeof(BlockEntityChisel), "RegenMesh")]
    public class Patch_BlockEntityChisel_RegenMesh
    {
        public static void Postfix(BlockEntityChisel __instance)
        {
            EnumChiselPlusMesh setMesh = Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].mesh;

            if (setMesh != EnumChiselPlusMesh.none)
            {
                Vec3f rot = Patch_BlockEntityChisel_Initialize.setMeshes[__instance.Pos].rotation;

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
}
