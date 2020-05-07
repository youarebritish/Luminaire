using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Fishing
{
    public partial class SequenceActionFishingStart : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin animation_loaded_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin animation_unloaded_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin force_finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin normal_finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin normal_finish_canceled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin request_fadeout_finished_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin request_fadein_finished_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin request_rod_and_reel_visible_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin request_rod_and_reel_invisible_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin request_forbid_fish_get_cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin request_allow_fish_get_cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin start_fishing_fadeout_finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fishing_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_fishing_quit_triggered_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_fishing_fadeout_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_fishing_fadeout_finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_part_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cast_part_lure_casted_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reel_part_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reel_part_bite_mode_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reel_part_bite_action_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reel_part_bite_mode_finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin battle_part_started_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin battle_part_line_break_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin battle_part_escape_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin battle_part_winning_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin is_battle_part_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin battle_fish_fixid_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin battle_or_get_target_fish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fish_get_camera_change_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin fish_get_level_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin fish_get_size_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin fish_get_weight_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fadeout_request_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fadein_request_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin noct_animgraph_request_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin settings_from_node_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin placement_actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin water_height_object_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fish_grip_actor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fish_sapwn_entity_list_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin water_weed_entity_list_or_package_pin_;
		public uint placeId_;
		public int timeMorningStartHour_;
		public int timeDaytimeStartHour_;
		public int timeEveningStartHour_;
		public int timeNightStartHour_;
		public int fishSizeSmallAndMiddleThreshold_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> fishSizeSpecial1FixidList_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> fishSizeSpecial1_2FixidList_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> fishSizeSpecial2FixidList_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> fishSizeSpecial2_2FixidList_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> fishSizeSpecial3_1FixidList_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> specialLureNotLostIdList_;
		public float scriptLineHpThreshold_;
		public float castPartCameraHeight_;
		public float castPartCameraDistance_;
		public float castPartCameraLeftRight_;
		public float castPartLookAtHeight_;
		public float castPartLookAtLeftRight_;
		public float castPartMoveRate_;
		public float castDirRangeInDegree_;
		public float castDistanceSelectSpeed_;
		public float castDirectionToYDir_;
		public float castTimeToCastAfterStartMotion_;
		public float castPartFishJumpTimeBaseMin_;
		public float castPartFishJumpTimeBaseMax_;
		public float castPartFishJumpRiseRippleSizeRate_;
		public float castPartFishJumpDownRippleSizeRate_;
		public float castPartTackleUIAppearTime_;
		public float tacklePartCameraHeight_;
		public float tacklePartCameraDistance_;
		public float tacklePartCameraLeftRight_;
		public float tacklePartLookAtHeight_;
		public float tacklePartLookAtLeftRight_;
		public float reelPartCameraHeight_;
		public float reelPartCameraDistance_;
		public float reelPartCameraDistanceRateWhenInBiteArea_;
		public float reelPartCameraMoveRateWhenInBiteArea_;
		public float reelPartLookAtDistance_;
		public float reelPartMoveRate_;
		public float reelPartMinDistance_;
		public float reelPartMinDistanceFishesApproach_;
		public float reelPartDistanceToResetFishesApproachSpeed_;
		public float reelPartMaxTimeToRunAway_;
		public float reelPartLureSplashdownRippleRate_;
		public float reelPartLureReelRippleRate_;
		public float reelPartBiteActionRippleRate_;
		public float reelPartMinHeightOffsetToBite_;
		public int reelPartMinFramesToApproachLureBeforeBiteAction_;
		public float reelPartVibrationSmallVal_;
		public float reelPartVibrationLargeVal_;
		public int reelPartVibrationSpan_;
		public float reelPartVibrationSmallValAfterBiteAction_;
		public float reelPartVibrationLargeValAfterBiteAction_;
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
		public float lineTensionIncreaseValue_;
		public float lineTensionIncreaseByReel_;
		public float lineTensionIncreaseByReelWhenViolation_;
		public float lineTensionRecoveryByRodValue_;
		public float lineHpDamageRate_;
		public float lineWarningAppearThresholdDiff_;
		public float lineWarningLevel1_and_2_ThreholdDiff_;
		public float lineWarningLevel2_and_3_ThreholdDiff_;
		public float lineRippleSpeedThreshold_;
		public float lineRippleMinTimeSpan_;
		public float lineRipplePowerRate_;
		public float lineTensionMultiplierWhenJumpQTEFailed_;
		public float battlePartCameraHeight_;
		public float battlePartCameraDistance_;
		public float battlePartCameraLeftRightOffset_;
		public float battlePartMoveRate_;
		public float battleFishMoveInDegree_;
		public float battleFishMoveMinRadius_;
		public int battleTimeToAppearRodDirUI_;
		public float battleLineTensionToAppearRodDirUI_;
		public int battlePartTimeSpanForContinousReeling_;
		public float battlePartFishApproachThreshold1_;
		public float battlePartFishApproachRate1_;
		public float battleAddFovWhenReeling_;
		public float battleAddFovInterpParamWhenReeling_;
		public int battleAddFovBlendTypeWhenReeling_;
		public int battleJumpActionPrepareFrame_;
		public int battleJumpActionFinishFrame_;
		public float battleJumpActionCameraSmoothRate_;
		public UnityEngine.Vector4 battleJumpActionCameraLookAtOffset_;
		public UnityEngine.Vector4 battleJumpActionCameraEyePosOffset_;
		public float battleJumpActionDamageMultiplier_;
		public float battleViolationVFXAppearHeightOffset_;
		public float battleViolationRippleSizeRate_;
		public float battleViolationRippleTimeSpan_;
		public float battleJumpRiseVFXAppearHeightOffset_;
		public float battleJumpSplashVFXAppearHeightOffset_;
		public float battleJumpRiseRippleSizeRate_;
		public float battleJumpDownRippleSizeRate_;
		public int battleViolationAppearType_;
		public int battleNochtMotionFilterType_;
		public float battleNochtMotionRCFilterAlpha_;
		public float battleNochtMotionEaseOutFilterAlpha_;
		public int battleJumpRiseVFXMinTimeToAppear_;
		public float battlePartNormalModeVibrationSmallVal_;
		public float battlePartNormalModeVibrationLargeVal_;
		public float battlePartViolationModeVibrationSmallVal_;
		public float battlePartViolationModeVibrationLargeVal_;
		public float battlePartVibrationRateWhenReeling_;
		public float battlePartVibrationFishSizeMax_;
		public float battlePartVibrationFishSizeMin_;
		public float battlePartVibrationRateWhenFishSizeMax_;
		public float battlePartVibrationRateWhenFishSizeMin_;
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
		public float tgsLineHpInitialDecrease_;
		public float tgsFishForceJumpHpRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionFishingStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Fishing.SequenceActionFishingStart", 0, Black.Sequence.Action.Minigame.Fishing.SequenceActionFishingStart.ObjectType, null, properties, 0, 5200);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Fishing.SequenceActionFishingStart", base.GetFieldProperties(), -1655370534, -825985161);
            
			
			
			return fieldProperties;
        }

		
    }
}