using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Corps
{
    public partial class SequenceActionAIGetCorpsRoll : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inCorpsActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rollName_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin argument_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIGetCorpsRoll();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsRoll", 0, Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsRoll.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsRoll", base.GetFieldProperties(), -106904225, 995993107);
            return fieldProperties;
        }

		
    }
}