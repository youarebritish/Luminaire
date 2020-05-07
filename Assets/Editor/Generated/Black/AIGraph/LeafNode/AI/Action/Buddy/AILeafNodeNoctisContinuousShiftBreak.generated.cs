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
            
			fieldProperties.AddProperty(new Property("target_", 1693858869, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bCritical_", 3433544565, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("messageNormal_", 951663112, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("messageFinish_", 1454673476, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("messageNormalCRT_", 2579197551, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("messageFinishCRT_", 4088835531, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}