using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraOverridePlayerMove : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin offensiveMovePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin deffensiveMovePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin magicMovePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin magicTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isLargeSwordChargingOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isMachineChargingOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isMagicMoveOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin alternaInvokePositionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin battleCameraDistancePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isBattleCameraDistanceFarPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isEnablePlayBattleProductionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isArmedformEosPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isNarrowPlacePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cameraContainer0RotPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isEnableBattleBuddyCamera_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isTargetEnemyLargePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nakamaTargetOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isEpiPlayThunderDaggerVfxOutputPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraOverridePlayerMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraOverridePlayerMove", 0, Black.Sequence.Action.Camera.SequenceActionCameraOverridePlayerMove.ObjectType, null, properties, 0, 1976);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraOverridePlayerMove", base.GetFieldProperties(), 398938600, 36329137);
            
			
			
			return fieldProperties;
        }

		
    }
}