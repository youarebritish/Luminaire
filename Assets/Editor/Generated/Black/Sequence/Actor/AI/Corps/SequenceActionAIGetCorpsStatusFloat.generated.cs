using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Corps
{
    public partial class SequenceActionAIGetCorpsStatusFloat : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin float_;
		public int paramType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIGetCorpsStatusFloat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsStatusFloat", 0, Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsStatusFloat.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsStatusFloat", base.GetFieldProperties(), -1151917985, 45897213);
            return fieldProperties;
        }

		
    }
}