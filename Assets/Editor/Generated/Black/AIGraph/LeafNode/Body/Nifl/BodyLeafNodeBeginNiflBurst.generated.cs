using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Nifl
{
    public partial class BodyLeafNodeBeginNiflBurst : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeBeginNiflBurst();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Nifl.BodyLeafNodeBeginNiflBurst", 0, Black.AIGraph.LeafNode.Body.Nifl.BodyLeafNodeBeginNiflBurst.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Nifl.BodyLeafNodeBeginNiflBurst", base.GetFieldProperties(), 415570332, 1879103086);
            
			
			
			return fieldProperties;
        }

		
    }
}