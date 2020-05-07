using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraAngleBattleDirection : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin judgePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin targetCacheOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetInputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin resultOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin resultVOutputPin_;
		public int angleOperatorType_;
		public bool isUseCache_;
		public bool isUseTargetCache_;
		public bool isBlockActivateOutWhenPcTargetIsNotExist_;
		public float baseYHeightFromTrans_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAngleBattleDirection();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraAngleBattleDirection", 0, Black.Sequence.Action.Angle.SequenceActionCameraAngleBattleDirection.ObjectType, null, properties, 0, 1896);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraAngleBattleDirection", base.GetFieldProperties(), 1089011804, -1031551262);
            
			fieldProperties.AddProperty(new Property("judgePin_", 955830756, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("clearPin_", 2510457522, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetCacheOutputPin_", 1146448975, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetInputPin_", 1340954284, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultOutputPin_", 1119457269, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("resultVOutputPin_", 1778024523, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleOperatorType_", 469417645, "Black.Sequence.Action.Angle.SequenceActionCameraAngleBattleDirection.BattleAngleOperatorType", 1816, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseCache_", 3315021555, "bool", 1820, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseTargetCache_", 2922263126, "bool", 1821, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isBlockActivateOutWhenPcTargetIsNotExist_", 701371714, "bool", 1822, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("baseYHeightFromTrans_", 3478351643, "float", 1824, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}