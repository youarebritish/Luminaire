using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeFollow : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin walkSpeedRatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin runSpeedRatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public int movementNearTarget_;
		public float walkSpeedRate_;
		public int movementFarTarget_;
		public float runSpeedRate_;
		public float arrivalInnerDistance_;
		public float arrivalOuterDistance_;
		public float walkingAreaRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeFollow();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeFollow", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeFollow.ObjectType, null, properties, 0, 1584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeFollow", base.GetFieldProperties(), -1017410623, 1992179424);
            
			fieldProperties.AddProperty(new Property("walkSpeedRatePin_", 3600108445, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("runSpeedRatePin_", 2185054075, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target_", 1693858869, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movementNearTarget_", 3029695500, "Black.AI.Move.AIMovement", 1488, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("walkSpeedRate_", 4153805498, "float", 1492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("movementFarTarget_", 3387188729, "Black.AI.Move.AIMovement", 1496, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("runSpeedRate_", 3923921264, "float", 1500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalInnerDistance_", 3761081506, "float", 1504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalOuterDistance_", 185253379, "float", 1508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("walkingAreaRadius_", 2639287024, "float", 1512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}