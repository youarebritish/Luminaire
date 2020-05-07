using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Corps
{
    public partial class SequenceActionAIGetCorpsStatusBool : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin bool_;
		public int paramType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIGetCorpsStatusBool();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsStatusBool", 0, Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsStatusBool.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCorpsStatusBool", base.GetFieldProperties(), -32365910, 1422610493);
            return fieldProperties;
        }

		
    }
}