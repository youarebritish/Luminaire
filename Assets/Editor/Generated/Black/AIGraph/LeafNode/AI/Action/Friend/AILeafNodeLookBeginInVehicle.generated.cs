using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Friend
{
    public partial class AILeafNodeLookBeginInVehicle : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat frameAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isRight;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat initialAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isClockwise;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotateAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum mood;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isLookStarted;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeLookBeginInVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeLookBeginInVehicle", 0, Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeLookBeginInVehicle.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeLookBeginInVehicle", base.GetFieldProperties(), 1446323538, -2093493660);
            return fieldProperties;
        }

		
    }
}