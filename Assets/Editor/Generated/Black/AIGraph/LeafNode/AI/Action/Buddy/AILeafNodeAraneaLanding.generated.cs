using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Buddy
{
    public partial class AILeafNodeAraneaLanding : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseTarget_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat heigt_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat slideTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool obstructed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAraneaLanding();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeAraneaLanding", 0, Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeAraneaLanding.ObjectType, null, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeAraneaLanding", base.GetFieldProperties(), 1907083628, -1847308505);
            
			
			
			return fieldProperties;
        }

		
    }
}