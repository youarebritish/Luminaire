using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Mode
{
    public partial class BodyLeafNodeWaitIdleModeChange : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeWaitIdleModeChange();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Mode.BodyLeafNodeWaitIdleModeChange", 0, Black.AIGraph.LeafNode.Body.Mode.BodyLeafNodeWaitIdleModeChange.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Mode.BodyLeafNodeWaitIdleModeChange", base.GetFieldProperties(), 1260397245, 1028866443);
            return fieldProperties;
        }

		
    }
}