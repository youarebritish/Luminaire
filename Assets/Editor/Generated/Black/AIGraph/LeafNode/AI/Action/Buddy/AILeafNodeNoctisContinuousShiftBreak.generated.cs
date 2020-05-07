using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Buddy
{
    public partial class AILeafNodeNoctisContinuousShiftBreak : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum target_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bCritical_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid messageNormal_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid messageFinish_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid messageNormalCRT_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid messageFinishCRT_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeNoctisContinuousShiftBreak();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeNoctisContinuousShiftBreak", 0, Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeNoctisContinuousShiftBreak.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeNoctisContinuousShiftBreak", base.GetFieldProperties(), 944381958, -1936139195);
            return fieldProperties;
        }

		
    }
}