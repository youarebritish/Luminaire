using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeSendMessageBase : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid bodyMessage_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animBBParamId_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt actionType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkBodyCanRecieveMessage_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat messageTimer;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSendMessageBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageBase", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageBase.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageBase", base.GetFieldProperties(), -1884753831, 1515880853);
            
			
			
			return fieldProperties;
        }

		
    }
}