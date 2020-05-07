using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Sensor
{
    public partial class SequenceActionAICanSee : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin bool_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAICanSee();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Sensor.SequenceActionAICanSee", 0, Black.Sequence.Actor.AI.Sensor.SequenceActionAICanSee.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Sensor.SequenceActionAICanSee", base.GetFieldProperties(), 348731181, 1532309737);
            return fieldProperties;
        }

		
    }
}