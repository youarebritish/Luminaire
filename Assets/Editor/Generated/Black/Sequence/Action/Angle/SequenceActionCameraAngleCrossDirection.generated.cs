using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraAngleCrossDirection : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin calcPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin preOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin leftOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rightOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1NearOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1FarOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1NearRightOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1NearLeftOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1FarRightOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actor1FarLeftOutPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorsDirectionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin crossDirectionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isRightPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nearActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin farActorPin_;
		public bool isUseBasePC_;
		public bool isUseTargetPCTarget_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAngleCrossDirection();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraAngleCrossDirection", 0, Black.Sequence.Action.Angle.SequenceActionCameraAngleCrossDirection.ObjectType, null, properties, 0, 3280);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraAngleCrossDirection", base.GetFieldProperties(), -428476733, 1967878863);
            
			fieldProperties.AddProperty(new Property("calcPin_", 3721465300, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("clearPin_", 2510457522, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("preOutPin_", 1744652298, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("leftOutPin_", 3180113460, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rightOutPin_", 3192523915, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor1NearOutPin_", 3482450457, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor1FarOutPin_", 2220642430, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor1NearRightOutPin_", 740630861, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor1NearLeftOutPin_", 1751319062, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor1FarRightOutPin_", 1125737484, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2136, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor1FarLeftOutPin_", 2867879077, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2232, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetPin_", 4111270248, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor2Pin_", 3478505912, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2416, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor1Pin_", 2407986413, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorsDirectionPin_", 3116697156, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("crossDirectionPin_", 3969681556, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRightPin_", 3549614369, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearActorPin_", 2995072428, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("farActorPin_", 4094454259, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2944, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseBasePC_", 583811197, "bool", 3032, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseTargetPCTarget_", 351944606, "bool", 3033, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}