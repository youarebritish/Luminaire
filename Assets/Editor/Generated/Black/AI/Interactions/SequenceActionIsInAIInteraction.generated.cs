using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Interactions
{
    public partial class SequenceActionIsInAIInteraction : Black.AI.Ambient.AmbientSequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint scriptId_;
		public uint scriptGroupId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin true_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin false_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionIsInAIInteraction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Interactions.SequenceActionIsInAIInteraction", 0, Black.AI.Interactions.SequenceActionIsInAIInteraction.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.AI.Interactions.SequenceActionIsInAIInteraction", base.GetFieldProperties(), -1458601551, 1720953835);
            
			
			
			return fieldProperties;
        }

		
    }
}