using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Friend
{
    public partial class AILeafNodeExecGambit : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum channel;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bDebugLog;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isTargetNotExist;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isGambitNotExist;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bReset;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseCautionTargetWhenCheckMotionCancel;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeExecGambit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeExecGambit", 0, Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeExecGambit.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Friend.AILeafNodeExecGambit", base.GetFieldProperties(), -2041570298, 414688347);
            return fieldProperties;
        }

		
    }
}