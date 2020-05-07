using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Minigame.Fishing
{
    public partial class SequenceVariableFishingSettings : SQEX.Ebony.Framework.Sequence.SequenceActivatableNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin settings_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin debug_place_overwrite_;
		public uint placeId_;
		public uint debugPlaceId_;
		public bool bUseFishHabitatExtraSetting_;
		public bool bExtraSetting_;
		public float startFadeTime_;
		public float endFadeTime_;
		public float castPartCameraHeight_;
		public float castPartCameraDistance_;
		public float castPartCameraLeftRight_;
		public float castPartLookAtHeight_;
		public float castPartLookAtLeftRight_;
		public float castPartMoveRate_;
		public float castDirRangeInDegree_;
		public float reelPartCameraHeight_;
		public float reelPartCameraDistance_;
		public float reelPartCameraDistanceRateWhenInBiteArea_;
		public float reelPartCameraMoveRateWhenInBiteArea_;
		public float reelPartLookAtDistance_;
		public float reelPartMoveRate_;
		public float reelPartMinDistance_;
		public bool lureUseParamTable_;
		public float lureRotationCenterRate_;
		public float lureHeightFromWater_;
		public float lureMoveSpeedRate_;
		public float lureMoveResistRate_;
		public float lureRotSpeedRate_;
		public float lureRotResistRate_;
		public float lureRotMax_;
		public float lureStickSpeedRate_;
		public float lureFreeMoveTimeSpan_;
		public float lureFreeMoveTimeSpanFor2OrMore_;
		public float lureFreeMoveSpeedRate_;
		public float lureFreeMoveRotationSpeedRate_;
		public float lureNeutralHeadRot_;
		public float lureHeadRotRange_;
		public float sinkRate_;
		public float sinkTimeRate_;
		public float sinkMaxValue_;
		public float lureHeadMoveRate_;
		public float lureBuoyancyRate_;
		public float battlePartCameraHeight_;
		public float battlePartCameraDistance_;
		public float battlePartCameraLeftRightOffset_;
		public float battlePartMoveRate_;
		public float battleFishMoveInDegree_;
		public float battleFishMoveMinRadius_;
		public float battleAddFovWhenReeling_;
		public float battleAddFovInterpParamWhenReeling_;
		public int battleAddFovBlendTypeWhenReeling_;
		public float battleJumpActionCameraSmoothRate_;
		public UnityEngine.Vector4 battleJumpActionCameraLookAtOffset_;
		public UnityEngine.Vector4 battleJumpActionCameraEyePosOffset_;
		public float fishGetMoveTime_;
		public float fishGetDistanceToStartRaise_;
		public float fishGetTimeToStartRaiseUp_;
		public float fishGetTimeToStartResultUI_;
		public float fishGetRaiseUpCameraLookAtHeight_;
		public float fishGetRaiseUpCameraLookAtDistance_;
		public UnityEngine.Vector4 fishGetRaiseUpCameraPosOffset_;
		public float fishGetRaiseUpCameraRotationSpeed_;
		public float fishGetTimeToStartPanAfterStartRaiseUp_;
		public float fishGettTimePan_;
		public float fishGetRaiseUpTargetLookAtHeightOffsetAfterPan_;
		public float fishGetRaiseUpTargetEyeHeightOffsetAfterPan_;
		public float fishGetFreeFallGravity_;
		public float fishGetFreeFallInitSpeed_;
		public float fishGetActorScale_;
		public UnityEngine.Vector4 fishGetAttachOffset_;
		public UnityEngine.Vector4 fishGetAttachRotation_;
		public float fishGetPerformanceSmallTimeLength_;
		public float fishGetPerformanceNormalTimeLength_;
		public float fishGetPerformanceBigTimeLength_;
		public float fishGetPerformanceSuperbigTimeLength_;
		public float fishGetPerformanceBigTunaTimeLength_;
		public float fishGetPerformanceBigTunaExTimeLength_;
		public float tacklePartCameraHeight_;
		public float tacklePartCameraDistance_;
		public float tacklePartCameraLeftRight_;
		public float tacklePartLookAtHeight_;
		public float tacklePartLookAtLeftRight_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableFishingSettings();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Minigame.Fishing.SequenceVariableFishingSettings", 0, Black.Sequence.Variable.Minigame.Fishing.SequenceVariableFishingSettings.ObjectType, null, properties, 0, 752);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Minigame.Fishing.SequenceVariableFishingSettings", base.GetFieldProperties(), -1239572252, 15521117);
            
			
			
			return fieldProperties;
        }

		
    }
}