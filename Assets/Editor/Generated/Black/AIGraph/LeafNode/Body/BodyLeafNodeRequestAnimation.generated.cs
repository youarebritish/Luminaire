using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body
{
    public partial class BodyLeafNodeRequestAnimation : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animMsg;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum status;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat animPlayThreshold;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bContinueMessageExecuting;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeRequestAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestAnimation", 0, Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestAnimation.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestAnimation", base.GetFieldProperties(), -846418235, 1395430528);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.propertyId_", 1752564102, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.indexOfLinkedProperty_", 2920181987, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.value_", 3947388071, "SQEX.Ebony.Std.Fixid", 80, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.propertyId_", 1097509688, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.indexOfLinkedProperty_", 1329201901, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status.value_", 3916200893, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animPlayThreshold.propertyId_", 196411522, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animPlayThreshold.indexOfLinkedProperty_", 940257975, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animPlayThreshold.value_", 1539460459, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bContinueMessageExecuting.propertyId_", 2471777142, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bContinueMessageExecuting.indexOfLinkedProperty_", 976493523, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bContinueMessageExecuting.value_", 2619257527, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("animMsg", 2005261249, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("status", 3125508079, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animPlayThreshold", 1398097277, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bContinueMessageExecuting", 993456209, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}