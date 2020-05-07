using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Camera
{
    public partial class AILeafNodeReserveCameraSequenceEvent : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeReserveCameraSequenceEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Camera.AILeafNodeReserveCameraSequenceEvent", 0, Black.AIGraph.LeafNode.AI.Function.Camera.AILeafNodeReserveCameraSequenceEvent.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Camera.AILeafNodeReserveCameraSequenceEvent", base.GetFieldProperties(), -1336443069, -88808366);
            return fieldProperties;
        }

		
    }
}