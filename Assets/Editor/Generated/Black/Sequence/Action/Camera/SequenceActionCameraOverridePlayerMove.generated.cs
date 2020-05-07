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
            
			fieldProperties.AddProperty(new Property("offensiveMovePin_", 2651935373, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("deffensiveMovePin_", 3353468577, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("magicMovePin_", 2897950693, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disablePin_", 911041999, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("magicTargetPin_", 2363075553, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLargeSwordChargingOutputPin_", 514973959, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMachineChargingOutputPin_", 207848048, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMagicMoveOutputPin_", 660229840, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("alternaInvokePositionPin_", 1124854641, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleCameraDistancePin_", 4175786303, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBattleCameraDistanceFarPin_", 1179345720, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnablePlayBattleProductionPin_", 2508806517, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isArmedformEosPin_", 1435910987, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNarrowPlacePin_", 2222334657, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraContainer0RotPin_", 2511929628, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableBattleBuddyCamera_Pin_", 2539782916, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTargetEnemyLargePin_", 2847520399, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nakamaTargetOutputPin_", 2431901566, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEpiPlayThunderDaggerVfxOutputPin_", 2829757392, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}