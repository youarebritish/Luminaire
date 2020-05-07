using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Friend
{
    public partial class AILeafNodeRequestTalkInVehicle : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum talkRole;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum talkTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum talkMood;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxTime;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRequestTalkInVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeRequestTalkInVehicle", 0, Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeRequestTalkInVehicle.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeRequestTalkInVehicle", base.GetFieldProperties(), 372766507, -1376750631);
            
			
			
			return fieldProperties;
        }

		
    }
}