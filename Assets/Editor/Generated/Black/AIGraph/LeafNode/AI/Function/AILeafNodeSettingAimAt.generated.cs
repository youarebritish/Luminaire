using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeSettingAimAt : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isSetAllSlot_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum aimAtSlot_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool aimAtEnable_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum atIKPointType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSettingAimAt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSettingAimAt", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeSettingAimAt.ObjectType, null, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSettingAimAt", base.GetFieldProperties(), -933900131, 447126499);
            return fieldProperties;
        }

		
    }
}