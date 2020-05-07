using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body
{
    public partial class BodyLeafNodeRegistAnimationMessage : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum status;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat animPlayThreshold;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bContinueMessageExecuting;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeRegistAnimationMessage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.BodyLeafNodeRegistAnimationMessage", 0, Black.AIGraph.LeafNode.Body.BodyLeafNodeRegistAnimationMessage.ObjectType, null, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.BodyLeafNodeRegistAnimationMessage", base.GetFieldProperties(), 1887157848, 1001175757);
            
			
			
			return fieldProperties;
        }

		
    }
}