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
            return fieldProperties;
        }

		
    }
}