using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Corps
{
    public partial class SequenceActionAIGetReinforceList : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inOwnerActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outFindCount_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outFindLabels_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIGetReinforceList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetReinforceList", 0, Black.Sequence.Actor.AI.Corps.SequenceActionAIGetReinforceList.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetReinforceList", base.GetFieldProperties(), 48272367, 1901026986);
            
			
			
			return fieldProperties;
        }

		
    }
}