using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Reinforcement
{
    public partial class SequenceActionGetRandomNiflShipInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int type_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isNiflShipPatrolTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nextNiflShipPatrolTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin boolOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aircraftIn_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetRandomNiflShipInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Reinforcement.SequenceActionGetRandomNiflShipInfo", 0, Black.Sequence.Action.Level.Reinforcement.SequenceActionGetRandomNiflShipInfo.ObjectType, null, properties, 0, 536);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Reinforcement.SequenceActionGetRandomNiflShipInfo", base.GetFieldProperties(), 373943708, -41421354);
            
			fieldProperties.AddProperty(new Property("type_", 3554705238, "Black.Sequence.Action.Level.Reinforcement.SequenceActionGetRandomNiflShipInfo.InfoType", 176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNiflShipPatrolTime_", 658071320, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nextNiflShipPatrolTime_", 2261159859, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("boolOut_", 432819512, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("aircraftIn_", 3461811757, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}