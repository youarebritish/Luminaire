using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeSetLinkAnim : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkAllParticipantsCanJoin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid linkanimMessage_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid inviteMessage_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSetLinkAnim();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeSetLinkAnim", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeSetLinkAnim.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeSetLinkAnim", base.GetFieldProperties(), 335528762, 1606250074);
            return fieldProperties;
        }

		
    }
}