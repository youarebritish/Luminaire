using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Buddy
{
    public partial class AILeafNodeIgnisJCSub1 : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt attackNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeIgnisJCSub1();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeIgnisJCSub1", 0, Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeIgnisJCSub1.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeIgnisJCSub1", base.GetFieldProperties(), 2097359968, 1722115678);
            
			
			
			return fieldProperties;
        }

		
    }
}