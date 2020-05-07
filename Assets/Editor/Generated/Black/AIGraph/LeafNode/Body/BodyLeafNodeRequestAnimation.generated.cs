using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body
{
    public partial class BodyLeafNodeRequestAnimation : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animMsg;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum status;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat animPlayThreshold;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bContinueMessageExecuting;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeRequestAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestAnimation", 0, Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestAnimation.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestAnimation", base.GetFieldProperties(), -846418235, 1395430528);
            
			
			
			return fieldProperties;
        }

		
    }
}