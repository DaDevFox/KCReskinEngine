﻿#if UNITY_EDITOR

namespace ReskinEngine.Editor
{
    #region Castle Blocks
    public class WoodCastleBlockPreview : CastleBlockPreview<WoodCastleBlockSkin>
    {
        public override string OpenPath => $"{modelsRoot}/1x1x5_wood.fbx";
        public override string ClosedPath => $"{modelsRoot}/1x1x5_fulltop_wood.fbx";
        public override string SinglePath => $"{modelsRoot}/1x1x5_onesided_wood.fbx";
        public override string OppositePath => $"{modelsRoot}/1x1x5_twosided_wood.fbx";
        public override string AdjacentPath => $"{modelsRoot}/1x1x5_corner_wood.fbx";
        public override string ThreesidePath => $"{modelsRoot}/1x1x5_threesided_wood.fbx";
        public override string DoorPath => $"{modelsRoot}/castlestairs_doorway_wooden.fbx";
    }

    #endregion
}

#endif