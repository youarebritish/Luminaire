using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Corps
{
    public partial class SequenceActionAIGetCreatablePropsList : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inOwnerActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outFindCount_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outFindProps_;
		public int filterTagCount_;
		public int filterTagCheckType_;
		public uint filterTag1_;
		public uint filterTag2_;
		public uint filterTag3_;
		public uint filterTag4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIGetCreatablePropsList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCreatablePropsList", 0, Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCreatablePropsList.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Corps.SequenceActionAIGetCreatablePropsList", base.GetFieldProperties(), 173410630, 1338149341);
            
			
			
			return fieldProperties;
        }

		
    }
}